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
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            mskhora .Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir= new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
