namespace Petcare
{
    partial class frmveterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmveterinario));
            this.lbldadospessoais = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskdatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcrm = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtIDveterinario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblcrm = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblidveterinario = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldadospessoais
            // 
            this.lbldadospessoais.AutoSize = true;
            this.lbldadospessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldadospessoais.Location = new System.Drawing.Point(24, 27);
            this.lbldadospessoais.Name = "lbldadospessoais";
            this.lbldadospessoais.Size = new System.Drawing.Size(154, 22);
            this.lbldadospessoais.TabIndex = 0;
            this.lbldadospessoais.Text = "Dados Pessoais";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mskdatanascimento);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.msktelefone);
            this.panel1.Controls.Add(this.txtcrm);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtIDveterinario);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lblcrm);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblidveterinario);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 203);
            this.panel1.TabIndex = 1;
            // 
            // mskdatanascimento
            // 
            this.mskdatanascimento.BeepOnError = true;
            this.mskdatanascimento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mskdatanascimento.Location = new System.Drawing.Point(193, 166);
            this.mskdatanascimento.Mask = "00/00/0000";
            this.mskdatanascimento.Name = "mskdatanascimento";
            this.mskdatanascimento.Size = new System.Drawing.Size(226, 22);
            this.mskdatanascimento.TabIndex = 6;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 166);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(162, 22);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // msktelefone
            // 
            this.msktelefone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.msktelefone.Location = new System.Drawing.Point(193, 126);
            this.msktelefone.Mask = "00-00000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(226, 22);
            this.msktelefone.TabIndex = 4;
            // 
            // txtcrm
            // 
            this.txtcrm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcrm.Location = new System.Drawing.Point(193, 86);
            this.txtcrm.Name = "txtcrm";
            this.txtcrm.Size = new System.Drawing.Size(225, 22);
            this.txtcrm.TabIndex = 3;
            // 
            // txtnome
            // 
            this.txtnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtnome.Location = new System.Drawing.Point(193, 47);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(225, 22);
            this.txtnome.TabIndex = 2;
            // 
            // txtIDveterinario
            // 
            this.txtIDveterinario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtIDveterinario.Location = new System.Drawing.Point(194, 9);
            this.txtIDveterinario.Name = "txtIDveterinario";
            this.txtIDveterinario.Size = new System.Drawing.Size(225, 22);
            this.txtIDveterinario.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(12, 126);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 22);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblcrm
            // 
            this.lblcrm.AutoSize = true;
            this.lblcrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrm.Location = new System.Drawing.Point(12, 84);
            this.lblcrm.Name = "lblcrm";
            this.lblcrm.Size = new System.Drawing.Size(53, 22);
            this.lblcrm.TabIndex = 3;
            this.lblcrm.Text = "CRM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 22);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblidveterinario
            // 
            this.lblidveterinario.AutoSize = true;
            this.lblidveterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidveterinario.Location = new System.Drawing.Point(12, 9);
            this.lblidveterinario.Name = "lblidveterinario";
            this.lblidveterinario.Size = new System.Drawing.Size(130, 22);
            this.lblidveterinario.TabIndex = 1;
            this.lblidveterinario.Text = "Id Veterinario";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(470, 458);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(186, 52);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(260, 458);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(186, 52);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(45, 458);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(186, 52);
            this.btncadastrar.TabIndex = 4;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmveterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldadospessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmveterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldadospessoais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.TextBox txtcrm;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtIDveterinario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblcrm;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblidveterinario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.MaskedTextBox mskdatanascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}