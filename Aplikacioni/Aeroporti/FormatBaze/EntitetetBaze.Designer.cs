namespace Aeroporti.FormatBaze
{
    partial class EntitetetBaze
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
            this.strStatusi = new System.Windows.Forms.StatusStrip();
            this.lblMesazhi = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlPaneli.SuspendLayout();
            this.strStatusi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaneli
            // 
            this.pnlPaneli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPaneli.Controls.Add(this.lblPershkrimi);
            this.pnlPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaneli.Location = new System.Drawing.Point(0, 0);
            this.pnlPaneli.Name = "pnlPaneli";
            this.pnlPaneli.Size = new System.Drawing.Size(637, 58);
            this.pnlPaneli.TabIndex = 0;
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
            // strStatusi
            // 
            this.strStatusi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMesazhi});
            this.strStatusi.Location = new System.Drawing.Point(0, 448);
            this.strStatusi.Name = "strStatusi";
            this.strStatusi.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.strStatusi.Size = new System.Drawing.Size(637, 22);
            this.strStatusi.TabIndex = 1;
            this.strStatusi.Text = "statusStrip1";
            // 
            // lblMesazhi
            // 
            this.lblMesazhi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesazhi.ForeColor = System.Drawing.Color.Green;
            this.lblMesazhi.Name = "lblMesazhi";
            this.lblMesazhi.Size = new System.Drawing.Size(0, 17);
            // 
            // EntitetetBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(637, 470);
            this.Controls.Add(this.strStatusi);
            this.Controls.Add(this.pnlPaneli);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EntitetetBaze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EntitetetBaze";
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            this.strStatusi.ResumeLayout(false);
            this.strStatusi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pnlPaneli;
        protected System.Windows.Forms.Label lblPershkrimi;
        protected System.Windows.Forms.StatusStrip strStatusi;
        protected System.Windows.Forms.ToolStripStatusLabel lblMesazhi;
    }
}