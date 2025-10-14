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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            int senha = 123;

            usuario= txtusuario.Text.Trim();
            senha= int.Parse(txtsenha.Text.Trim());

            if( usuario=="admin" & senha == 123)
            {
                frmMenuPrincipal abrir= new frmMenuPrincipal();
                abrir.Show();
                
            }
            else
            {
                MessageBox.Show(" Usuario e Senha Incorretos");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtsenha.Clear();
        }
    }
}
