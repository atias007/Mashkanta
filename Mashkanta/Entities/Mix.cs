using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Entities
{
    public class Mix
    {
        public Mix()
        {
            Courses = new List<Course>();
            TotalPayments = new List<Payment>();
        }

        public double TotalLoan { get; set; }

        public List<Course> Courses { get; private set; }

        public List<Payment> TotalPayments { get; private set; }

        public double Ratio
        {
            get
            {
                return Utils.Round2(Courses.Sum(c => c.Result.TotalReturn) / TotalLoan);
            }
        }

        public double MaxMonthReturn
        {
            get
            {
                return Utils.Round2(TotalPayments.Max(p => p.TotalPayment));
            }
        }

        public double MinMonthReturn
        {
            get
            {
                return Utils.Round2(TotalPayments.First().TotalPayment);
            }
        }

        public double TotalReturn
        {
            get
            {
                return Utils.Round2(Courses.Sum(p => p.Result.TotalReturn));
            }
        }

        public double TotalRemainingFund
        {
            get
            {
                return Utils.Round2(Courses.Sum(p => p.Result.RemainingFund));
            }
        }

        public double TotalInterestAndPriceIndex
        {
            get
            {
                var result = Utils.Round2(Courses.Sum(p => p.Result.TotalInterestAndPriceIndex));
                return result;
            }
        }

        public void Calc()
        {
            foreach (var item in Courses)
            {
                item.Calc();
                item.LoanPercentage = Utils.Round2(item.Amount / TotalLoan);
            }

            SetTotalPayments();
        }

        public void Recycle(Course source, RecycleCourse recycleCourse)
        {
            source.StopAtPeriod = recycleCourse.FromMonth - 1;
            Calc();

            var temp = new Course();
            temp.Type = source.Type;
            temp.Amount = source.Result.RemainingFund;
            temp.StartMonth = source.Result.Payments.Count + 1;
            temp.Period = recycleCourse.Period;
            temp.InterestGap = recycleCourse.InterestGap;
            temp.Calc();

            source.Result.Payments.AddRange(temp.Result.Payments);
            SetTotalPayments();
        }

        private void SetTotalPayments()
        {
            var maxPayments = Courses.Max(c => c.StopAtPeriod.HasValue ? c.StopAtPeriod : c.Period);
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

        private List<Payment> GetPayments(int period)
        {
            var result = new List<Payment>();

            foreach (var c in Courses)
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