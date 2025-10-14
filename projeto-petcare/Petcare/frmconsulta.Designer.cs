namespace Petcare
{
    partial class frmconsulta
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
            this.lblid = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.mskhora = new System.Windows.Forms.MaskedTextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(37, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 22);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(37, 107);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(52, 22);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "Data";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(37, 161);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(53, 22);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "Hora";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 22);
            this.txtID.TabIndex = 3;
            // 
            // mskhora
            // 
            this.mskhora.Location = new System.Drawing.Point(125, 161);
            this.mskhora.Mask = "00:00";
            this.mskhora.Name = "mskhora";
            this.mskhora.Size = new System.Drawing.Size(177, 22);
            this.mskhora.TabIndex = 5;
            this.mskhora.ValidatingType = typeof(System.DateTime);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(41, 454);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(222, 67);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Silver;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(293, 454);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(222, 67);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(119, 107);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(183, 22);
            this.dtpData.TabIndex = 8;
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 681);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.mskhora);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox mskhora;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}