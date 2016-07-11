namespace Aeroporti.FormatBaze
{
    partial class MesazhiBaze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesazhiBaze));
            this.lblMesazhi = new System.Windows.Forms.Label();
            this.btnDil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesazhi
            // 
            this.lblMesazhi.AutoSize = true;
            this.lblMesazhi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesazhi.Location = new System.Drawing.Point(146, 62);
            this.lblMesazhi.Name = "lblMesazhi";
            this.lblMesazhi.Size = new System.Drawing.Size(40, 15);
            this.lblMesazhi.TabIndex = 2;
            this.lblMesazhi.Text = "label1";
            // 
            // btnDil
            // 
            this.btnDil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDil.Image = global::Aeroporti.Properties.Resources.Dil24x24;
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(336, 106);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(87, 34);
            this.btnDil.TabIndex = 0;
            this.btnDil.Text = "Dil";
            this.btnDil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Image = global::Aeroporti.Properties.Resources.Ok24x24;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(241, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ekzekuto";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Verejtje128x128.png");
            this.imageList1.Images.SetKeyName(1, "Informacion128x128.png");
            this.imageList1.Images.SetKeyName(2, "Gabim128x128.png");
            // 
            // MesazhiBaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnDil;
            this.ClientSize = new System.Drawing.Size(435, 156);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMesazhi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDil);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MesazhiBaze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesazhiBaze";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMesazhi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}