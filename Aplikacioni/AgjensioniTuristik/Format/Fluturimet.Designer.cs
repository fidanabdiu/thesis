namespace AgjensioniTuristik.Format
{
    partial class Fluturimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fluturimet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFreskoFluturimet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvFluturimet = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nëDetajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetëmIDjaEFluturimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPaneli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaneli
            // 
            this.pnlPaneli.Size = new System.Drawing.Size(763, 58);
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.Size = new System.Drawing.Size(193, 15);
            this.lblPershkrimi.Text = "Të dhënat në lidhje me fluturimet";
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
            this.panel1.Size = new System.Drawing.Size(735, 22);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(658, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fluturimet";
            // 
            // btnFreskoFluturimet
            // 
            this.btnFreskoFluturimet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFreskoFluturimet.Image = ((System.Drawing.Image)(resources.GetObject("btnFreskoFluturimet.Image")));
            this.btnFreskoFluturimet.Location = new System.Drawing.Point(12, 92);
            this.btnFreskoFluturimet.Name = "btnFreskoFluturimet";
            this.btnFreskoFluturimet.Size = new System.Drawing.Size(32, 33);
            this.btnFreskoFluturimet.TabIndex = 25;
            this.btnFreskoFluturimet.UseVisualStyleBackColor = true;
            this.btnFreskoFluturimet.Click += new System.EventHandler(this.btnFreskoFluturimet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvFluturimet);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 314);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fluturimet";
            // 
            // lvFluturimet
            // 
            this.lvFluturimet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFluturimet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvFluturimet.ContextMenuStrip = this.contextMenuStrip1;
            this.lvFluturimet.FullRowSelect = true;
            this.lvFluturimet.Location = new System.Drawing.Point(7, 22);
            this.lvFluturimet.Name = "lvFluturimet";
            this.lvFluturimet.Size = new System.Drawing.Size(719, 280);
            this.lvFluturimet.TabIndex = 0;
            this.lvFluturimet.UseCompatibleStateImageBehavior = false;
            this.lvFluturimet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aeroplani";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Destinacioni";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data e nisjes";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ora e nisjes";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Përdoruesi";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Anuluar";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Çmimi";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Çmimi kthyes";
            this.columnHeader9.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listimiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            // 
            // rezervoToolStripMenuItem
            // 
            this.rezervoToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Ok24x24;
            this.rezervoToolStripMenuItem.Name = "rezervoToolStripMenuItem";
            this.rezervoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezervoToolStripMenuItem.Text = "Rezervo";
            this.rezervoToolStripMenuItem.Click += new System.EventHandler(this.rezervoToolStripMenuItem_Click);
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
            this.vetëmIDjaEFluturimitToolStripMenuItem});
            this.listimiToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.listimiToolStripMenuItem.Name = "listimiToolStripMenuItem";
            this.listimiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listimiToolStripMenuItem.Text = "Listimi";
            // 
            // nëDetajeToolStripMenuItem
            // 
            this.nëDetajeToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.nëDetajeToolStripMenuItem.Name = "nëDetajeToolStripMenuItem";
            this.nëDetajeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nëDetajeToolStripMenuItem.Text = "Në detaje";
            this.nëDetajeToolStripMenuItem.Click += new System.EventHandler(this.nëDetajeToolStripMenuItem_Click);
            // 
            // vetëmIDjaEFluturimitToolStripMenuItem
            // 
            this.vetëmIDjaEFluturimitToolStripMenuItem.Image = global::AgjensioniTuristik.Properties.Resources.Listimi24x24;
            this.vetëmIDjaEFluturimitToolStripMenuItem.Name = "vetëmIDjaEFluturimitToolStripMenuItem";
            this.vetëmIDjaEFluturimitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.vetëmIDjaEFluturimitToolStripMenuItem.Text = "Vetëm ID-ja e fluturimit";
            this.vetëmIDjaEFluturimitToolStripMenuItem.Click += new System.EventHandler(this.vetëmIDjaEFluturimitToolStripMenuItem_Click);
            // 
            // Fluturimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFreskoFluturimet);
            this.Controls.Add(this.panel1);
            this.Name = "Fluturimet";
            this.Text = "Fluturimet";
            this.Controls.SetChildIndex(this.pnlPaneli, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnFreskoFluturimet, 0);
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
        private System.Windows.Forms.Button btnFreskoFluturimet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvFluturimet;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nëDetajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetëmIDjaEFluturimitToolStripMenuItem;
    }
}