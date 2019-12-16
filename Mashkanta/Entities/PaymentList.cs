using System.Collections.Generic;
using System.Linq;

namespace Mashkanta.Entities
{
    public class PaymentList : List<Payment>
    {
        public string ToHtml()
        {
            var header = Payment.ToHtmlHeader();
            var tableList = this.Select(p => p.ToHtml()).ToList();
            var tableHtml = $"<div class=\"table\">{header}{string.Join(string.Empty, tableList)}</div>";
            return tableHtml;
        }
    }
}