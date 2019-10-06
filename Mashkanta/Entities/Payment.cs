using System;

namespace Mashkanta
{
    public class Payment
    {
        public int Period { get; set; }

        public double InterestMonthPercentage { get; set; }

        public double InterestYearPercentage { get; set; }

        public double InterestPayment { get; set; }

        public double FundPayment { get; set; }

        public double FundPaymentWithPriceIndex { get; set; }

        public double TotalFund { get; set; }

        public double TotalFundWithPriceIndex { get; set; }

        public double TotalPayment { get; set; }

        public double PriceIndex { get; set; }

        public DateTime PeriodDate
        {
            get
            {
                var value = DateTime.Now.AddMonths(Period - 1).AddDays(-DateTime.Now.Day + 1);
                return value;
            }
        }

        public override string ToString()
        {
            return $"I:{InterestPayment:C2}, F:{FundPayment:C2}, TF:{TotalFund:C2}";
        }
    }
}