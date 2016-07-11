namespace AgjensioniTuristik.Format
{
    partial class Kerko
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
            this.txtFjalaKyce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(98, 15);
            this.lblPershkrimi.Text = "Jipeni fjalën kyçe";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(244, 199);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDil
            // 
            this.btnDil.Location = new System.Drawing.Point(338, 199);
            // 
            // txtFjalaKyce
            // 
            this.txtFjalaKyce.Location = new System.Drawing.Point(134, 125);
            this.txtFjalaKyce.Name = "txtFjalaKyce";
            this.txtFjalaKyce.Size = new System.Drawing.Size(236, 23);
            this.txtFjalaKyce.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fjala kyçe:";
            // 
            // Kerko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 273);
            this.Controls.Add(this.txtFjalaKyce);
            this.Controls.Add(this.label1);
            this.Name = "Kerko";
            this.Text = "Kërkimi";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnDil, 0);
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtFjalaKyce, 0);
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFjalaKyce;
        private System.Windows.Forms.Label label1;
    }
}