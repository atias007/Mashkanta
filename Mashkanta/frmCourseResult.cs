using Mashkanta.Entities;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mashkanta
{
    public partial class frmCourseResult : Form
    {
        private int _gridWith = 0;

        private frmCourseResult()
        {
            InitializeComponent();
        }

        public frmCourseResult(Course course) : this()
        {
            lblAmount.Text = course.Amount.ToString("N0");
            lblCourse.Text = course.Type.ToString();
            lblInterest.Text = course.InterestGap.ToString("N2");
            lblLoanPercentage.Text = (course.LoanPercentage * 100).ToString("N0") + "%";
            lblMaxReturn.Text = course.Result.MaxMonthReturn.ToString("N2");
            lblMinReturn.Text = course.Result.MinMonthReturn.ToString("N2");
            lblPeriodMonth.Text = course.Period.ToString("N0");
            lblPeriodYears.Text = (course.Period / 12.0).ToString("N2");
            lblRatio.Text = course.Result.Ratio.ToString("N2");
            lblTotalInt.Text = course.Result.TotalInterestAndPriceIndex.ToString("N2");
            lblTotalReturn.Text = course.Result.TotalReturn.ToString("N2");
            lblTotalFund.Text = course.Result.RemainingFund.ToString("N2");

            grdPayments.DataSource = course.Result.Payments;
            DesignGrid(grdPayments, course.Type);

            SetCharts(course);
        }

        public frmCourseResult(Mix mix) : this()
        {
            lblAmount.Text = mix.TotalLoan.ToString("N0");
            lblCourse.Text = "-";
            lblInterest.Text = "-";
            lblLoanPercentage.Text = "-";
            lblMaxReturn.Text = mix.MaxMonthReturn.ToString("N2");
            lblMinReturn.Text = mix.MinMonthReturn.ToString("N2");
            lblPeriodMonth.Text = "-";
            lblPeriodYears.Text = "-";
            lblRatio.Text = mix.Ratio.ToString("N2");
            lblTotalInt.Text = mix.TotalInterestAndPriceIndex.ToString("N2");
            lblTotalReturn.Text = mix.TotalReturn.ToString("N2");
            lblTotalFund.Text = mix.TotalRemainingFund.ToString("N2");

            grdSum.ColumnStyles[0].Width = 0;
            grdSum.ColumnStyles[1].Width = 0;
            grdSum.Width = grdSum.Width / 2;
            grdSum.Left = this.Width - grdSum.Width - 32;

            grdPayments.DataSource = mix.TotalPayments;
            DesignGrid(grdPayments, Course.CourseType.None);
            SetCharts(mix);
        }

        private void SetCharts(Mix mix)
        {
            var series1 = chart1.Series.Add("TotalFundWithPriceIndex");
            series1.ChartType = SeriesChartType.Line;
            foreach (var item in mix.TotalPayments)
            {
                series1.Points.AddXY(item.Period, item.TotalFundWithPriceIndex);
            }

            chart2.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Add("תשלום קרן");
            chart2.Legends.Add("תשלום ריבית");
            chart2.Legends.Add("תשלום כולל");

            var series2 = chart2.Series.Add("תשלום קרן");
            series2.ChartType = SeriesChartType.Line;
            var series3 = chart2.Series.Add("תשלום ריבית");
            series3.ChartType = SeriesChartType.Line;
            var series4 = chart2.Series.Add("תשלום כולל");
            series4.ChartType = SeriesChartType.Line;
            foreach (var item in mix.TotalPayments)
            {
                series2.Points.AddXY(item.Period, item.FundPaymentWithPriceIndex);
                series3.Points.AddXY(item.Period, item.InterestPayment);
                series4.Points.AddXY(item.Period, item.TotalPayment);
            }
        }

        private void SetCharts(Course course)
        {
            var series1 = chart1.Series.Add("TotalFundWithPriceIndex");
            series1.ChartType = SeriesChartType.Line;
            foreach (var item in course.Result.Payments)
            {
                series1.Points.AddXY(item.Period, item.TotalFundWithPriceIndex);
            }

            chart2.Legends.Clear();
            chart2.Series.Clear();
            chart2.Legends.Add("תשלום קרן");
            chart2.Legends.Add("תשלום ריבית");
            chart2.Legends.Add("תשלום כולל");

            var series2 = chart2.Series.Add("תשלום קרן");
            series2.ChartType = SeriesChartType.Line;
            var series3 = chart2.Series.Add("תשלום ריבית");
            series3.ChartType = SeriesChartType.Line;
            var series4 = chart2.Series.Add("תשלום כולל");
            series4.ChartType = SeriesChartType.Line;
            foreach (var item in course.Result.Payments)
            {
                series2.Points.AddXY(item.Period, item.FundPaymentWithPriceIndex);
                series3.Points.AddXY(item.Period, item.InterestPayment);
                series4.Points.AddXY(item.Period, item.TotalPayment);
            }

            if (course.Type == Course.CourseType.FixPriceIndex || course.Type == Course.CourseType.VariablePriceIndex)
            {
                AddPriceIndexChart("PriceIndex", "מדד שנתי", course);
            }

            AddInterestChart("Interest", "אחוז ריבית שנתי", course);
        }

        private void AddInterestChart(string name, string text, Course course)
        {
            var series = AddChart(name, text);

            for (var i = 0; i < course.Result.Payments.Count; i += 12)
            {
                var item = course.Result.Payments[i];
                series.Points.AddXY(item.Period, item.InterestYearPercentage);
            }
        }

        private void AddPriceIndexChart(string name, string text, Course course)
        {
            var series = AddChart(name, text);

            for (var i = 0; i < course.Result.Payments.Count; i += 12)
            {
                var item = course.Result.Payments[i];
                series.Points.AddXY(item.Period, item.PriceIndex * 12);
            }
        }

        private Series AddChart(string name, string text)
        {
            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea($"{name}Area"));
            chart.Dock = DockStyle.Top;
            chart.Location = new Point(0, 300);
            chart.Name = $"{name}Chart";
            var series = new Series($"{name}Series");
            series.ChartArea = $"{name}Area";
            series.Name = $"{name}Series";
            series.ChartType = SeriesChartType.Line;
            chart.Series.Add(series);
            chart.Size = new Size(402, 300);
            var title = new Title();
            title.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Name = $"{name}Title";
            title.Text = text;
            chart.Titles.Add(title);
            chart.SendToBack();
            panel2.Controls.Add(chart);

            return series;
        }

        private void DesignGrid(DataGridView grid, Course.CourseType type)
        {
            _gridWith = 0;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                var visible = ColumnVisible(col.HeaderText, type);
                if (visible == false)
                {
                    col.Visible = false;
                }
                else
                {
                    switch (col.HeaderText)
                    {
                        case "Period":
                            col.HeaderText = "תקופה";
                            col.Width = 75;
                            col.DisplayIndex = 0;
                            break;

                        case "InterestMonthPercentage":
                            col.HeaderText = "% ריבית חודשי";
                            col.DefaultCellStyle.Format = "N4";
                            //col.Width = 125;
                            break;

                        case "InterestYearPercentage":
                            col.HeaderText = "% ריבית שנתי";
                            col.DefaultCellStyle.Format = "N4";
                            //col.Width = 125;
                            break;

                        case "InterestPayment":
                            col.HeaderText = "תשלום ריבית";
                            col.DefaultCellStyle.Format = "N2";
                            col.Width = 125;
                            break;

                        case "FundPayment":
                            col.HeaderText = "תשלום קרן";
                            col.DefaultCellStyle.Format = "N2";
                            col.Width = 125;
                            break;

                        case "FundPaymentWithPriceIndex":
                            col.HeaderText = "תשלום קרן צמוד";
                            col.DefaultCellStyle.Format = "N2";
                            col.Width = 125;
                            break;

                        case "TotalFund":
                            col.HeaderText = "יתרת קרן";
                            col.DefaultCellStyle.Format = "N2";
                            break;

                        case "TotalFundWithPriceIndex":
                            col.HeaderText = "יתרת קרן צמודה";
                            col.DefaultCellStyle.Format = "N2";
                            col.Width = 125;
                            break;

                        case "TotalPayment":
                            col.HeaderText = "החזר חודשי כולל";
                            col.DefaultCellStyle.Format = "N2";
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            col.Width = 125;
                            break;

                        case "PriceIndex":
                            col.HeaderText = "מדד חודשי";
                            col.DefaultCellStyle.Format = "N4";
                            col.DisplayIndex = 2;
                            break;

                        case "PeriodDate":
                            col.HeaderText = "חודש";
                            col.DefaultCellStyle.Format = "MM/yyyy";
                            col.DisplayIndex = 1;
                            col.Width = 75;
                            break;

                        default:
                            break;
                    }

                    _gridWith += col.Width + 2;
                }
            }

            Application.DoEvents();
        }

        private bool ColumnVisible(string headerText, Course.CourseType type)
        {
            var result = false;

            switch (headerText)
            {
                case "InterestMonthPercentage":
                case "InterestYearPercentage":
                    switch (type)
                    {
                        case Course.CourseType.None:
                            result = false;
                            break;

                        default:
                            result = true;
                            break;
                    }
                    break;

                case "PeriodDate":
                case "TotalFund":
                case "Period":
                case "InterestPayment":
                case "FundPayment":
                case "TotalPayment":
                    result = true;
                    break;

                case "FundPaymentWithPriceIndex":
                case "TotalFundWithPriceIndex":
                case "PriceIndex":
                    switch (type)
                    {
                        case Course.CourseType.None:
                        case Course.CourseType.Fix:
                        case Course.CourseType.Prime:
                        case Course.CourseType.Variable:
                            result = false;
                            break;

                        case Course.CourseType.FixPriceIndex:
                        case Course.CourseType.VariablePriceIndex:
                        default:
                            result = true;
                            break;
                    }
                    break;

                default:
                    break;
            }

            return result;
        }

        private void grdPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grdPayments.Columns[e.ColumnIndex].DataPropertyName == "TotalPayment")
            {
                e.CellStyle.BackColor = Color.FromArgb(198, 239, 206);
            }
        }

        private void frmCourseResult_Load(object sender, System.EventArgs e)
        {
            panel1.Width = _gridWith + 15;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (panel1.Visible)
            {
                btnShowHide.Text = "הצג טבלה";
                panel1.Visible = false;
            }
            else
            {
                btnShowHide.Text = "הסתר טבלה";
                panel1.Visible = true;
            }
        }
    }
}