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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanimal abrir= new frmanimal();
            abrir.Show();
            
        }

        private void btncadastrocliente_Click(object sender, EventArgs e)
        {
            frmCliente abrir= new frmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnveterinario_Click(object sender, EventArgs e)
        {
            frmveterinario abrir= new frmveterinario();
            abrir.Show();
            this.Hide();
            
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            frmconsulta abrir= new frmconsulta();
            abrir.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProduto abrir= new frmProduto();
            abrir.Show();
            this.Hide();
        }
    }
}
