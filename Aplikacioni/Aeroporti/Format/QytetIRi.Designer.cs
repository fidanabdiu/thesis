namespace Aeroporti.Format
{
    partial class QytetIRi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.cboShtetet = new System.Windows.Forms.ComboBox();
            this.btnShtoShtet = new System.Windows.Forms.Button();
            this.pnlPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(139, 15);
            this.lblPershkrimi.Text = "Jipni të dhënat e qytetit";
            // 
            // btnDil
            // 
            this.btnDil.Location = new System.Drawing.Point(340, 223);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(246, 223);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shteti:";
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(134, 125);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(196, 23);
            this.txtEmri.TabIndex = 6;
            // 
            // cboShtetet
            // 
            this.cboShtetet.FormattingEnabled = true;
            this.cboShtetet.Location = new System.Drawing.Point(134, 158);
            this.cboShtetet.Name = "cboShtetet";
            this.cboShtetet.Size = new System.Drawing.Size(196, 23);
            this.cboShtetet.TabIndex = 7;
            // 
            // btnShtoShtet
            // 
            this.btnShtoShtet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoShtet.Image = global::Aeroporti.Properties.Resources.Shto24x24;
            this.btnShtoShtet.Location = new System.Drawing.Point(336, 153);
            this.btnShtoShtet.Name = "btnShtoShtet";
            this.btnShtoShtet.Size = new System.Drawing.Size(32, 33);
            this.btnShtoShtet.TabIndex = 8;
            this.btnShtoShtet.UseVisualStyleBackColor = true;
            this.btnShtoShtet.Click += new System.EventHandler(this.btnShtoShtet_Click);
            // 
            // QytetIRi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.cboShtetet);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.btnShtoShtet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "QytetIRi";
            this.Text = "Qyteti";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnDil, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnShtoShtet, 0);
            this.Controls.SetChildIndex(this.txtEmri, 0);
            this.Controls.SetChildIndex(this.cboShtetet, 0);
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.ComboBox cboShtetet;
        private System.Windows.Forms.Button btnShtoShtet;
    }
}
