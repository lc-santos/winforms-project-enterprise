namespace Petcare
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.lblDadosProduto = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblfabricante = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDadosProduto
            // 
            this.lblDadosProduto.AutoSize = true;
            this.lblDadosProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosProduto.Location = new System.Drawing.Point(49, 62);
            this.lblDadosProduto.Name = "lblDadosProduto";
            this.lblDadosProduto.Size = new System.Drawing.Size(155, 22);
            this.lblDadosProduto.TabIndex = 0;
            this.lblDadosProduto.Text = "Dados do Produto";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(14, 43);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(64, 25);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(14, 10);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(75, 25);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Código";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(14, 76);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(58, 25);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "Valor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtfabricante);
            this.panel1.Controls.Add(this.txtvalor);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.lblfabricante);
            this.panel1.Controls.Add(this.lblcodigo);
            this.panel1.Controls.Add(this.lblvalor);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(24, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 184);
            this.panel1.TabIndex = 4;
            // 
            // txtfabricante
            // 
            this.txtfabricante.Location = new System.Drawing.Point(148, 116);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(130, 22);
            this.txtfabricante.TabIndex = 4;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(148, 78);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(130, 22);
            this.txtvalor.TabIndex = 3;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(148, 45);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(130, 22);
            this.txtnome.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(148, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(130, 22);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblfabricante
            // 
            this.lblfabricante.AutoSize = true;
            this.lblfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfabricante.Location = new System.Drawing.Point(14, 114);
            this.lblfabricante.Name = "lblfabricante";
            this.lblfabricante.Size = new System.Drawing.Size(104, 25);
            this.lblfabricante.TabIndex = 4;
            this.lblfabricante.Text = "Fabricante";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(64, 426);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(226, 54);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(348, 426);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(226, 54);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(616, 426);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(226, 54);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDadosProduto);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosProduto;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblfabricante;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}