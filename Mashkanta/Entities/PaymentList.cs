using System.Collections.Generic;
using System.Linq;
using static Mashkanta.Course;

namespace Mashkanta.Entities
{
    public class PaymentList : List<Payment>
    {
        public string ToHtml(CourseType courseType)
        {
            var header = Payment.ToHtmlHeader(courseType);
            var tableList = this.Select(p => p.ToHtml(courseType)).ToList();
            var title = $"<div class=\"table_header2\">לוח סילוקין</div>";
            var style = courseType == CourseType.None ? " style=\"width:80%\"" : string.Empty;
            var tableHtml = $"{title}\r\n<div class=\"table\"{style}>{header}{string.Join(string.Empty, tableList)}</div>";
            return tableHtml;
        }
    }
}