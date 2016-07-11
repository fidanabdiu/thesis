namespace Aeroporti.Format
{
    partial class TipIRi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipi = new System.Windows.Forms.TextBox();
            this.pnlPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(128, 15);
            this.lblPershkrimi.Text = "Jipni tipin e aeroplanit";
            // 
            // btnDil
            // 
            this.btnDil.Location = new System.Drawing.Point(340, 232);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(246, 232);
            this.btnOK.TabIndex = 1;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipi:";
            // 
            // txtTipi
            // 
            this.txtTipi.Location = new System.Drawing.Point(134, 137);
            this.txtTipi.Name = "txtTipi";
            this.txtTipi.Size = new System.Drawing.Size(206, 23);
            this.txtTipi.TabIndex = 0;
            // 
            // TipIRi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 308);
            this.Controls.Add(this.txtTipi);
            this.Controls.Add(this.label1);
            this.Name = "TipIRi";
            this.Text = "Tipi i aeroplanit";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnDil, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtTipi, 0);
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipi;
    }
}