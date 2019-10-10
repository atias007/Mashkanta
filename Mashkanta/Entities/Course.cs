using Mashkanta.Courses;
using System.Linq;

namespace Mashkanta
{
    public class Course
    {
        public enum CourseType
        {
            None,
            Fix,
            FixPriceIndex,
            Prime,
            Variable,
            VariablePriceIndex
        }

        public Course()
        {
            StartMonth = 1;
        }

        public CourseType Type { get; set; }

        public double Amount { get; set; }

        public double InterestGap { get; set; }

        public int Period { get; set; }

        public int? StopAtPeriod { get; set; }

        public int StartMonth { get; set; }

        public double LoanPercentage { get; set; }

        public CourseResult Result { get; set; }

        public void Calc()
        {
            switch (Type)
            {
                case CourseType.Fix:
                    Fix.Calc(this);
                    break;

                case CourseType.FixPriceIndex:
                    FixPriceIndex.Calc(this);
                    break;

                case CourseType.Prime:
                    Prime.Calc(this);
                    break;

                case CourseType.Variable:
                    Variable.Calc(this);
                    break;

                case CourseType.VariablePriceIndex:
                    VariablePriceIndex.Calc(this);
                    break;

                default:
                    break;
            }

            ReCalc();
        }

        public void ReCalc()
        {
            Result.TotalReturn = Utils.Round2(Result.Payments.Sum(p => p.TotalPayment));
            Result.TotalInterestAndPriceIndex = Utils.Round2(Result.Payments.Sum(p => p.InterestPayment) + Result.Payments.Sum(p => p.FundPaymentWithPriceIndex) - Result.Payments.Sum(p => p.FundPayment));
            Result.MaxMonthReturn = Result.Payments.Max(p => p.TotalPayment);
            Result.MinMonthReturn = Result.Payments.Min(p => p.TotalPayment);
            Result.Ratio = Utils.Round2(Result.TotalReturn / Result.Payments.Sum(p => p.FundPayment));
            var payment = Result.Payments.Last();
            Result.RemainingFund = Utils.Round2(payment.TotalFund - payment.FundPayment);
        }

        public double Years
        {
            get
            {
                return Utils.Round2(Period / 12.0);
            }
        }
    }
}