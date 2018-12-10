namespace TicketSysteem
{
    partial class eventpage
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
            this.lbloutputdgvstatus = new System.Windows.Forms.Label();
            this.Menuhomepage = new System.Windows.Forms.MenuStrip();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantOnderhoudenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbloutputpagina = new System.Windows.Forms.Label();
            this.lbloutputlevel = new System.Windows.Forms.Label();
            this.lbloutputnaam = new System.Windows.Forms.Label();
            this.dgvevent = new System.Windows.Forms.DataGridView();
            this.cbfilterbar = new System.Windows.Forms.CheckBox();
            this.pnlfilter = new System.Windows.Forms.Panel();
            this.cmbPrioriteit = new System.Windows.Forms.ComboBox();
            this.txbfilter = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.TimerAfkChecker = new System.Windows.Forms.Timer(this.components);
            this.Menuhomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).BeginInit();
            this.pnlfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbloutputdgvstatus
            // 
            this.lbloutputdgvstatus.BackColor = System.Drawing.Color.LightGray;
            this.lbloutputdgvstatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputdgvstatus.Location = new System.Drawing.Point(298, 33);
            this.lbloutputdgvstatus.Name = "lbloutputdgvstatus";
            this.lbloutputdgvstatus.Size = new System.Drawing.Size(100, 44);
            this.lbloutputdgvstatus.TabIndex = 7;
            // 
            // Menuhomepage
            // 
            this.Menuhomepage.AutoSize = false;
            this.Menuhomepage.BackColor = System.Drawing.Color.Gray;
            this.Menuhomepage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuhomepage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.klantAanmakenToolStripMenuItem,
            this.klantOnderhoudenToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.faqToolStripMenuItem,
            this.toolStripMenuItem1});
            this.Menuhomepage.Location = new System.Drawing.Point(0, 0);
            this.Menuhomepage.Name = "Menuhomepage";
            this.Menuhomepage.Size = new System.Drawing.Size(748, 33);
            this.Menuhomepage.TabIndex = 6;
            this.Menuhomepage.Text = "Menuhomepage";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // klantAanmakenToolStripMenuItem
            // 
            this.klantAanmakenToolStripMenuItem.Name = "klantAanmakenToolStripMenuItem";
            this.klantAanmakenToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.klantAanmakenToolStripMenuItem.Text = "klant aanmaken";
            this.klantAanmakenToolStripMenuItem.Click += new System.EventHandler(this.klantAanmakenToolStripMenuItem_Click);
            // 
            // klantOnderhoudenToolStripMenuItem
            // 
            this.klantOnderhoudenToolStripMenuItem.Name = "klantOnderhoudenToolStripMenuItem";
            this.klantOnderhoudenToolStripMenuItem.Size = new System.Drawing.Size(189, 29);
            this.klantOnderhoudenToolStripMenuItem.Text = "klant onderhouden";
            this.klantOnderhoudenToolStripMenuItem.Click += new System.EventHandler(this.klantOnderhoudenToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.eventsToolStripMenuItem.Text = "events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // faqToolStripMenuItem
            // 
            this.faqToolStripMenuItem.Name = "faqToolStripMenuItem";
            this.faqToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.faqToolStripMenuItem.Text = "FAQ";
            this.faqToolStripMenuItem.Click += new System.EventHandler(this.faqToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 29);
            this.toolStripMenuItem1.Text = "Change user";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lbloutputpagina
            // 
            this.lbloutputpagina.BackColor = System.Drawing.Color.Gray;
            this.lbloutputpagina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputpagina.Location = new System.Drawing.Point(460, 541);
            this.lbloutputpagina.Name = "lbloutputpagina";
            this.lbloutputpagina.Size = new System.Drawing.Size(288, 21);
            this.lbloutputpagina.TabIndex = 10;
            this.lbloutputpagina.Text = "Pagina :";
            // 
            // lbloutputlevel
            // 
            this.lbloutputlevel.BackColor = System.Drawing.Color.Gray;
            this.lbloutputlevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputlevel.Location = new System.Drawing.Point(219, 541);
            this.lbloutputlevel.Name = "lbloutputlevel";
            this.lbloutputlevel.Size = new System.Drawing.Size(244, 21);
            this.lbloutputlevel.TabIndex = 9;
            this.lbloutputlevel.Text = "Toegankelijkheid :";
            // 
            // lbloutputnaam
            // 
            this.lbloutputnaam.BackColor = System.Drawing.Color.Gray;
            this.lbloutputnaam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputnaam.Location = new System.Drawing.Point(0, 541);
            this.lbloutputnaam.Name = "lbloutputnaam";
            this.lbloutputnaam.Size = new System.Drawing.Size(230, 21);
            this.lbloutputnaam.TabIndex = 8;
            this.lbloutputnaam.Text = "Naam :";
            // 
            // dgvevent
            // 
            this.dgvevent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvevent.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvevent.Location = new System.Drawing.Point(0, 158);
            this.dgvevent.Name = "dgvevent";
            this.dgvevent.ReadOnly = true;
            this.dgvevent.Size = new System.Drawing.Size(748, 380);
            this.dgvevent.TabIndex = 11;
            this.dgvevent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvevent_CellClick);
            this.dgvevent.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvevent_Scroll);
            this.dgvevent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvevent_MouseMove);
            // 
            // cbfilterbar
            // 
            this.cbfilterbar.AutoSize = true;
            this.cbfilterbar.Location = new System.Drawing.Point(10, 121);
            this.cbfilterbar.Name = "cbfilterbar";
            this.cbfilterbar.Size = new System.Drawing.Size(63, 17);
            this.cbfilterbar.TabIndex = 12;
            this.cbfilterbar.Text = "Filterbar";
            this.cbfilterbar.UseVisualStyleBackColor = true;
            this.cbfilterbar.CheckedChanged += new System.EventHandler(this.cbfilterbar_CheckedChanged);
            this.cbfilterbar.Click += new System.EventHandler(this.cbfilterbar_Click);
            // 
            // pnlfilter
            // 
            this.pnlfilter.Controls.Add(this.cmbPrioriteit);
            this.pnlfilter.Controls.Add(this.txbfilter);
            this.pnlfilter.Controls.Add(this.cmbStatus);
            this.pnlfilter.Controls.Add(this.label2);
            this.pnlfilter.Controls.Add(this.cmbfilter);
            this.pnlfilter.Controls.Add(this.label1);
            this.pnlfilter.Location = new System.Drawing.Point(79, 109);
            this.pnlfilter.Name = "pnlfilter";
            this.pnlfilter.Size = new System.Drawing.Size(401, 43);
            this.pnlfilter.TabIndex = 13;
            this.pnlfilter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfilter_Paint);
            // 
            // cmbPrioriteit
            // 
            this.cmbPrioriteit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioriteit.FormattingEnabled = true;
            this.cmbPrioriteit.Items.AddRange(new object[] {
            "",
            "low",
            "medium",
            "high",
            "immediatly",
            "undetermined"});
            this.cmbPrioriteit.Location = new System.Drawing.Point(252, 10);
            this.cmbPrioriteit.Name = "cmbPrioriteit";
            this.cmbPrioriteit.Size = new System.Drawing.Size(130, 21);
            this.cmbPrioriteit.TabIndex = 18;
            this.cmbPrioriteit.SelectedIndexChanged += new System.EventHandler(this.cmbPrioriteit_SelectedIndexChanged);
            this.cmbPrioriteit.Click += new System.EventHandler(this.cmbPrioriteit_Click);
            // 
            // txbfilter
            // 
            this.txbfilter.Location = new System.Drawing.Point(252, 10);
            this.txbfilter.Multiline = true;
            this.txbfilter.Name = "txbfilter";
            this.txbfilter.Size = new System.Drawing.Size(130, 21);
            this.txbfilter.TabIndex = 17;
            this.txbfilter.Click += new System.EventHandler(this.txbfilter_Click);
            this.txbfilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbfilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbfilter_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "",
            "new",
            "in progress",
            "finished"});
            this.cmbStatus.Location = new System.Drawing.Point(252, 10);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 21);
            this.cmbStatus.TabIndex = 19;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.Click += new System.EventHandler(this.cmbStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "zoeken :";
            // 
            // cmbfilter
            // 
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Items.AddRange(new object[] {
            "Priority",
            "Status",
            "answer"});
            this.cmbfilter.Location = new System.Drawing.Point(71, 10);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(121, 21);
            this.cmbfilter.TabIndex = 15;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            this.cmbfilter.Click += new System.EventHandler(this.cmbfilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filteren op :";
            // 
            // TimerDataRefresh
            // 
            this.TimerDataRefresh.Interval = 5000;
            this.TimerDataRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerAfkChecker
            // 
            this.TimerAfkChecker.Enabled = true;
            this.TimerAfkChecker.Interval = 30000;
            this.TimerAfkChecker.Tick += new System.EventHandler(this.TimerAfkChecker_Tick);
            // 
            // eventpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 561);
            this.Controls.Add(this.pnlfilter);
            this.Controls.Add(this.cbfilterbar);
            this.Controls.Add(this.dgvevent);
            this.Controls.Add(this.lbloutputpagina);
            this.Controls.Add(this.lbloutputlevel);
            this.Controls.Add(this.lbloutputnaam);
            this.Controls.Add(this.lbloutputdgvstatus);
            this.Controls.Add(this.Menuhomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "eventpage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eventpage";
            this.Load += new System.EventHandler(this.eventpage_Load);
            this.Click += new System.EventHandler(this.eventpage_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.eventpage_MouseMove);
            this.Menuhomepage.ResumeLayout(false);
            this.Menuhomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).EndInit();
            this.pnlfilter.ResumeLayout(false);
            this.pnlfilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutputdgvstatus;
        private System.Windows.Forms.MenuStrip Menuhomepage;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantOnderhoudenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbloutputpagina;
        private System.Windows.Forms.Label lbloutputlevel;
        private System.Windows.Forms.Label lbloutputnaam;
        private System.Windows.Forms.DataGridView dgvevent;
        private System.Windows.Forms.CheckBox cbfilterbar;
        private System.Windows.Forms.Panel pnlfilter;
        private System.Windows.Forms.TextBox txbfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrioriteit;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Timer TimerDataRefresh;
        private System.Windows.Forms.Timer TimerAfkChecker;
    }
}