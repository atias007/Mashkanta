﻿using Mashkanta.Forecast;

namespace Mashkanta.Courses
{
    public class Variable
    {
        public static void Calc(Course request)
        {
            var result = new CourseResult();
            var fund = request.Amount;
            var forecast = ForecastUtil.Get(ForecastType.Variable);

            var periods = request.StopAtPeriod.HasValue ? request.StopAtPeriod : request.Period;
            var zeroInterest = forecast.GetValue();

            for (int i = 0; i < periods; i++)
            {
                var baseInterest =
                    request.WithForecast ?
                    forecast.GetValue(request.StartMonth + i) - zeroInterest :
                    0;

                var rate = (baseInterest + request.Interest) / 12;
                var pmt = -Utils.Pmt(rate / 100, request.Period - i, fund);
                var interest = fund * rate / 100;

                var payment = new Payment
                {
                    Period = i + 1,
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
        }
    }
}