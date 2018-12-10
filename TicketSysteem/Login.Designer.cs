namespace TicketSysteem
{
    partial class Login
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
            this.Txbusername = new System.Windows.Forms.TextBox();
            this.Txbpassword = new System.Windows.Forms.TextBox();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.OnlineChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Txbusername
            // 
            this.Txbusername.Location = new System.Drawing.Point(95, 152);
            this.Txbusername.Name = "Txbusername";
            this.Txbusername.Size = new System.Drawing.Size(129, 20);
            this.Txbusername.TabIndex = 0;
            this.Txbusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txbusername_KeyDown);
            // 
            // Txbpassword
            // 
            this.Txbpassword.Location = new System.Drawing.Point(95, 215);
            this.Txbpassword.Name = "Txbpassword";
            this.Txbpassword.PasswordChar = '*';
            this.Txbpassword.Size = new System.Drawing.Size(129, 20);
            this.Txbpassword.TabIndex = 1;
            this.Txbpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txbpassword_KeyDown);
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(119, 241);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(75, 23);
            this.Btnlogin.TabIndex = 2;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOutput.Location = new System.Drawing.Point(38, 277);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(234, 15);
            this.lblOutput.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // OnlineChecker
            // 
            this.OnlineChecker.Enabled = true;
            this.OnlineChecker.Interval = 2000;
            this.OnlineChecker.Tick += new System.EventHandler(this.OnlineChecker_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 397);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.Txbpassword);
            this.Controls.Add(this.Txbusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketsysteem";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txbusername;
        private System.Windows.Forms.TextBox Txbpassword;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer OnlineChecker;
    }
}

