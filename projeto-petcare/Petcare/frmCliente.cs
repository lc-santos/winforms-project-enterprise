using System;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;


namespace Petcare
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            desabilitarcampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            mskrg.Clear();
            cbbestadocivil.ResetText();
            rdbfeminino.ResetText();
            txtlogradouro.Clear();
            txtcidade.Clear();
            cbbestado.ResetText();
            cbbuf.Items.Clear();
            txtcomplento.Clear();
            txtbairro.Clear();


        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            habilitarcampos();
        }

        private void buscarcep(string cep)
        {
            var ViaCEPService = ViaCepService.Default();
            var endereco = ViaCEPService.ObterEndereco(cep);
            txtlogradouro.Text = endereco.Logradouro;
            txtcidade.Text = endereco.Localidade;
            cbbestado.Text = endereco.UF;
            cbbuf.Text = endereco.UF;
            txtcomplento.Text = endereco.Complemento;
            txtbairro.Text = endereco.Bairro;

        }
        private void desabilitarcampos()
        {
            txtnome.Enabled = false;
            mskrg.Enabled = false;
            cbbestadocivil.Enabled = false;
            rdbfeminino.Enabled = false;
            mskcep.Enabled = false;
            txtlogradouro.Enabled = false;
            txtnumero.Enabled = false;
            txtcidade.Enabled = false;
            cbbestado.Enabled = false;
            cbbuf.Enabled = false;
            txtcomplento.Enabled = false;
            txtbairro.Enabled = false;

        }
        private void habilitarcampos()
        {
            txtnome.Enabled = true;
            mskrg.Enabled = true;
            cbbestadocivil.Enabled = true;
            rdbfeminino.Enabled = true;
            mskcep.Enabled = true;
            txtlogradouro.Enabled = true;
            txtnumero.Enabled = true;
            txtcidade.Enabled = true;
            cbbestado.Enabled = true;
            cbbuf.Enabled = true;
            txtcomplento.Enabled = true;
            txtbairro.Enabled = true;
        }

        private void mskcep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarcep(mskcep.Text);
                txtnumero.Focus();
            }
        }
    }
}
