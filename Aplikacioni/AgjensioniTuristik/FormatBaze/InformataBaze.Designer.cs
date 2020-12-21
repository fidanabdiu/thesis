namespace AgjensioniTuristik.FormatBaze
{
    partial class InformataBaze
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
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.btnDil = new System.Windows.Forms.Button();
            this.pnlPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaneli
            // 
            this.pnlPaneli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPaneli.Controls.Add(this.lblPershkrimi);
            this.pnlPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaneli.Location = new System.Drawing.Point(0, 0);
            this.pnlPaneli.Name = "pnlPaneli";
            this.pnlPaneli.Size = new System.Drawing.Size(591, 58);
            this.pnlPaneli.TabIndex = 1;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimi.Location = new System.Drawing.Point(13, 21);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(66, 15);
            this.lblPershkrimi.TabIndex = 0;
            this.lblPershkrimi.Text = "Përshkrimi";
            // 
            // btnDil
            // 
            this.btnDil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDil.Image = global::AgjensioniTuristik.Properties.Resources.Dil24x241;
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(504, 391);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(75, 35);
            this.btnDil.TabIndex = 2;
            this.btnDil.Text = "Dil";
            this.btnDil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDil.UseVisualStyleBackColor = true;
            // 
            // InformataBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.btnDil);
            this.Controls.Add(this.pnlPaneli);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformataBaze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformataBaze";
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlPaneli;
        protected System.Windows.Forms.Label lblPershkrimi;
        protected System.Windows.Forms.Button btnDil;
    }
}