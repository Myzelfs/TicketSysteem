namespace TicketSysteem
{
    partial class Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faq));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimerAfkChecker = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Menuhomepage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbloutputdgvstatus
            // 
            this.lbloutputdgvstatus.BackColor = System.Drawing.Color.LightGray;
            this.lbloutputdgvstatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputdgvstatus.Location = new System.Drawing.Point(302, 33);
            this.lbloutputdgvstatus.Name = "lbloutputdgvstatus";
            this.lbloutputdgvstatus.Size = new System.Drawing.Size(75, 44);
            this.lbloutputdgvstatus.TabIndex = 11;
            this.lbloutputdgvstatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbloutputdgvstatus_MouseMove);
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
            this.Menuhomepage.TabIndex = 10;
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
            this.lbloutputpagina.Location = new System.Drawing.Point(460, 540);
            this.lbloutputpagina.Name = "lbloutputpagina";
            this.lbloutputpagina.Size = new System.Drawing.Size(294, 21);
            this.lbloutputpagina.TabIndex = 16;
            this.lbloutputpagina.Text = "Pagina :";
            // 
            // lbloutputlevel
            // 
            this.lbloutputlevel.BackColor = System.Drawing.Color.Gray;
            this.lbloutputlevel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputlevel.Location = new System.Drawing.Point(219, 540);
            this.lbloutputlevel.Name = "lbloutputlevel";
            this.lbloutputlevel.Size = new System.Drawing.Size(244, 21);
            this.lbloutputlevel.TabIndex = 15;
            this.lbloutputlevel.Text = "Toegankelijkheid :";
            // 
            // lbloutputnaam
            // 
            this.lbloutputnaam.BackColor = System.Drawing.Color.Gray;
            this.lbloutputnaam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutputnaam.Location = new System.Drawing.Point(0, 540);
            this.lbloutputnaam.Name = "lbloutputnaam";
            this.lbloutputnaam.Size = new System.Drawing.Size(230, 21);
            this.lbloutputnaam.TabIndex = 14;
            this.lbloutputnaam.Text = "Naam :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 59);
            this.label1.TabIndex = 18;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 48);
            this.label3.TabIndex = 22;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(546, 48);
            this.label4.TabIndex = 24;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // TimerAfkChecker
            // 
            this.TimerAfkChecker.Enabled = true;
            this.TimerAfkChecker.Interval = 30000;
            this.TimerAfkChecker.Tick += new System.EventHandler(this.TimerAfkChecker_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 73);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.LightGray;
            this.checkBox1.Location = new System.Drawing.Point(64, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(562, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Wat is het verschil tussen de 32-Bits en de 64-Bits versie van Windows?";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseMove);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.LightGray;
            this.checkBox2.Location = new System.Drawing.Point(64, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(562, 24);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "ik heb een Mac en krijg een foutbericht wanneer ik klik op hulpprogramma nu downl" +
    "oaden. wat is er aan de hand?";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(192, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 57);
            this.panel2.TabIndex = 27;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.Color.LightGray;
            this.checkBox3.Location = new System.Drawing.Point(64, 176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(562, 24);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Ik heb een ander apparaat dan een Windows-apparaat en wil daarop windows uitvoere" +
    "n. Waar vind ik het medium?";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox3_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(192, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 57);
            this.panel3.TabIndex = 28;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.Color.LightGray;
            this.checkBox4.Location = new System.Drawing.Point(64, 206);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(562, 24);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "Ik heb een medium met het hulpprogramma voor het maken van media gemaakt. Wat nu?" +
    "";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            this.checkBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBox4_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(192, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 57);
            this.panel4.TabIndex = 29;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // Faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(748, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbloutputpagina);
            this.Controls.Add(this.lbloutputlevel);
            this.Controls.Add(this.lbloutputnaam);
            this.Controls.Add(this.lbloutputdgvstatus);
            this.Controls.Add(this.Menuhomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faq";
            this.Load += new System.EventHandler(this.Faq_Load);
            this.Click += new System.EventHandler(this.Faq_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Faq_MouseMove);
            this.Menuhomepage.ResumeLayout(false);
            this.Menuhomepage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TimerAfkChecker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Panel panel4;
    }
}