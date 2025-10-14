using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petcare
{
    public partial class frmveterinario : Form
    {
        public frmveterinario()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir= new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIDveterinario.Clear();
            txtnome.Clear();
            txtcrm.Clear();
            msktelefone.Clear();
            mskdatanascimento.Clear();
        }
    }
}
