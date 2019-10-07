using Mashkanta.Entities;
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in _dataSource)
            {
                item.StopAtPeriod = null;
            }

            _mix.Courses.Clear();
            _mix.TotalLoan = double.Parse(txtAmount.Text);
            _mix.Courses.AddRange(_dataSource);

            //var prime1 = new Course { Type = Course.CourseType.Prime, Amount = 363000, InterestGap = -0.7, Period = 290, StopAtPeriod = 180 };
            //prime1.Calc();
            //var prime2 = new Course { Type = Course.CourseType.Prime, Amount = prime1.Result.RemainFund, InterestGap = 0.7, Period = 18, StartMonth = 181 };
            //var prime = new Course { Type = Course.CourseType.Prime, Amount = 363000, InterestGap = -0.7, Period = 290 };
            //var fix = new Course { Type = Course.CourseType.Fix, Amount = 462000, InterestGap = 3.2, Period = 159 };
            //var varpi = new Course { Type = Course.CourseType.VariablePriceIndex, Amount = 275000, InterestGap = 2.5, Period = 180 };

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            _mix.TotalLoan = double.Parse(txtAmount.Text);
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
            btnStart_Click(null, null);
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

        private void button3_Click(object sender, EventArgs e)
        {
            var prime = new Course { Type = Course.CourseType.Prime, Amount = 363000, InterestGap = -0.7, Period = 240 };
            var fix = new Course { Type = Course.CourseType.Fix, Amount = 737000, InterestGap = 3.2, Period = 180 };
            var varpi = new Course { Type = Course.CourseType.VariablePriceIndex, Amount = 0, InterestGap = 2.5, Period = 120 };

            var result = string.Empty;
            var gap = 1000;

            for (int i = 0; i <= 737000; i += gap)
            {
                varpi.Amount += gap;
                fix.Amount -= gap;
                var mix = new Mix
                {
                    TotalLoan = prime.Amount + fix.Amount + varpi.Amount,
                };
                mix.Courses.AddRange(new[] { prime, fix, varpi });
                mix.Calc();

                result += $"{mix.TotalInterestAndPriceIndex:N2},{fix.Amount},{varpi.Amount}\r\n";
            }
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
                    _mix.Recycle(course, new RecycleCourse { InterestGap = -0.7, Period = 40, FromMonth = 121 });
                    RefreshResult();
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
    }
}