using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPfuncionario
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente abrir = new FrmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            frmproduto abrir = new frmproduto();
            abrir.Show();
            this.Hide();
        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor abrir = new FrmFornecedor();
            abrir.Show();
            this.Hide();
        }

        private void btncontas_Click(object sender, EventArgs e)
        {
            FrmContas abrir = new FrmContas();
            abrir.Show();
            this.Hide();
        }
    }
}
