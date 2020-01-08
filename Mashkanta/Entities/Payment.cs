using System;
using System.Collections.Generic;
using static Mashkanta.Course;

namespace Mashkanta
{
    public class Payment
    {
        private static readonly List<CourseType> PriceIndexCourses = new List<CourseType> { CourseType.FixPriceIndex, CourseType.VariablePriceIndex };

        public int Period { get; set; }

        public double InterestMonthPercentage { get; set; }

        public double InterestYearPercentage { get; set; }

        public double InterestPayment { get; set; }

        public double PriceIndexPayment { get; set; }

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

        public int Year
        {
            get
            {
                return PeriodDate.Year;
            }
        }

        public override string ToString()
        {
            return $"I:{InterestPayment:C2}, F:{FundPayment:C2}, TF:{TotalFund:C2}";
        }

        public string ToHtml(CourseType courseType)
        {
            const string cellTemplate = "<div class=\"cell\">{0}</div>\r\n";
            var cellsContent = string.Format(cellTemplate, Period);
            cellsContent += string.Format(cellTemplate, PeriodDate.ToString("MM/yyyy"));
            if (courseType != CourseType.None)
            {
                cellsContent += string.Format(cellTemplate, InterestMonthPercentage.ToString("N4") + "%");
                cellsContent += string.Format(cellTemplate, InterestYearPercentage.ToString("N2") + "%");
            }

            cellsContent += string.Format(cellTemplate, InterestPayment.ToString("N0"));
            cellsContent += string.Format(cellTemplate, FundPayment.ToString("N0"));
            if (PriceIndexCourses.Contains(courseType))
            {
                cellsContent += string.Format(cellTemplate, FundPaymentWithPriceIndex.ToString("N0"));
            }

            cellsContent += string.Format(cellTemplate, TotalFund.ToString("N0"));
            if (PriceIndexCourses.Contains(courseType))
            {
                cellsContent += string.Format(cellTemplate, TotalFundWithPriceIndex.ToString("N0"));
            }

            var paymentTemplate = cellTemplate.Replace("class=\"cell\"", "class=\"cell payment_green\"");
            cellsContent += string.Format(paymentTemplate, "₪" + TotalPayment.ToString("N0"));
            var result = $"<div class=\"row\">\r\n{cellsContent.Trim()}\r\n</div>\r\n";
            return result;
        }

        public static string ToHtmlHeader(CourseType courseType)
        {
            const string cellTemplate = "<div class=\"cell\">{0}</div>\r\n";

            var cellsContent = string.Format(cellTemplate, "תקופה");
            cellsContent += string.Format(cellTemplate, "חודש");
            if (courseType != CourseType.None)
            {
                cellsContent += string.Format(cellTemplate, "ריבית חודש");
                cellsContent += string.Format(cellTemplate, "ריבית שנה");
            }

            cellsContent += string.Format(cellTemplate, "ריבית");
            cellsContent += string.Format(cellTemplate, "קרן");
            if (PriceIndexCourses.Contains(courseType))
            {
                cellsContent += string.Format(cellTemplate, "קרן צמודה");
            }

            cellsContent += string.Format(cellTemplate, "יתרת קרן");
            if (PriceIndexCourses.Contains(courseType))
            {
                cellsContent += string.Format(cellTemplate, "יתרת קרן צמודה");
            }

            cellsContent += string.Format(cellTemplate, "תשלום חודשי");
            var result = $"<div class=\"row header green\">\r\n{cellsContent.Trim()}\r\n</div>\r\n";
            return result;
        }
    }
}