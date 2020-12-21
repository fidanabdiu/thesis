namespace AgjensioniTuristik.FormatBaze
{
    partial class DialoguBaze
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
            this.pnlPaneli = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.strStatusi = new System.Windows.Forms.StatusStrip();
            this.lblMesazhi = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.strStatusi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaneli
            // 
            this.pnlPaneli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPaneli.Controls.Add(this.pictureBox1);
            this.pnlPaneli.Controls.Add(this.lblPershkrimi);
            this.pnlPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaneli.Location = new System.Drawing.Point(0, 0);
            this.pnlPaneli.Name = "pnlPaneli";
            this.pnlPaneli.Size = new System.Drawing.Size(437, 58);
            this.pnlPaneli.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgjensioniTuristik.Properties.Resources.Dialog48x48;
            this.pictureBox1.Location = new System.Drawing.Point(376, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimi.Location = new System.Drawing.Point(15, 22);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(66, 15);
            this.lblPershkrimi.TabIndex = 0;
            this.lblPershkrimi.Text = "Përshkrimi";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Image = global::AgjensioniTuristik.Properties.Resources.Ok24x24;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(244, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Ekzekuto";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnDil
            // 
            this.btnDil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDil.Image = global::AgjensioniTuristik.Properties.Resources.Dil24x24;
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(338, 259);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(87, 36);
            this.btnDil.TabIndex = 4;
            this.btnDil.Text = "Dil";
            this.btnDil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDil.UseVisualStyleBackColor = true;
            // 
            // strStatusi
            // 
            this.strStatusi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMesazhi});
            this.strStatusi.Location = new System.Drawing.Point(0, 313);
            this.strStatusi.Name = "strStatusi";
            this.strStatusi.Size = new System.Drawing.Size(437, 22);
            this.strStatusi.TabIndex = 6;
            this.strStatusi.Text = "statusStrip1";
            // 
            // lblMesazhi
            // 
            this.lblMesazhi.ForeColor = System.Drawing.Color.Red;
            this.lblMesazhi.Name = "lblMesazhi";
            this.lblMesazhi.Size = new System.Drawing.Size(0, 17);
            // 
            // DialoguBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 335);
            this.Controls.Add(this.strStatusi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.pnlPaneli);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialoguBaze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialoguBaze";
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.strStatusi.ResumeLayout(false);
            this.strStatusi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlPaneli;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label lblPershkrimi;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnDil;
        protected System.Windows.Forms.StatusStrip strStatusi;
        protected System.Windows.Forms.ToolStripStatusLabel lblMesazhi;
    }
}