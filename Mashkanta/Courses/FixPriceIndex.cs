﻿using Mashkanta.Forecast;
using System;

namespace Mashkanta.Courses
{
    public class FixPriceIndex
    {
        public static void Calc(Course request)
        {
            var result = new CourseResult();
            var fund = request.Amount;
            var periods = request.StopAtPeriod.HasValue ? request.StopAtPeriod : request.Period;
            var rate = (request.InterestGap) / 12;
            var pmt = -Utils.Pmt(rate / 100, request.Period, fund);
            var forecast = ForecastUtil.Get(ForecastType.PriceIndex);

            for (int i = 0; i < periods; i++)
            {
                var priceIndex = forecast.GetValue(request.StartMonth + i) / 12;
                var interestPayment = fund * rate / 100;
                var fundPayment = pmt - interestPayment;
                var fundPaymentWithPriceIndex = fundPayment * Math.Pow(1 + (priceIndex / 100), i + 1);

                var payment = new Payment
                {
                    Period = i + 1,
                    InterestMonthPercentage = Utils.Round4(rate),
                    InterestYearPercentage = Utils.Round4(request.InterestGap),
                    PriceIndex = Utils.Round4(priceIndex),
                    TotalFund = Utils.Round2(fund),
                    TotalFundWithPriceIndex = Utils.Round2(fund * (1 + (priceIndex / 100))),
                    InterestPayment = Utils.Round2(interestPayment),
                    FundPayment = Utils.Round2(fundPayment),
                    FundPaymentWithPriceIndex = Utils.Round2(fundPaymentWithPriceIndex),
                    TotalPayment = Utils.Round2(fundPaymentWithPriceIndex + interestPayment),
                };

                result.Payments.Add(payment);
                fund = fund - payment.FundPayment;
            }

            request.Result = result;
        }
    }
}