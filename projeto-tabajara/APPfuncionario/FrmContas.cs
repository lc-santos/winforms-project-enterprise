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
    public partial class FrmContas : Form
    {
        public FrmContas()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal abrir = new FrmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void FrmContas_Load(object sender, EventArgs e)
        {

        }
    }
}
