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

        public double TotalReturn
        {
            get
            {
                return Utils.Round2(Payments.Sum(p => p.TotalPayment));
            }
        }

        public double TotalInterestAndPriceIndex
        {
            get
            {
                return Utils.Round2(Payments.Sum(p => p.InterestPayment) + Payments.Sum(p => p.FundPaymentWithPriceIndex) - Payments.Sum(p => p.FundPayment));
            }
        }

        public double MaxMonthReturn
        {
            get
            {
                return Payments.Max(p => p.TotalPayment);
            }
        }

        public double MinMonthReturn
        {
            get
            {
                return Payments.Min(p => p.TotalPayment);
            }
        }

        public double Ratio
        {
            get
            {
                return Utils.Round2(TotalReturn / Payments.Sum(p => p.FundPayment));
            }
        }

        public double RemainingFund
        {
            get
            {
                var payment = Payments.Last();
                return Utils.Round2(payment.TotalFund - payment.FundPayment);
            }
        }

        public List<Payment> Payments { get; private set; }
    }
}