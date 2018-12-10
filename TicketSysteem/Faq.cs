using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSysteem
{
    public partial class Faq : Form
    {
        public Faq()
        {
            InitializeComponent();
            PreLoad();
            fullHide();
        }

        private void Faq_Load(object sender, EventArgs e)
        {
            // changing status from page
            faqToolStripMenuItem.BackColor = Color.LightGray;
            lbloutputdgvstatus.Text = "FAQ";
        }

        private void fullHide()
        {
            // hiding all panels
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void PreLoad()
        {
            // loading information into the page
            switch (Gegevens.Level_ID)
            {
                case 1:
                    lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
                    lbloutputpagina.Text = lbloutputpagina.Text + " FAQ";
                    lbloutputlevel.Text = lbloutputlevel.Text + " Client";
                    klantAanmakenToolStripMenuItem.Dispose();
                    klantOnderhoudenToolStripMenuItem.Dispose();
                    eventsToolStripMenuItem.Dispose();
                    break;

                case 2:
                    lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
                    lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
                    lbloutputpagina.Text = lbloutputpagina.Text + " FAQ";
                    break;
            }
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            Homepage Redirect = new Homepage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            Gegevens.klantnummer = 1;
            Klant_maken Redirect = new Klant_maken();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void klantOnderhoudenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            Klant_onderhouden Redirect = new Klant_onderhouden();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            eventpage Redirect = new eventpage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            Login Redirect = new Login();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void TimerAfkChecker_Tick(object sender, EventArgs e)
        {
            // afk checker
            Hide();
            Close();
            TimerAfkChecker.Stop();
            MessageBox.Show("You were AFK and have been sent back to the login page");
            Login redirect = new Login();
            redirect.ShowDialog();
        }

        private void Faq_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void Faq_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Question1Locatie();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Question1Locatie();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Question1Locatie();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Question1Locatie();
        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void checkBox2_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void checkBox3_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void checkBox4_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void lbloutputdgvstatus_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void Question1Locatie()
        {
            // full positioning
            // vraag 1, vraag2, vraag3, vraag4
            // 1-0-0-0
            if (checkBox1.Checked == true && checkBox2.Checked == false &&
                checkBox3.Checked == false && checkBox4.Checked == false)
            {
                panel1.Location = new Point(64, 138);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 247);
                checkBox4.Location = new Point(64, 277);

                panel1.Show();
                panel2.Hide();
                panel3.Hide();
                panel4.Hide();
            }
            // 1-1-0-0 
            else if (checkBox1.Checked == true && checkBox2.Checked == true &&
                     checkBox3.Checked == false && checkBox4.Checked == false)
            {
                panel1.Location = new Point(64, 138);
                panel2.Location = new Point(64, 240);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 303);
                checkBox4.Location = new Point(64, 333);

                panel1.Show();
                panel2.Show();
                panel3.Hide();
                panel4.Hide();
            }
            // 1-1-1-0 
            else if (checkBox1.Checked == true && checkBox2.Checked == true &&
                     checkBox3.Checked == true && checkBox4.Checked == false)
            {
                panel1.Location = new Point(64, 138);
                panel2.Location = new Point(64, 240);
                panel3.Location = new Point(64, 327);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 303);
                checkBox4.Location = new Point(64, 390);

                panel1.Show();
                panel2.Show();
                panel3.Show();
                panel4.Hide();
            }
            // 1-1-1-1
            else if (checkBox1.Checked == true && checkBox2.Checked == true &&
                     checkBox3.Checked == true && checkBox4.Checked == true)
            {
                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 303);
                checkBox4.Location = new Point(64, 390);

                panel1.Location = new Point(64, 138);
                panel2.Location = new Point(64, 240);
                panel3.Location = new Point(64, 327);
                panel4.Location = new Point(64, 411);

                panel1.Show();
                panel2.Show();
                panel3.Show();
                panel4.Show();
            }
            // 0-1-0-0
            else if (checkBox1.Checked == false && checkBox2.Checked == true &&
                     checkBox3.Checked == false && checkBox4.Checked == false)
            {
                panel2.Location = new Point(64, 169);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 229);
                checkBox4.Location = new Point(64, 259);

                panel1.Hide();
                panel2.Show();
                panel3.Hide();
                panel4.Hide();
            }
            // 0-1-1-0
            else if (checkBox1.Checked == false && checkBox2.Checked == true &&
                     checkBox3.Checked == true && checkBox4.Checked == false)
            {
                panel2.Location = new Point(64, 169);
                panel3.Location = new Point(64, 250);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 229);
                checkBox4.Location = new Point(64, 313);

                panel1.Hide();
                panel2.Show();
                panel3.Show();
                panel4.Hide();
            }
            // 0-1-1-1
            else if (checkBox1.Checked == false && checkBox2.Checked == true &&
                     checkBox3.Checked == true && checkBox4.Checked == true)
            {
                panel2.Location = new Point(64, 169);
                panel3.Location = new Point(64, 250);
                panel4.Location = new Point(64, 331);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 229);
                checkBox4.Location = new Point(64, 313);

                panel1.Hide();
                panel2.Show();
                panel3.Show();
                panel4.Show();
            }
            // 0-0-1-0
            else if (checkBox1.Checked == false && checkBox2.Checked == false &&
                     checkBox3.Checked == true && checkBox4.Checked == false)
            {
                panel3.Location = new Point(64, 198);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 176);
                checkBox4.Location = new Point(64, 261);

                panel3.Show();
                panel2.Hide();
                panel1.Hide();
                panel4.Hide();
            }
            // 1-0-1-0
            else if (checkBox1.Checked == true && checkBox2.Checked == false &&
                     checkBox3.Checked == true && checkBox4.Checked == false)
            {
                panel1.Location = new Point(64, 138);
                panel3.Location = new Point(64, 270);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 247);
                checkBox4.Location = new Point(64, 333);

                panel3.Show();
                panel2.Hide();
                panel4.Hide();
                panel1.Show();
            }
            // 1-0-1-1
            else if (checkBox1.Checked == true && checkBox2.Checked == false &&
                     checkBox3.Checked == true && checkBox4.Checked == true)
            {
                panel1.Location = new Point(64, 138);
                panel3.Location = new Point(64, 270);
                panel4.Location = new Point(64, 352);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 247);
                checkBox4.Location = new Point(64, 333);

                panel3.Show();
                panel2.Hide();
                panel4.Show();
                panel1.Show();
            }
            // 0-0-0-1
            else if (checkBox1.Checked == false && checkBox2.Checked == false &&
                     checkBox3.Checked == false && checkBox4.Checked == true)
            {
                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 176);
                checkBox4.Location = new Point(64, 206);

                panel4.Location = new Point(64, 227);

                panel4.Show();
                panel3.Hide();
                panel2.Hide();
                panel1.Hide();
            }
            // 0-0-1-1
            else if (checkBox1.Checked == false && checkBox2.Checked == false &&
                     checkBox3.Checked == true && checkBox4.Checked == true)
            {
                panel3.Location = new Point(64, 198);
                panel4.Location = new Point(64, 280);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 176);
                checkBox4.Location = new Point(64, 261);

                panel2.Hide();
                panel3.Show();
                panel1.Hide();
                panel4.Show();
            }
            // 0-1-0-1
            else if (checkBox1.Checked == false && checkBox2.Checked == true &&
                     checkBox3.Checked == false && checkBox4.Checked == true)
            {
                panel2.Location = new Point(64, 169);
                panel4.Location = new Point(64, 280);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 229);
                checkBox4.Location = new Point(64, 259);

                panel2.Show();
                panel1.Hide();
                panel3.Hide();
                panel4.Show();
            }
            // 1-1-0-1
            else if (checkBox1.Checked == true && checkBox2.Checked == true &&
                     checkBox3.Checked == false && checkBox4.Checked == true)
            {
                panel1.Location = new Point(64, 138);
                panel2.Location = new Point(64, 240);
                panel4.Location = new Point(64, 351);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 303);
                checkBox4.Location = new Point(64, 333);

                panel2.Show();
                panel1.Show();
                panel3.Hide();
                panel4.Show();
            }
            // 1-0-0-1
            else if (checkBox1.Checked == true && checkBox2.Checked == false &&
                     checkBox3.Checked == false && checkBox4.Checked == true)
            {
                panel1.Location = new Point(64, 138);
                panel4.Location = new Point(64, 300);

                checkBox2.Location = new Point(64, 217);
                checkBox3.Location = new Point(64, 247);
                checkBox4.Location = new Point(64, 277);

                panel1.Show();
                panel2.Hide();
                panel3.Hide();
                panel4.Show();
            }
            else
            {
                panel1.Location = new Point(186, 468);
                panel2.Location = new Point(186, 468);
                panel3.Location = new Point(186, 468);
                panel4.Location = new Point(186, 468);

                checkBox2.Location = new Point(64, 146);
                checkBox3.Location = new Point(64, 176);
                checkBox4.Location = new Point(64, 206);

                panel1.Hide();
                panel2.Hide();
                panel3.Hide();
                panel4.Hide();
            }


        }
    }
}
