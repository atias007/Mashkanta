namespace Mashkanta.Entities
{
    public class Summery
    {
        public int Year { get; set; }

        public double TotalPayment { get; set; }

        public double AveragePayment { get; set; }

        public string ToHtml()
        {
            var template = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.Table2Row.html");
            var result = template.Replace("@@Year@@", Year.ToString());
            result = result.Replace("@@TotalPayment@@", TotalPayment.ToString("N0"));
            result = result.Replace("@@AveragePayment@@", AveragePayment.ToString("N0"));
            return result;
        }
    }
}