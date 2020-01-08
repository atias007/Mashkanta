using Mashkanta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Charts
{
    public class PaymentDoughnut
    {
        private readonly Mix _mix;
        private readonly string _name;

        public PaymentDoughnut(Mix mix, string name)
        {
            _mix = mix;
            _name = name;
        }

        public string ToHtml()
        {
            var row = EmbadedResources.GetEmbeddedResource("Mashkanta.Reports.PaymentDoughnut.html");
            var labels = new List<string> { $"ריבית ({_mix.TotalInterest:N0} ₪)", $"הצמדה ({_mix.TotalPriceIndex:N0} ₪)", $"קרן ({_mix.TotalLoan:N0}) ₪" };
            var data = new List<int> { Convert.ToInt32(_mix.TotalInterest), Convert.ToInt32(_mix.TotalPriceIndex), Convert.ToInt32(_mix.TotalLoan) };
            var color = new List<string> { "rgba(255,99,132,1)", "rgba(255, 206, 86, 1)", "rgba(54, 162, 235, 1)" };

            row = row.Replace("@@NAME@@", _name);
            row = row.Replace("@@LABELS@@", string.Join(",", labels.Select(l => $"'{l}'")));
            row = row.Replace("@@DATA@@", string.Join(",", data));
            row = row.Replace("@@COLORS@@", string.Join(",", color.Select(l => $"'{l}'")));

            return row;
        }
    }
}