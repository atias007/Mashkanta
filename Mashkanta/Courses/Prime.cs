using Mashkanta.Forecast;

namespace Mashkanta.Courses
{
    public class Prime
    {
        public static void Calc(Course request)
        {
            var result = new CourseResult();
            var fund = request.Amount;
            var forecast = ForecastUtil.Get(ForecastType.Prime);
            request.StopAtPeriod = request.Recycle == null ? (int?)null : request.Recycle.FromMonth - 1;

            var periods = request.StopAtPeriod.HasValue ? request.StopAtPeriod : request.Period;
            var boiInterest = forecast.GetValue();

            for (int i = 0; i < periods; i++)
            {
                var baseInterest = request.WithForecast ?
                    forecast.GetValue(request.StartMonth + i) - boiInterest :
                    0;

                var rate = (baseInterest + request.Interest) / 12;
                var pmt = -Utils.Pmt(rate / 100, request.Period - i, fund);
                var interest = fund * rate / 100;

                var payment = new Payment
                {
                    Period = i + request.StartMonth,
                    InterestMonthPercentage = Utils.Round4(rate),
                    InterestYearPercentage = Utils.Round4(rate * 12),
                    TotalPayment = Utils.Round2(pmt),
                    FundPayment = Utils.Round2(pmt - interest),
                    InterestPayment = Utils.Round2(interest),
                    TotalFund = Utils.Round2(fund),
                };

                payment.TotalFundWithPriceIndex = payment.TotalFund;
                payment.FundPaymentWithPriceIndex = payment.FundPayment;

                result.Payments.Add(payment);
                fund = fund - payment.FundPayment;
            }

            request.Result = result;

            if (request.Recycle != null)
            {
                Recycle(request);
            }
        }

        private static void Recycle(Course source)
        {
            source.Result.SetVariables();
            var temp = new Course();
            temp.Type = source.Type;
            temp.Amount = source.Result.RemainingFund;
            temp.StartMonth = source.Result.Payments.Count + 1;
            temp.Period = source.Recycle.Period;
            temp.Interest = source.Interest;
            temp.WithForecast = source.WithForecast;
            temp.Calc();
            //
            source.Result.Payments.AddRange(temp.Result.Payments);
        }
    }
}