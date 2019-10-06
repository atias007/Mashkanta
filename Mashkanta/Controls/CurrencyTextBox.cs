using System;
using System.Windows.Forms;

namespace Mashkanta.Controls
{
    public class CurrencyTextBox : TextBox
    {
        public string Format { get; set; }

        private double _value;

        public double Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                if (string.IsNullOrWhiteSpace(Format))
                {
                    base.Text = _value.ToString();
                }
                else
                {
                    base.Text = string.Format("{0:" + Format + "}", _value);
                }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            double value = 0;
            //var text = base.Text.Replace(',', string.Empty).Replace
            if (double.TryParse(base.Text, out value))
            {
                Value = value;
            }
            else
            {
                value = 0;
            }
        }
    }
}