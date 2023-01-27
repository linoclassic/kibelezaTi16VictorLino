using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kibelezaTi16VictorLino
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            pnlRelatorio.Location = new Point(this.Width / 2 - pnlRelatorio.Width / 2, this.Height / 2 - pnlRelatorio.Height / 2);
        }
    }
}
