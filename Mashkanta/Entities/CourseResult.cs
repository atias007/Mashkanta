using System.Collections.Generic;
using System.Linq;

namespace Mashkanta
{
    public class CourseResult
    {
        public CourseResult()
        {
            Payments = new List<Payment>();
        }

        public double TotalReturn { get; set; }

        public double TotalInterestAndPriceIndex { get; set; }

        public double MaxMonthReturn { get; set; }

        public double MinMonthReturn { get; set; }

        public double Ratio { get; set; }

        public double RemainingFund { get; set; }

        public List<Payment> Payments { get; private set; }

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
    }
}