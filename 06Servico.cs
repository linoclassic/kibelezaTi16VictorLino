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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            pnlServico.Location = new Point(this.Width / 2 - pnlServico.Width / 2, this.Height / 2 - pnlServico.Height / 2);
        }
    }
}
