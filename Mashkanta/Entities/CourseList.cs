using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Entities
{
    public class CourseList : List<Course>
    {
        public string ToHtml()
        {
            var table = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.TableCourse.html");
            var rows = this.Select(r => r.ToHtml()).ToList();
            var rowsHtml = string.Join("\r\n", rows);
            table = table.Replace("@@TableCourseRows@@", rowsHtml);
            return table;
        }
    }
}