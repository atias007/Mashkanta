using Mashkanta.Courses;
using Mashkanta.Entities;

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

        public double Interest { get; set; }

        public int Period { get; set; }

        public int? StopAtPeriod { get; set; }

        public int StartMonth { get; set; }

        public double LoanPercentage { get; set; }

        public CourseResult Result { get; set; }

        public bool WithForecast { get; set; } = true;

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

            Result.SetVariables();
        }

        public bool Active { get; set; } = true;

        private RecycleCourse _recycle;

        public RecycleCourse Recycle
        {
            get { return _recycle; }

            set
            {
                _recycle = value;
                if (_recycle != null)
                {
                    StopAtPeriod = _recycle.FromMonth - 1;
                }
            }
        }

        public double Years
        {
            get
            {
                return Utils.Round2(Period / 12.0);
            }
        }

        public static string GetCourseTitle(CourseType courseType)
        {
            switch (courseType)
            {
                case CourseType.None:
                    return "(כל המסלולים)";

                case CourseType.Fix:
                    return "ריבית קבועה - לא צמודה";

                case CourseType.FixPriceIndex:
                    return "ריבית קבועה - צמודה למדד";

                case CourseType.Prime:
                    return "ריבית משתנה פריים";

                case CourseType.Variable:
                    return "ריבית משתנה (כל 5) - לא צמודה";

                case CourseType.VariablePriceIndex:
                    return "ריבית משתנה (כל 5) - צמודה למדד";

                default:
                    return string.Empty;
            }
        }

        public string ToHtml()
        {
            var row = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.TableCourseRows.html");
            row = row.Replace("@@Course@@", GetCourseTitle(Type));
            row = row.Replace("@@Amount@@", Amount.ToString("C0"));
            row = row.Replace("@@AmountPercentage@@", (LoanPercentage * 100).ToString("N0"));
            row = row.Replace("@@Interest@@", Interest.ToString("N2"));
            row = row.Replace("@@Period@@", $"{Period} חודשים ({Years} שנים)");
            row = row.Replace("@@Rcycle@@", Recycle == null ? "ללא" : "כן");
            return row;
        }
    }
}