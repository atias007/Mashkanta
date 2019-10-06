using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace Mashkanta.Forecast
{
    public enum ForecastType
    {
        Prime,
        PriceIndex,
        VariablePriceIndex,
        Variable
    }

    public class ForecastUtil
    {
        public ForecastUtil()
        {
            Periods = new List<ForecastItem>();
        }

        public List<ForecastItem> Periods { get; private set; }

        public double GetValue(int month)
        {
            var year = Math.Floor((month - 1) / 12.0) + DateTime.Now.Year;
            var period = Periods.Where(p => p.Year == year).FirstOrDefault();
            return period.Interest;
        }

        public static ForecastUtil Get(ForecastType type)
        {
            var text = File.ReadAllText($@"Forecast\{type}Forecast.txt");
            var lines = text.Split('\n');
            var result = new ForecastUtil();
            foreach (var item in lines)
            {
                if (string.IsNullOrEmpty(item.Trim()) == false)
                {
                    var values = item.Split(',');
                    result.Periods.Add(new ForecastItem { Year = int.Parse(values[0]), Interest = double.Parse(values[1]) });
                }
            }

            return result;
        }
    }
}