using Mashkanta.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mashkanta
{
    public partial class Form1 : Form
    {
        private BindingList<Course> _dataSource = new BindingList<Course>();
        private Mix _mix = new Mix();
        private List<Mix> _savedMixes = new List<Mix>();

        public Form1()
        {
            InitializeComponent();

            var ds = new List<LookupItem>
            {
                new LookupItem { Title = "[בחר מסלול]", Value = Course.CourseType.None },
                new LookupItem { Title = "קבוע", Value = Course.CourseType.Fix },
                new LookupItem { Title = "קבועה צמודה", Value = Course.CourseType.FixPriceIndex },
                new LookupItem { Title = "פריים", Value = Course.CourseType.Prime },
                new LookupItem { Title = "משתנה", Value = Course.CourseType.Variable },
                new LookupItem { Title = "משתנה צמודה", Value = Course.CourseType.VariablePriceIndex },
            };

            (colType as DataGridViewComboBoxColumn).DataSource = ds.OrderBy(i => i.Title).ToList();
            (colType as DataGridViewComboBoxColumn).ValueMember = "Value";
            (colType as DataGridViewComboBoxColumn).DisplayMember = "Title";
        }

        public Form1(Mix mix) : this()
        {
            _mix = mix;

            txtAmount.Value = _mix.TotalLoan;
            foreach (var item in mix.Courses)
            {
                _dataSource.Add(item);
            }

            RefreshResult();
            panel1.Visible = false;
            panel2.Height = 195;
            colButton.Visible = false;
            colType.ReadOnly = true;
            colAmount.ReadOnly = true;
            colInterestGap.ReadOnly = true;
            colPeriod.ReadOnly = true;
            grdCourses.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in _dataSource)
            {
                item.StopAtPeriod = null;
            }

            button3.Enabled = true;
            _mix = new Mix();
            _mix.Courses.Clear();
            _mix.TotalLoan = double.Parse(txtAmount.Text);
            _mix.Courses.AddRange(_dataSource);

            _mix.Calc();
            RefreshResult();
        }

        private void RefreshResult()
        {
            tabControl1.TabPages.Clear();
            var f = new frmCourseResult(_mix);
            var page1 = new TabPage { Text = "כל המסלולים" };
            tabControl1.TabPages.Add(page1);
            f.TopLevel = false;
            page1.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

            grdCourses.Refresh();

            foreach (var c in _mix.Courses)
            {
                var page = new TabPage { Text = c.Type.ToString() };
                tabControl1.TabPages.Add(page);
                page.Controls.Clear();
                var frm = new frmCourseResult(c);
                frm.TopLevel = false;
                page.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdCourses.DataSource = _dataSource;
            colButton.DisplayIndex = grdCourses.Columns.Count - 1;
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtAmount.Value = 1100000;
            var prime = new Course { Type = Course.CourseType.Prime, Amount = 363000, InterestGap = -0.7, Period = 290 };
            var fix = new Course { Type = Course.CourseType.Fix, Amount = 462000, InterestGap = 3.2, Period = 159 };
            var varpi = new Course { Type = Course.CourseType.VariablePriceIndex, Amount = 275000, InterestGap = 2.5, Period = 180 };
            _dataSource.Add(prime);
            _dataSource.Add(fix);
            _dataSource.Add(varpi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = string.Empty;

            data += "Total\r\n";
            foreach (var p in _mix.TotalPayments)
            {
                data += $"{p.Period + 1},{p.PeriodDate:MM/yyyy},{p.InterestMonthPercentage:N4}%,\"{p.TotalPayment:N0}\"\r\n";
            }

            foreach (var c in _mix.Courses)
            {
                data += $"\r\n{c.Type}\r\n";
                foreach (var p in c.Result.Payments)
                {
                    data += $"{p.Period + 1},{p.PeriodDate:MM/yyyy},{p.InterestMonthPercentage:N4},\"{p.TotalPayment:N2}\",{p.InterestPayment}\r\n";
                }
            }

            File.WriteAllText("report.csv", data);
            Process.Start("report.csv");
        }

        private void grdCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                if (_mix.TotalPayments.Count == 0)
                {
                    MessageBox.Show("לביצוע מחזור תחילה יש לבצע חישוב", "שגיאה...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    var course = senderGrid.Rows[e.RowIndex].DataBoundItem as Course;
                    using (var f = new frmRecycle(course))
                    {
                        var dialog = f.ShowDialog(this);
                        if (dialog == DialogResult.OK)
                        {
                            _mix.Recycle(course, f.Result);
                            RefreshResult();
                            button3.Enabled = true;
                        }
                    }
                }
            }
        }

        private void grdCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0 && e.RowIndex < senderGrid.Rows.Count - 1)
            {
                e.Value = "מחזור";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cloneMixJson = JsonConvert.SerializeObject(_mix);
            var cloneMix = JsonConvert.DeserializeObject<Mix>(cloneMixJson);
            cloneMix.ReCalc();
            button3.Enabled = false;
            _savedMixes.Add(cloneMix);
            MessageBox.Show("הצעה נשמרה בהצלחה", "הודעה...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var f = new frmCompare(_savedMixes))
            {
                f.ShowDialog();
            }
        }
    }
}