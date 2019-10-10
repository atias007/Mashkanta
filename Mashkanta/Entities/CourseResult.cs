using System.Collections.Generic;

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
    }
}