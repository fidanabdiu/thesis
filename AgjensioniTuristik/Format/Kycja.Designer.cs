namespace AgjensioniTuristik.Format
{
    partial class Kycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kycja));
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.txtPseudonimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaneli
            // 
            this.pnlPaneli.Size = new System.Drawing.Size(419, 58);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 7);
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(118, 15);
            this.lblPershkrimi.Text = "Jipni të dhënat tuaja";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(226, 219);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDil
            // 
            this.btnDil.Location = new System.Drawing.Point(320, 219);
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Location = new System.Drawing.Point(143, 154);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(192, 23);
            this.txtFjalekalimi.TabIndex = 8;
            this.txtFjalekalimi.UseSystemPasswordChar = true;
            // 
            // txtPseudonimi
            // 
            this.txtPseudonimi.Location = new System.Drawing.Point(143, 116);
            this.txtPseudonimi.Name = "txtPseudonimi";
            this.txtPseudonimi.Size = new System.Drawing.Size(192, 23);
            this.txtPseudonimi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pseudonimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fjalëkalimi:";
            // 
            // Kycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 291);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.txtPseudonimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kycja";
            this.ShowIcon = true;
            this.Text = "Agjensioni turistik - Forma e kyçjes";
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.Controls.SetChildIndex(this.btnDil, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPseudonimi, 0);
            this.Controls.SetChildIndex(this.txtFjalekalimi, 0);
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.TextBox txtPseudonimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}