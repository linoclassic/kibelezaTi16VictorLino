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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            pnlCadServico.Location = new Point(this.Width / 2 - pnlCadServico.Width / 2, this.Height / 2 - pnlCadServico.Height / 2);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

    
    }
}
