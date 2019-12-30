using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Entities
{
    public class SummeryList : List<Summery>
    {
        public string ToHtml()
        {
            var report = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.Table2.html");
            var rows = string.Join("\r\n", this.Select(t => t.ToHtml()));
            var result = report.Replace("@@Table2Rows@@", rows);
            return result;
        }
    }
}