namespace Petcare
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.lblcliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbgenero = new System.Windows.Forms.GroupBox();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.cbbestadocivil = new System.Windows.Forms.ComboBox();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.lblestadoocivil = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtcomplento = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.cbbuf = new System.Windows.Forms.ComboBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.cbbestado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.lbllogradouro = new System.Windows.Forms.Label();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbgenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(27, 18);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(164, 22);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Dados do Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.gpbgenero);
            this.panel1.Controls.Add(this.cbbestadocivil);
            this.panel1.Controls.Add(this.mskrg);
            this.panel1.Controls.Add(this.lblestadoocivil);
            this.panel1.Controls.Add(this.lblrg);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 138);
            this.panel1.TabIndex = 1;
            // 
            // gpbgenero
            // 
            this.gpbgenero.Controls.Add(this.rdbfeminino);
            this.gpbgenero.Controls.Add(this.rdbmasculino);
            this.gpbgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbgenero.Location = new System.Drawing.Point(469, 53);
            this.gpbgenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbgenero.Name = "gpbgenero";
            this.gpbgenero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbgenero.Size = new System.Drawing.Size(273, 63);
            this.gpbgenero.TabIndex = 17;
            this.gpbgenero.TabStop = false;
            this.gpbgenero.Text = "Genero";
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfeminino.Location = new System.Drawing.Point(149, 26);
            this.rdbfeminino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(90, 22);
            this.rdbfeminino.TabIndex = 1;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = true;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmasculino.Location = new System.Drawing.Point(5, 26);
            this.rdbmasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(97, 22);
            this.rdbmasculino.TabIndex = 0;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // cbbestadocivil
            // 
            this.cbbestadocivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbestadocivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbestadocivil.FormattingEnabled = true;
            this.cbbestadocivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Divorciado"});
            this.cbbestadocivil.Location = new System.Drawing.Point(491, 16);
            this.cbbestadocivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbestadocivil.Name = "cbbestadocivil";
            this.cbbestadocivil.Size = new System.Drawing.Size(252, 24);
            this.cbbestadocivil.TabIndex = 8;
            // 
            // mskrg
            // 
            this.mskrg.BeepOnError = true;
            this.mskrg.Location = new System.Drawing.Point(104, 53);
            this.mskrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskrg.Mask = "00.000.000-0";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(192, 22);
            this.mskrg.TabIndex = 3;
            // 
            // lblestadoocivil
            // 
            this.lblestadoocivil.AutoSize = true;
            this.lblestadoocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoocivil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblestadoocivil.Location = new System.Drawing.Point(357, 18);
            this.lblestadoocivil.Name = "lblestadoocivil";
            this.lblestadoocivil.Size = new System.Drawing.Size(117, 22);
            this.lblestadoocivil.TabIndex = 5;
            this.lblestadoocivil.Text = "Estado Civil";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblrg.Location = new System.Drawing.Point(3, 55);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(39, 22);
            this.lblrg.TabIndex = 3;
            this.lblrg.Text = "RG";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(104, 20);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(192, 22);
            this.txtnome.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblnome.Location = new System.Drawing.Point(3, 18);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(61, 22);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(649, 487);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(157, 50);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(362, 487);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(157, 50);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.Transparent;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(72, 487);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(157, 50);
            this.btnnovo.TabIndex = 4;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(this.lblbairro);
            this.groupBox1.Controls.Add(this.txtcomplento);
            this.groupBox1.Controls.Add(this.lblcomplemento);
            this.groupBox1.Controls.Add(this.cbbuf);
            this.groupBox1.Controls.Add(this.lbluf);
            this.groupBox1.Controls.Add(this.cbbestado);
            this.groupBox1.Controls.Add(this.lblestado);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(this.lblcidade);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Controls.Add(this.txtlogradouro);
            this.groupBox1.Controls.Add(this.lbllogradouro);
            this.groupBox1.Controls.Add(this.mskcep);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Location = new System.Drawing.Point(31, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 218);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(394, 140);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(154, 22);
            this.txtbairro.TabIndex = 15;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(311, 142);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(55, 20);
            this.lblbairro.TabIndex = 14;
            this.lblbairro.Text = "Bairro";
            // 
            // txtcomplento
            // 
            this.txtcomplento.Location = new System.Drawing.Point(142, 142);
            this.txtcomplento.Name = "txtcomplento";
            this.txtcomplento.Size = new System.Drawing.Size(142, 22);
            this.txtcomplento.TabIndex = 13;
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.Location = new System.Drawing.Point(6, 144);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(112, 20);
            this.lblcomplemento.TabIndex = 12;
            this.lblcomplemento.Text = "Complemento";
            // 
            // cbbuf
            // 
            this.cbbuf.FormattingEnabled = true;
            this.cbbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbuf.Location = new System.Drawing.Point(633, 81);
            this.cbbuf.Name = "cbbuf";
            this.cbbuf.Size = new System.Drawing.Size(109, 24);
            this.cbbuf.TabIndex = 11;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluf.Location = new System.Drawing.Point(570, 85);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(31, 20);
            this.lbluf.TabIndex = 10;
            this.lbluf.Text = "UF";
            // 
            // cbbestado
            // 
            this.cbbestado.FormattingEnabled = true;
            this.cbbestado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espirito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso do Sul",
            "Mato Grosso",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbbestado.Location = new System.Drawing.Point(394, 85);
            this.cbbestado.Name = "cbbestado";
            this.cbbestado.Size = new System.Drawing.Size(154, 24);
            this.cbbestado.TabIndex = 9;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(311, 89);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(61, 20);
            this.lblestado.TabIndex = 8;
            this.lblestado.Text = "Estado";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(89, 89);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(195, 22);
            this.txtcidade.TabIndex = 7;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(6, 91);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(61, 20);
            this.lblcidade.TabIndex = 6;
            this.lblcidade.Text = "Cidade";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(643, 27);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 22);
            this.txtnumero.TabIndex = 5;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(563, 28);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(68, 20);
            this.lblnumero.TabIndex = 4;
            this.lblnumero.Text = "Numero";
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(290, 26);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(252, 22);
            this.txtlogradouro.TabIndex = 3;
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogradouro.Location = new System.Drawing.Point(190, 29);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(94, 20);
            this.lbllogradouro.TabIndex = 2;
            this.lbllogradouro.Text = "Logradouro";
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(60, 26);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(100, 22);
            this.mskcep.TabIndex = 1;
            this.mskcep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskcep_KeyDown);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(6, 32);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(43, 20);
            this.lblcep.TabIndex = 0;
            this.lblcep.Text = "CEP";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbgenero.ResumeLayout(false);
            this.gpbgenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblestadoocivil;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.ComboBox cbbestadocivil;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbgenero;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtlogradouro;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtcomplento;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.ComboBox cbbuf;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.ComboBox cbbestado;
    }
}