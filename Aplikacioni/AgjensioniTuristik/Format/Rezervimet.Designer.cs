namespace AgjensioniTuristik.Format
{
    partial class Rezervimet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnShtoRezervim = new System.Windows.Forms.Button();
            this.btnNdrysho = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvRezervimet = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nëDetajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetëmIDjaERezervimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPaneli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(350, 15);
            this.lblPershkrimi.Text = "Shtoni, ndryshoni dhe fshini të dhënat në lidhje me rezervimet";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 22);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(521, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rezervimet";
            // 
            // btnFshi
            // 
            this.btnFshi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFshi.Image = global::AgjensioniTuristik.Properties.Resources.Fshi24x24;
            this.btnFshi.Location = new System.Drawing.Point(88, 92);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(32, 33);
            this.btnFshi.TabIndex = 18;
            this.btnFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnShtoRezervim
            // 
            this.btnShtoRezervim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShtoRezervim.Image = global::AgjensioniTuristik.Properties.Resources.Shto24x24;
            this.btnShtoRezervim.Location = new System.Drawing.Point(12, 92);
            this.btnShtoRezervim.Name = "btnShtoRezervim";
            this.btnShtoRezervim.Size = new System.Drawing.Size(32, 33);
            this.btnShtoRezervim.TabIndex = 16;
            this.btnShtoRezervim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShtoRezervim.UseVisualStyleBackColor = true;
            this.btnShtoRezervim.Click += new System.EventHandler(this.btnShtoRezervim_Click);
            // 
            // btnNdrysho
            // 
            this.btnNdrysho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNdrysho.Image = global::AgjensioniTuristik.Properties.Resources.Ndrysho24x24;
            this.btnNdrysho.Location = new System.Drawing.Point(50, 92);
            this.btnNdrysho.Name = "btnNdrysho";
            this.btnNdrysho.Size = new System.Drawing.Size(32, 33);
            this.btnNdrysho.TabIndex = 17;
            this.btnNdrysho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNdrysho.UseVisualStyleBackColor = true;
            this.btnNdrysho.Click += new System.EventHandler(this.btnNdrysho_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvRezervimet);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 314);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervimet";
            // 
            // lvRezervimet
            // 
            this.lvRezervimet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRezervimet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvRezervimet.ContextMenuStrip = this.contextMenuStrip1;
            this.lvRezervimet.FullRowSelect = true;
            this.lvRezervimet.Location = new System.Drawing.Point(6, 22);
            this.lvRezervimet.Name = "lvRezervimet";
            this.lvRezervimet.Size = new System.Drawing.Size(590, 286);
            this.lvRezervimet.TabIndex = 30;
            this.lvRezervimet.UseCompatibleStateImageBehavior = false;
            this.lvRezervimet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Përdoruesi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fluturimi";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Udhëtari";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ulësja";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lloji i rezervimit";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Çmimi";
            this.columnHeader7.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shtoToolStripMenuItem,
            this.fshiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listimiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 76);
            // 
            // shtoToolStripMenuItem
            // 
            this.shtoToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Ndrysho24x24;
            this.shtoToolStripMenuItem.Name = "shtoToolStripMenuItem";
            this.shtoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shtoToolStripMenuItem.Text = "Ndrysho";
            this.shtoToolStripMenuItem.Click += new System.EventHandler(this.btnNdrysho_Click);
            // 
            // fshiToolStripMenuItem
            // 
            this.fshiToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Fshi24x24;
            this.fshiToolStripMenuItem.Name = "fshiToolStripMenuItem";
            this.fshiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fshiToolStripMenuItem.Text = "Fshi";
            this.fshiToolStripMenuItem.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // listimiToolStripMenuItem
            // 
            this.listimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nëDetajeToolStripMenuItem,
            this.vetëmIDjaERezervimitToolStripMenuItem});
            this.listimiToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.listimiToolStripMenuItem.Name = "listimiToolStripMenuItem";
            this.listimiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listimiToolStripMenuItem.Text = "Listimi";
            // 
            // nëDetajeToolStripMenuItem
            // 
            this.nëDetajeToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.nëDetajeToolStripMenuItem.Name = "nëDetajeToolStripMenuItem";
            this.nëDetajeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nëDetajeToolStripMenuItem.Text = "Në detaje";
            this.nëDetajeToolStripMenuItem.Click += new System.EventHandler(this.nëDetajeToolStripMenuItem_Click);
            // 
            // vetëmIDjaERezervimitToolStripMenuItem
            // 
            this.vetëmIDjaERezervimitToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.vetëmIDjaERezervimitToolStripMenuItem.Name = "vetëmIDjaERezervimitToolStripMenuItem";
            this.vetëmIDjaERezervimitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.vetëmIDjaERezervimitToolStripMenuItem.Text = "Vetëm ID-ja e rezervimit";
            this.vetëmIDjaERezervimitToolStripMenuItem.Click += new System.EventHandler(this.vetëmIDjaERezervimitToolStripMenuItem_Click);
            // 
            // Rezervimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFshi);
            this.Controls.Add(this.btnShtoRezervim);
            this.Controls.Add(this.btnNdrysho);
            this.Controls.Add(this.panel1);
            this.Name = "Rezervimet";
            this.Text = "Rezervimet";
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnNdrysho, 0);
            this.Controls.SetChildIndex(this.btnShtoRezervim, 0);
            this.Controls.SetChildIndex(this.btnFshi, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlPaneli.ResumeLayout(false);
            this.pnlPaneli.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.Button btnShtoRezervim;
        private System.Windows.Forms.Button btnNdrysho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvRezervimet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nëDetajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetëmIDjaERezervimitToolStripMenuItem;
    }
}