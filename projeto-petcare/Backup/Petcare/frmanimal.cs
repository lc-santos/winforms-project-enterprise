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
    public partial class frmanimal : Form
    {
        public frmanimal()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtpeso.Clear();
            txtNome.Clear();
            txtcor.Clear();
            txtdetalhe.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir= new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
