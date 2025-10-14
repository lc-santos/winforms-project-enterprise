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
            this.lblcliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblestadoocivil = new System.Windows.Forms.Label();
            this.txtestadocivil = new System.Windows.Forms.TextBox();
            this.mskrg = new System.Windows.Forms.MaskedTextBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(27, 19);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(164, 22);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Dados do Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbfeminino);
            this.panel1.Controls.Add(this.rdbmasculino);
            this.panel1.Controls.Add(this.lblgenero);
            this.panel1.Controls.Add(this.mskrg);
            this.panel1.Controls.Add(this.lblestadoocivil);
            this.panel1.Controls.Add(this.txtestadocivil);
            this.panel1.Controls.Add(this.lblrg);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 157);
            this.panel1.TabIndex = 1;
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
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(732, 484);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(157, 51);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(87, 18);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(149, 22);
            this.txtnome.TabIndex = 1;
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
            // lblestadoocivil
            // 
            this.lblestadoocivil.AutoSize = true;
            this.lblestadoocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoocivil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblestadoocivil.Location = new System.Drawing.Point(303, 16);
            this.lblestadoocivil.Name = "lblestadoocivil";
            this.lblestadoocivil.Size = new System.Drawing.Size(117, 22);
            this.lblestadoocivil.TabIndex = 5;
            this.lblestadoocivil.Text = "Estado Civil";
            // 
            // txtestadocivil
            // 
            this.txtestadocivil.Location = new System.Drawing.Point(439, 16);
            this.txtestadocivil.Name = "txtestadocivil";
            this.txtestadocivil.Size = new System.Drawing.Size(149, 22);
            this.txtestadocivil.TabIndex = 2;
            // 
            // mskrg
            // 
            this.mskrg.Location = new System.Drawing.Point(87, 53);
            this.mskrg.Mask = "00.000.000-0";
            this.mskrg.Name = "mskrg";
            this.mskrg.Size = new System.Drawing.Size(149, 22);
            this.mskrg.TabIndex = 3;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblgenero.Location = new System.Drawing.Point(303, 55);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(76, 22);
            this.lblgenero.TabIndex = 7;
            this.lblgenero.Text = "Genero";
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmasculino.Location = new System.Drawing.Point(439, 57);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(98, 20);
            this.rdbmasculino.TabIndex = 4;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfeminino.Location = new System.Drawing.Point(600, 55);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(91, 20);
            this.rdbfeminino.TabIndex = 5;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.MaskedTextBox mskrg;
        private System.Windows.Forms.TextBox txtestadocivil;
    }
}