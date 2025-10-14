namespace APPfuncionario
{
    partial class FrmMenuPrincipal
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.btncontas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(279, 72);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(205, 47);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.Location = new System.Drawing.Point(279, 151);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(205, 47);
            this.btnproduto.TabIndex = 1;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = true;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.Location = new System.Drawing.Point(279, 224);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(205, 47);
            this.btnfornecedor.TabIndex = 2;
            this.btnfornecedor.Text = "Fornecedor";
            this.btnfornecedor.UseVisualStyleBackColor = true;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // btncontas
            // 
            this.btncontas.Location = new System.Drawing.Point(279, 309);
            this.btncontas.Name = "btncontas";
            this.btncontas.Size = new System.Drawing.Size(205, 47);
            this.btncontas.TabIndex = 3;
            this.btncontas.Text = "Contas a pagar";
            this.btncontas.UseVisualStyleBackColor = true;
            this.btncontas.Click += new System.EventHandler(this.btncontas_Click);
            // 
            // FrmMenuPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncontas);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.btncliente);
            this.Name = "FrmMenuPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button btncontas;
    }
}