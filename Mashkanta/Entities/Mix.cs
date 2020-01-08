using Mashkanta.Charts;
using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Entities
{
    public class Mix
    {
        public double TotalLoan
        {
            get
            {
                return ActiveCourses.Sum(c => c.Amount);
            }
        }

        public List<Course> ActiveCourses
        {
            get
            {
                return Courses.Where(c => c.Active).ToList();
            }
        }

        public SummeryList Summery { get; private set; } = new SummeryList();

        public CourseList Courses { get; private set; } = new CourseList();

        public PaymentList TotalPayments { get; private set; } = new PaymentList();

        public double Ratio { get; private set; }

        public double MaxMonthReturn { get; private set; }

        public double MinMonthReturn { get; private set; }

        public double TotalReturn { get; private set; }

        public double TotalRemainingFund { get; private set; }

        public double TotalInterestAndPriceIndex
        {
            get
            {
                var result = Utils.Round2(ActiveCourses.Sum(p => p.Result.TotalInterestAndPriceIndex));
                return result;
            }
        }

        public double TotalInterest
        {
            get
            {
                var result = Utils.Round2(ActiveCourses.Sum(p => p.Result.TotalInterest));
                return result;
            }
        }

        public double TotalPriceIndex
        {
            get
            {
                var result = Utils.Round2(ActiveCourses.Sum(p => p.Result.TotalPriceIndex));
                return result;
            }
        }

        public void Calc()
        {
            foreach (var item in ActiveCourses)
            {
                item.Calc();
                item.LoanPercentage = Utils.Round2(item.Amount / TotalLoan);
            }

            SetTotalPayments();
            SetSummery();
            SetVariables();
        }

        private void SetSummery()
        {
            var result = TotalPayments.GroupBy(p => p.Year);
            foreach (var item in result)
            {
                var sum = new Summery
                {
                    Year = item.Key,
                    AveragePayment = item.Average(i => i.TotalPayment),
                    TotalPayment = item.Sum(i => i.TotalPayment),
                };

                Summery.Add(sum);
            }
        }

        private void SetVariables()
        {
            Ratio = Utils.Round2(ActiveCourses.Sum(c => c.Result.TotalReturn) / TotalLoan);
            MaxMonthReturn = Utils.Round2(TotalPayments.Max(p => p.TotalPayment));
            MinMonthReturn = Utils.Round2(TotalPayments.First().TotalPayment);
            TotalReturn = Utils.Round2(ActiveCourses.Sum(p => p.Result.TotalReturn));
            TotalRemainingFund = Utils.Round2(ActiveCourses.Sum(p => p.Result.RemainingFund));
        }

        private void SetTotalPayments()
        {
            var maxPayments = ActiveCourses.Max(c => c.Result.Payments.Max(p => p.Period));
            TotalPayments.Clear();

            for (int i = 0; i < maxPayments; i++)
            {
                var payments = GetPayments(i);
                var payment = new Payment
                {
                    FundPayment = payments.Sum(p => p.FundPayment),
                    FundPaymentWithPriceIndex = payments.Sum(p => p.FundPaymentWithPriceIndex),
                    InterestPayment = payments.Sum(p => p.InterestPayment),
                    InterestMonthPercentage = 0,
                    InterestYearPercentage = 0,
                    Period = i + 1,
                    PriceIndex = payments.Max(p => p.PriceIndex),
                    TotalFund = payments.Sum(p => p.TotalFund),
                    TotalFundWithPriceIndex = payments.Sum(p => p.TotalFundWithPriceIndex),
                    TotalPayment = payments.Sum(p => p.TotalPayment),
                };
                TotalPayments.Add(payment);
            }
        }

        public string ToHtml()
        {
            var report = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.Report.html");
            var table1 = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.Table1.html");
            var courses = Courses.ToHtml();
            var summery = Summery.ToHtml();

            table1 = table1.Replace("@@TITLE@@", Course.GetCourseTitle(Course.CourseType.None));
            table1 = table1.Replace("@@RATIO@@", Ratio.ToString("N2"));
            table1 = table1.Replace("@@MIN_PAYMENT@@", MinMonthReturn.ToString("N2"));
            table1 = table1.Replace("@@MAX_PAYMENT@@", MaxMonthReturn.ToString("N2"));
            table1 = table1.Replace("@@TOTAL_PAYMENT@@", TotalReturn.ToString("N2"));
            table1 = table1.Replace("@@INTEREST@@", TotalInterestAndPriceIndex.ToString("N2"));

            var tableAll = table1 + TotalPayments.ToHtml(Course.CourseType.None);
            report = report.Replace("@@COURSES@@", courses);
            report = report.Replace("@@SUMMERY@@", summery);
            report = report.Replace("@@TABLE_ALL@@", tableAll);
            report = report.Replace("@@PaymentDoughnutChart@@", new PaymentDoughnut(this, "PaymentDoughnutChart").ToHtml());

            var tableCources = string.Empty;
            foreach (var c in Courses)
            {
                tableCources += c.Result.ToHtml(c.Type);
            }

            report = report.Replace("@@TABLE_COURSE@@", tableCources);

            return report;
        }

        private List<Payment> GetPayments(int period)
        {
            var result = new List<Payment>();

            foreach (var c in ActiveCourses)
            {
                var currentPayment = c.Result.Payments.Where(p => p.Period == period + 1).FirstOrDefault();

                if (currentPayment == null)
                {
                    var p = c.Result.Payments.Last();
                    if (p.Period < period + 1)
                    {
                        result.Add(new Payment
                        {
                            TotalFund = p.TotalFund - p.FundPayment,
                            TotalFundWithPriceIndex = p.TotalFundWithPriceIndex - p.FundPaymentWithPriceIndex,
                            TotalPayment = 0,
                            FundPayment = 0,
                            FundPaymentWithPriceIndex = 0,
                            InterestPayment = 0,
                            InterestMonthPercentage = 0,
                            InterestYearPercentage = 0,
                            Period = 0,
                            PriceIndex = 0,
                        });
                    }
                    else
                    {
                    }
                }
                else
                {
                    result.Add(currentPayment);
                }
            }

            return result;
        }
    }
}