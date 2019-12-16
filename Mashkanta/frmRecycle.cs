using Mashkanta.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mashkanta
{
    public partial class frmRecycle : Form
    {
        private Course _course;

        public RecycleCourse Result { get; set; }

        public frmRecycle(Course course)
        {
            InitializeComponent();

            _course = course;
            txtCourse.Text = course.Type.ToString();
            txtPayments.Text = course.Result == null ? "לא חושב" : course.Result.Payments.Count().ToString();
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (_course.Result == null)
            {
                txtFund.Text = "לא ניתן לחשב";
                return;
            }

            var month = 0;
            if (int.TryParse(txtMonth.Text.Trim(), out month))
            {
                var payment = _course.Result.Payments.FirstOrDefault(p => p.Period == month - 1);
                if (payment == null)
                {
                    txtFund.Text = "שגיאה בשדה התחל בחודש";
                }
                else
                {
                    txtFund.Text = (payment.TotalFundWithPriceIndex - payment.FundPaymentWithPriceIndex).ToString("N2");
                }
            }
            else
            {
                txtFund.Text = "שגיאה בשדה התחל בחודש";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var rc = new RecycleCourse { FromMonth = int.Parse(txtMonth.Text), Period = int.Parse(txtPeriod.Text) };
            _course.Recycle = rc;
        }
    }
}