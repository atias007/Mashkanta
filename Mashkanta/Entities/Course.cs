using Mashkanta.Courses;
using Mashkanta.Entities;
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
                StopAtPeriod = _recycle.FromMonth - 1;
            }
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