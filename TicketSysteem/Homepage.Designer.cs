namespace TicketSysteem
{
    partial class Homepage
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
            this.Menuhomepage = new System.Windows.Forms.MenuStrip();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantOnderhoudenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbloutputnaam = new System.Windows.Forms.Label();
            this.lbloutputlevel = new System.Windows.Forms.Label();
            this.lbloutputpagina = new System.Windows.Forms.Label();
            this.Dgvhome = new System.Windows.Forms.DataGridView();
            this.lbloutputdgvstatus = new System.Windows.Forms.Label();
            this.btnnewtickets = new System.Windows.Forms.Button();
            this.btnyourtickets = new System.Windows.Forms.Button();
            this.txbfilter = new System.Windows.Forms.TextBox();
            this.cbxfilter = new System.Windows.Forms.ComboBox();
            this.cbfilter = new System.Windows.Forms.CheckBox();
            this.lblfilter1 = new System.Windows.Forms.Label();
            this.lblfilter2 = new System.Windows.Forms.Label();
            this.btncreatetickets = new System.Windows.Forms.Button();
            this.pnlfilter = new System.Windows.Forms.Panel();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbPrioriteit = new System.Windows.Forms.ComboBox();
            this.TimerDatagrid = new System.Windows.Forms.Timer(this.components);
            this.AutoLogout = new System.Windows.Forms.Timer(this.components);
            this.Menuhomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvhome)).BeginInit();
            this.pnlfilter.SuspendLayout();
            this.SuspendLayout();
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
            this.Menuhomepage.Size = new System.Drawing.Size(750, 33);
            this.Menuhomepage.TabIndex = 0;
            this.Menuhomepage.Text = "Menuhomepage";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.homepageToolStripMenuItem.Text = "Homepage";
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
            // lbloutputnaam
            // 
            this.lbloutputnaam.BackColor = System.Drawing.Color.Gray;
            this.lbloutputnaam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputnaam.Location = new System.Drawing.Point(-3, 543);
            this.lbloutputnaam.Name = "lbloutputnaam";
            this.lbloutputnaam.Size = new System.Drawing.Size(230, 21);
            this.lbloutputnaam.TabIndex = 1;
            this.lbloutputnaam.Text = "Naam :";
            // 
            // lbloutputlevel
            // 
            this.lbloutputlevel.BackColor = System.Drawing.Color.Gray;
            this.lbloutputlevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputlevel.Location = new System.Drawing.Point(216, 543);
            this.lbloutputlevel.Name = "lbloutputlevel";
            this.lbloutputlevel.Size = new System.Drawing.Size(244, 21);
            this.lbloutputlevel.TabIndex = 2;
            this.lbloutputlevel.Text = "Toegankelijkheid :";
            // 
            // lbloutputpagina
            // 
            this.lbloutputpagina.BackColor = System.Drawing.Color.Gray;
            this.lbloutputpagina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputpagina.Location = new System.Drawing.Point(457, 543);
            this.lbloutputpagina.Name = "lbloutputpagina";
            this.lbloutputpagina.Size = new System.Drawing.Size(293, 21);
            this.lbloutputpagina.TabIndex = 3;
            this.lbloutputpagina.Text = "Pagina :";
            // 
            // Dgvhome
            // 
            this.Dgvhome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvhome.BackgroundColor = System.Drawing.Color.LightGray;
            this.Dgvhome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvhome.Location = new System.Drawing.Point(0, 171);
            this.Dgvhome.Name = "Dgvhome";
            this.Dgvhome.ReadOnly = true;
            this.Dgvhome.ShowEditingIcon = false;
            this.Dgvhome.Size = new System.Drawing.Size(750, 369);
            this.Dgvhome.TabIndex = 4;
            this.Dgvhome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvhome_CellClick);
            this.Dgvhome.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Dgvhome_Scroll);
            this.Dgvhome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgvhome_MouseMove);
            // 
            // lbloutputdgvstatus
            // 
            this.lbloutputdgvstatus.BackColor = System.Drawing.Color.LightGray;
            this.lbloutputdgvstatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputdgvstatus.Location = new System.Drawing.Point(281, 33);
            this.lbloutputdgvstatus.Name = "lbloutputdgvstatus";
            this.lbloutputdgvstatus.Size = new System.Drawing.Size(152, 44);
            this.lbloutputdgvstatus.TabIndex = 5;
            // 
            // btnnewtickets
            // 
            this.btnnewtickets.Location = new System.Drawing.Point(661, 138);
            this.btnnewtickets.Name = "btnnewtickets";
            this.btnnewtickets.Size = new System.Drawing.Size(75, 23);
            this.btnnewtickets.TabIndex = 6;
            this.btnnewtickets.Text = "New tickets";
            this.btnnewtickets.UseVisualStyleBackColor = true;
            this.btnnewtickets.Click += new System.EventHandler(this.btnnewtickets_Click);
            // 
            // btnyourtickets
            // 
            this.btnyourtickets.Location = new System.Drawing.Point(661, 138);
            this.btnyourtickets.Name = "btnyourtickets";
            this.btnyourtickets.Size = new System.Drawing.Size(75, 23);
            this.btnyourtickets.TabIndex = 7;
            this.btnyourtickets.Text = "Your tickets";
            this.btnyourtickets.UseVisualStyleBackColor = true;
            this.btnyourtickets.Click += new System.EventHandler(this.btnyourtickets_Click);
            // 
            // txbfilter
            // 
            this.txbfilter.Location = new System.Drawing.Point(239, 13);
            this.txbfilter.Multiline = true;
            this.txbfilter.Name = "txbfilter";
            this.txbfilter.Size = new System.Drawing.Size(100, 21);
            this.txbfilter.TabIndex = 8;
            this.txbfilter.Click += new System.EventHandler(this.txbfilter_Click);
            this.txbfilter.TextChanged += new System.EventHandler(this.txbfilter_TextChanged);
            this.txbfilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbfilter_KeyPress);
            // 
            // cbxfilter
            // 
            this.cbxfilter.FormattingEnabled = true;
            this.cbxfilter.Items.AddRange(new object[] {
            "Subject",
            "Priority",
            "Status"});
            this.cbxfilter.Location = new System.Drawing.Point(74, 13);
            this.cbxfilter.Name = "cbxfilter";
            this.cbxfilter.Size = new System.Drawing.Size(103, 21);
            this.cbxfilter.TabIndex = 9;
            this.cbxfilter.SelectedIndexChanged += new System.EventHandler(this.cbxfilter_SelectedIndexChanged);
            this.cbxfilter.Click += new System.EventHandler(this.cbxfilter_Click);
            // 
            // cbfilter
            // 
            this.cbfilter.AutoSize = true;
            this.cbfilter.Location = new System.Drawing.Point(12, 139);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(63, 17);
            this.cbfilter.TabIndex = 10;
            this.cbfilter.Text = "Filterbar";
            this.cbfilter.UseVisualStyleBackColor = true;
            this.cbfilter.CheckedChanged += new System.EventHandler(this.cbfilter_CheckedChanged);
            this.cbfilter.Click += new System.EventHandler(this.cbfilter_Click);
            // 
            // lblfilter1
            // 
            this.lblfilter1.AutoSize = true;
            this.lblfilter1.Location = new System.Drawing.Point(6, 16);
            this.lblfilter1.Name = "lblfilter1";
            this.lblfilter1.Size = new System.Drawing.Size(62, 13);
            this.lblfilter1.TabIndex = 11;
            this.lblfilter1.Text = "Filteren op :";
            // 
            // lblfilter2
            // 
            this.lblfilter2.AutoSize = true;
            this.lblfilter2.Location = new System.Drawing.Point(183, 16);
            this.lblfilter2.Name = "lblfilter2";
            this.lblfilter2.Size = new System.Drawing.Size(50, 13);
            this.lblfilter2.TabIndex = 12;
            this.lblfilter2.Text = "Zoeken :";
            // 
            // btncreatetickets
            // 
            this.btncreatetickets.Location = new System.Drawing.Point(641, 137);
            this.btncreatetickets.Name = "btncreatetickets";
            this.btncreatetickets.Size = new System.Drawing.Size(95, 23);
            this.btncreatetickets.TabIndex = 13;
            this.btncreatetickets.Text = "Create tickets";
            this.btncreatetickets.UseVisualStyleBackColor = true;
            this.btncreatetickets.Click += new System.EventHandler(this.btncreatetickets_Click);
            // 
            // pnlfilter
            // 
            this.pnlfilter.Controls.Add(this.cmbstatus);
            this.pnlfilter.Controls.Add(this.cmbPrioriteit);
            this.pnlfilter.Controls.Add(this.txbfilter);
            this.pnlfilter.Controls.Add(this.cbxfilter);
            this.pnlfilter.Controls.Add(this.lblfilter2);
            this.pnlfilter.Controls.Add(this.lblfilter1);
            this.pnlfilter.Location = new System.Drawing.Point(83, 124);
            this.pnlfilter.Name = "pnlfilter";
            this.pnlfilter.Size = new System.Drawing.Size(350, 41);
            this.pnlfilter.TabIndex = 14;
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "",
            "new",
            "in progress",
            "finished"});
            this.cmbstatus.Location = new System.Drawing.Point(239, 13);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(100, 21);
            this.cmbstatus.TabIndex = 16;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            this.cmbstatus.Click += new System.EventHandler(this.cmbstatus_Click);
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
            this.cmbPrioriteit.Location = new System.Drawing.Point(239, 13);
            this.cmbPrioriteit.Name = "cmbPrioriteit";
            this.cmbPrioriteit.Size = new System.Drawing.Size(100, 21);
            this.cmbPrioriteit.TabIndex = 15;
            this.cmbPrioriteit.SelectedIndexChanged += new System.EventHandler(this.cmbPrioriteit_SelectedIndexChanged);
            this.cmbPrioriteit.Click += new System.EventHandler(this.cmbPrioriteit_Click);
            // 
            // TimerDatagrid
            // 
            this.TimerDatagrid.Enabled = true;
            this.TimerDatagrid.Interval = 5000;
            this.TimerDatagrid.Tick += new System.EventHandler(this.Timerdatagridrefresh_Tick);
            // 
            // AutoLogout
            // 
            this.AutoLogout.Enabled = true;
            this.AutoLogout.Interval = 30000;
            this.AutoLogout.Tick += new System.EventHandler(this.AutoLogout_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 561);
            this.Controls.Add(this.pnlfilter);
            this.Controls.Add(this.btncreatetickets);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.btnyourtickets);
            this.Controls.Add(this.btnnewtickets);
            this.Controls.Add(this.lbloutputdgvstatus);
            this.Controls.Add(this.Dgvhome);
            this.Controls.Add(this.lbloutputpagina);
            this.Controls.Add(this.lbloutputlevel);
            this.Controls.Add(this.lbloutputnaam);
            this.Controls.Add(this.Menuhomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menuhomepage;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketsysteem";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.Click += new System.EventHandler(this.Homepage_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Homepage_MouseMove);
            this.Menuhomepage.ResumeLayout(false);
            this.Menuhomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvhome)).EndInit();
            this.pnlfilter.ResumeLayout(false);
            this.pnlfilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menuhomepage;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantOnderhoudenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faqToolStripMenuItem;
        private System.Windows.Forms.Label lbloutputnaam;
        private System.Windows.Forms.Label lbloutputlevel;
        private System.Windows.Forms.Label lbloutputpagina;
        private System.Windows.Forms.DataGridView Dgvhome;
        private System.Windows.Forms.Label lbloutputdgvstatus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnnewtickets;
        private System.Windows.Forms.Button btnyourtickets;
        private System.Windows.Forms.TextBox txbfilter;
        private System.Windows.Forms.ComboBox cbxfilter;
        private System.Windows.Forms.CheckBox cbfilter;
        private System.Windows.Forms.Label lblfilter1;
        private System.Windows.Forms.Label lblfilter2;
        private System.Windows.Forms.Button btncreatetickets;
        private System.Windows.Forms.Panel pnlfilter;
        private System.Windows.Forms.ComboBox cmbPrioriteit;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Timer TimerDatagrid;
        private System.Windows.Forms.Timer AutoLogout;
    }
}