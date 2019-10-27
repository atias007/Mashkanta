using Mashkanta.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mashkanta
{
    public partial class frmCompare : Form
    {
        private List<Mix> _dataSource;

        public frmCompare(List<Mix> dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource.OrderBy(m => m.Ratio).ToList();

            grdCompare.DataSource = _dataSource;

            foreach (DataGridViewColumn col in grdCompare.Columns)
            {
                if (col.MinimumWidth < 100)
                {
                    col.Visible = false;
                }
            }
        }

        private void frmCompare_Load(object sender, System.EventArgs e)
        {
        }

        private void panel1_SizeChanged(object sender, System.EventArgs e)
        {
        }

        private void grdCompare_SelectionChanged(object sender, System.EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }

            if (grdCompare.SelectedRows.Count == 0) return;

            var mix = grdCompare.SelectedRows[0].DataBoundItem as Mix;

            var f = new Form1(mix);
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void grdCompare_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
        }
    }
}