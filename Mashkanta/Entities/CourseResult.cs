using Mashkanta.Entities;
using System.Collections.Generic;
using System.Linq;
using static Mashkanta.Course;

namespace Mashkanta
{
    public class CourseResult
    {
        public CourseResult()
        {
            Payments = new PaymentList();
        }

        public double TotalReturn { get; set; }

        public double TotalInterestAndPriceIndex { get; set; }

        public double MaxMonthReturn { get; set; }

        public double MinMonthReturn { get; set; }

        public double Ratio { get; set; }

        public double RemainingFund { get; set; }

        public PaymentList Payments { get; private set; }

        public void SetVariables()
        {
            // for Git Commit
            TotalReturn = Utils.Round2(Payments.Sum(p => p.TotalPayment));
            TotalInterestAndPriceIndex = Utils.Round2(Payments.Sum(p => p.InterestPayment) + Payments.Sum(p => p.FundPaymentWithPriceIndex) - Payments.Sum(p => p.FundPayment));
            MaxMonthReturn = Payments.Max(p => p.TotalPayment);
            MinMonthReturn = Payments.Min(p => p.TotalPayment);
            Ratio = Utils.Round2(TotalReturn / Payments.Sum(p => p.FundPayment));
            var payment = Payments.Last();
            RemainingFund = Utils.Round2(payment.TotalFund - payment.FundPayment);
        }

        public string ToHtml(CourseType courseType)
        {
            var table1 = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.Table1.html");

            table1 = table1.Replace("@@TITLE@@", Course.GetCourseTitle(courseType));
            table1 = table1.Replace("@@RATIO@@", Ratio.ToString("N2"));
            table1 = table1.Replace("@@MIN_PAYMENT@@", MinMonthReturn.ToString("N2"));
            table1 = table1.Replace("@@MAX_PAYMENT@@", MaxMonthReturn.ToString("N2"));
            table1 = table1.Replace("@@TOTAL_PAYMENT@@", TotalReturn.ToString("N2"));
            table1 = table1.Replace("@@INTEREST@@", TotalInterestAndPriceIndex.ToString("N2"));

            var result = $"{table1}\r\n{Payments.ToHtml(courseType)}\r\n<hr />";
            return result;
        }
    }
}