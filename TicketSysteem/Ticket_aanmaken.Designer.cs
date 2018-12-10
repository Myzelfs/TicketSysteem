namespace TicketSysteem
{
    partial class Ticket_aanmaken
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
            this.lbloutputpagina = new System.Windows.Forms.Label();
            this.lbloutputlevel = new System.Windows.Forms.Label();
            this.lbloutputnaam = new System.Windows.Forms.Label();
            this.lbloutputdgvstatus = new System.Windows.Forms.Label();
            this.Menuhomepage = new System.Windows.Forms.MenuStrip();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantOnderhoudenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txbmaaksubj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmaakdesc = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.pnlextrainfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbprioriteit = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDateCreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlevent = new System.Windows.Forms.Panel();
            this.dgvevent = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnevent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.TimerDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.Menuhomepage.SuspendLayout();
            this.pnlextrainfo.SuspendLayout();
            this.pnlevent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloutputpagina
            // 
            this.lbloutputpagina.BackColor = System.Drawing.Color.Gray;
            this.lbloutputpagina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputpagina.Location = new System.Drawing.Point(460, 502);
            this.lbloutputpagina.Name = "lbloutputpagina";
            this.lbloutputpagina.Size = new System.Drawing.Size(289, 21);
            this.lbloutputpagina.TabIndex = 6;
            this.lbloutputpagina.Text = "Pagina :";
            // 
            // lbloutputlevel
            // 
            this.lbloutputlevel.BackColor = System.Drawing.Color.Gray;
            this.lbloutputlevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputlevel.Location = new System.Drawing.Point(219, 502);
            this.lbloutputlevel.Name = "lbloutputlevel";
            this.lbloutputlevel.Size = new System.Drawing.Size(244, 21);
            this.lbloutputlevel.TabIndex = 5;
            this.lbloutputlevel.Text = "Toegankelijkheid :";
            // 
            // lbloutputnaam
            // 
            this.lbloutputnaam.BackColor = System.Drawing.Color.Gray;
            this.lbloutputnaam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputnaam.Location = new System.Drawing.Point(0, 502);
            this.lbloutputnaam.Name = "lbloutputnaam";
            this.lbloutputnaam.Size = new System.Drawing.Size(230, 21);
            this.lbloutputnaam.TabIndex = 4;
            this.lbloutputnaam.Text = "Naam :";
            // 
            // lbloutputdgvstatus
            // 
            this.lbloutputdgvstatus.BackColor = System.Drawing.Color.LightGray;
            this.lbloutputdgvstatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputdgvstatus.Location = new System.Drawing.Point(277, 33);
            this.lbloutputdgvstatus.Name = "lbloutputdgvstatus";
            this.lbloutputdgvstatus.Size = new System.Drawing.Size(170, 44);
            this.lbloutputdgvstatus.TabIndex = 5;
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
            this.Menuhomepage.TabIndex = 7;
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
            // txbmaaksubj
            // 
            this.txbmaaksubj.Location = new System.Drawing.Point(191, 116);
            this.txbmaaksubj.Name = "txbmaaksubj";
            this.txbmaaksubj.Size = new System.Drawing.Size(319, 20);
            this.txbmaaksubj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subject : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description :";
            // 
            // txbmaakdesc
            // 
            this.txbmaakdesc.Location = new System.Drawing.Point(191, 155);
            this.txbmaakdesc.Multiline = true;
            this.txbmaakdesc.Name = "txbmaakdesc";
            this.txbmaakdesc.Size = new System.Drawing.Size(319, 117);
            this.txbmaakdesc.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(403, 280);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pnlextrainfo
            // 
            this.pnlextrainfo.Controls.Add(this.label4);
            this.pnlextrainfo.Controls.Add(this.cmbprioriteit);
            this.pnlextrainfo.Controls.Add(this.cmbstatus);
            this.pnlextrainfo.Controls.Add(this.label3);
            this.pnlextrainfo.Location = new System.Drawing.Point(3, 116);
            this.pnlextrainfo.Name = "pnlextrainfo";
            this.pnlextrainfo.Size = new System.Drawing.Size(182, 156);
            this.pnlextrainfo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prioriteit";
            // 
            // cmbprioriteit
            // 
            this.cmbprioriteit.FormattingEnabled = true;
            this.cmbprioriteit.Items.AddRange(new object[] {
            "low",
            "medium",
            "high",
            "immediatly",
            "undetermined"});
            this.cmbprioriteit.Location = new System.Drawing.Point(35, 95);
            this.cmbprioriteit.Name = "cmbprioriteit";
            this.cmbprioriteit.Size = new System.Drawing.Size(121, 21);
            this.cmbprioriteit.TabIndex = 1;
            this.cmbprioriteit.SelectedIndexChanged += new System.EventHandler(this.cmbprioriteit_SelectedIndexChanged);
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "new",
            "in progress",
            "finished"});
            this.cmbstatus.Location = new System.Drawing.Point(35, 39);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbstatus.TabIndex = 0;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Status";
            // 
            // txbDateCreated
            // 
            this.txbDateCreated.Location = new System.Drawing.Point(566, 155);
            this.txbDateCreated.Name = "txbDateCreated";
            this.txbDateCreated.Size = new System.Drawing.Size(100, 20);
            this.txbDateCreated.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Created";
            // 
            // pnlevent
            // 
            this.pnlevent.Controls.Add(this.dgvevent);
            this.pnlevent.Controls.Add(this.label6);
            this.pnlevent.Controls.Add(this.btnevent);
            this.pnlevent.Controls.Add(this.textBox1);
            this.pnlevent.Location = new System.Drawing.Point(0, 309);
            this.pnlevent.Name = "pnlevent";
            this.pnlevent.Size = new System.Drawing.Size(749, 190);
            this.pnlevent.TabIndex = 21;
            // 
            // dgvevent
            // 
            this.dgvevent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvevent.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvevent.Location = new System.Drawing.Point(110, 71);
            this.dgvevent.Name = "dgvevent";
            this.dgvevent.Size = new System.Drawing.Size(515, 116);
            this.dgvevent.TabIndex = 22;
            this.dgvevent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvevent_CellClick);
            this.dgvevent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvevent_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Create a event";
            // 
            // btnevent
            // 
            this.btnevent.Location = new System.Drawing.Point(516, 27);
            this.btnevent.Name = "btnevent";
            this.btnevent.Size = new System.Drawing.Size(98, 25);
            this.btnevent.TabIndex = 1;
            this.btnevent.Text = "Create event";
            this.btnevent.UseVisualStyleBackColor = true;
            this.btnevent.Click += new System.EventHandler(this.btnevent_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(463, 43);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(118, 23);
            this.btnprint.TabIndex = 23;
            this.btnprint.Text = "Wilt u Printen?";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // TimerDataRefresh
            // 
            this.TimerDataRefresh.Enabled = true;
            this.TimerDataRefresh.Interval = 5000;
            this.TimerDataRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ticket_aanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 522);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.pnlevent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDateCreated);
            this.Controls.Add(this.pnlextrainfo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txbmaakdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbmaaksubj);
            this.Controls.Add(this.lbloutputdgvstatus);
            this.Controls.Add(this.Menuhomepage);
            this.Controls.Add(this.lbloutputpagina);
            this.Controls.Add(this.lbloutputlevel);
            this.Controls.Add(this.lbloutputnaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ticket_aanmaken";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketsysteem";
            this.Menuhomepage.ResumeLayout(false);
            this.Menuhomepage.PerformLayout();
            this.pnlextrainfo.ResumeLayout(false);
            this.pnlextrainfo.PerformLayout();
            this.pnlevent.ResumeLayout(false);
            this.pnlevent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutputpagina;
        private System.Windows.Forms.Label lbloutputlevel;
        private System.Windows.Forms.Label lbloutputnaam;
        private System.Windows.Forms.Label lbloutputdgvstatus;
        private System.Windows.Forms.MenuStrip Menuhomepage;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantOnderhoudenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txbmaaksubj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmaakdesc;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel pnlextrainfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbprioriteit;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDateCreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlevent;
        private System.Windows.Forms.DataGridView dgvevent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnevent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Timer TimerDataRefresh;
    }
}