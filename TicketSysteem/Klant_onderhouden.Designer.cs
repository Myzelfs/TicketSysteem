namespace TicketSysteem
{
    partial class Klant_onderhouden
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlfilter = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbfilterbar = new System.Windows.Forms.CheckBox();
            this.TimerDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.TimerAfkChecker = new System.Windows.Forms.Timer(this.components);
            this.Menuhomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbloutputdgvstatus
            // 
            this.lbloutputdgvstatus.BackColor = System.Drawing.Color.LightGray;
            this.lbloutputdgvstatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputdgvstatus.Location = new System.Drawing.Point(232, 33);
            this.lbloutputdgvstatus.Name = "lbloutputdgvstatus";
            this.lbloutputdgvstatus.Size = new System.Drawing.Size(240, 44);
            this.lbloutputdgvstatus.TabIndex = 9;
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
            this.Menuhomepage.TabIndex = 8;
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
            this.lbloutputpagina.Location = new System.Drawing.Point(457, 541);
            this.lbloutputpagina.Name = "lbloutputpagina";
            this.lbloutputpagina.Size = new System.Drawing.Size(293, 21);
            this.lbloutputpagina.TabIndex = 13;
            this.lbloutputpagina.Text = "Pagina :";
            // 
            // lbloutputlevel
            // 
            this.lbloutputlevel.BackColor = System.Drawing.Color.Gray;
            this.lbloutputlevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputlevel.Location = new System.Drawing.Point(216, 541);
            this.lbloutputlevel.Name = "lbloutputlevel";
            this.lbloutputlevel.Size = new System.Drawing.Size(244, 21);
            this.lbloutputlevel.TabIndex = 12;
            this.lbloutputlevel.Text = "Toegankelijkheid :";
            // 
            // lbloutputnaam
            // 
            this.lbloutputnaam.BackColor = System.Drawing.Color.Gray;
            this.lbloutputnaam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputnaam.Location = new System.Drawing.Point(-3, 541);
            this.lbloutputnaam.Name = "lbloutputnaam";
            this.lbloutputnaam.Size = new System.Drawing.Size(230, 21);
            this.lbloutputnaam.TabIndex = 11;
            this.lbloutputnaam.Text = "Naam :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 379);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // pnlfilter
            // 
            this.pnlfilter.Controls.Add(this.textBox1);
            this.pnlfilter.Controls.Add(this.label2);
            this.pnlfilter.Controls.Add(this.cmbfilter);
            this.pnlfilter.Controls.Add(this.label1);
            this.pnlfilter.Location = new System.Drawing.Point(86, 100);
            this.pnlfilter.Name = "pnlfilter";
            this.pnlfilter.Size = new System.Drawing.Size(401, 43);
            this.pnlfilter.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            "naam",
            "address",
            "zipcode",
            "email",
            "city",
            "phonenumber"});
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
            // cbfilterbar
            // 
            this.cbfilterbar.AutoSize = true;
            this.cbfilterbar.Location = new System.Drawing.Point(17, 112);
            this.cbfilterbar.Name = "cbfilterbar";
            this.cbfilterbar.Size = new System.Drawing.Size(63, 17);
            this.cbfilterbar.TabIndex = 15;
            this.cbfilterbar.Text = "Filterbar";
            this.cbfilterbar.UseVisualStyleBackColor = true;
            this.cbfilterbar.CheckedChanged += new System.EventHandler(this.cbfilterbar_CheckedChanged);
            this.cbfilterbar.Click += new System.EventHandler(this.cbfilterbar_Click);
            // 
            // TimerDataRefresh
            // 
            this.TimerDataRefresh.Enabled = true;
            this.TimerDataRefresh.Interval = 5000;
            this.TimerDataRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerAfkChecker
            // 
            this.TimerAfkChecker.Enabled = true;
            this.TimerAfkChecker.Interval = 15000;
            this.TimerAfkChecker.Tick += new System.EventHandler(this.TimerAfkChecker_Tick);
            // 
            // Klant_onderhouden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 561);
            this.Controls.Add(this.pnlfilter);
            this.Controls.Add(this.cbfilterbar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbloutputpagina);
            this.Controls.Add(this.lbloutputlevel);
            this.Controls.Add(this.lbloutputnaam);
            this.Controls.Add(this.lbloutputdgvstatus);
            this.Controls.Add(this.Menuhomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Klant_onderhouden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klant_onderhouden";
            this.Click += new System.EventHandler(this.Klant_onderhouden_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Klant_onderhouden_MouseMove);
            this.Menuhomepage.ResumeLayout(false);
            this.Menuhomepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlfilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbfilterbar;
        private System.Windows.Forms.Timer TimerDataRefresh;
        private System.Windows.Forms.Timer TimerAfkChecker;
    }
}