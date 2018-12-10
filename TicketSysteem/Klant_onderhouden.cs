using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSysteem
{
    public partial class Klant_onderhouden : Form
    {
        public Klant_onderhouden()
        {
            InitializeComponent();
            pnlfilter.Hide();
            PreLoad();
        }

        private void PreLoad()
        {
            // loading status from site
            klantOnderhoudenToolStripMenuItem.BackColor = Color.LightGray;
            lbloutputdgvstatus.Text = "Klant onderhouden";
            lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
            lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
            lbloutputpagina.Text = lbloutputpagina.Text + " Klant onderhouden";
            OnderhoudenLoad();
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            Homepage Redirect = new Homepage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            Gegevens.klantnummer = 1;
            Klant_maken Redirect = new Klant_maken();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            eventpage Redirect = new eventpage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void faqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            Faq Redirect = new Faq();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            Login Redirect = new Login();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Stop();
            Gegevens.klantnummer = 2;
            DataRowView result = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            Gegevens.onderhoudendata = result;
            Hide();
            Close();
            Klant_maken Redirect = new Klant_maken();
            Redirect.ShowDialog();
        }

        private void cbfilterbar_CheckedChanged(object sender, EventArgs e)
        {
            // when filter is checked
            if (cbfilterbar.Checked == true)
            {
                pnlfilter.Show();
                cmbfilter.Text = "naam";
                cmbfilter.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                PreLoad();
                pnlfilter.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // when text changes it filters
            filterendoen();
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sorteerfilter
            switch (cmbfilter.Text)
            {
                case "naam":
                    Gegevens.Sorterenfilter = "naam";
                    textBox1.Clear();
                    break;

                case "address":
                    Gegevens.Sorterenfilter = "addres";
                    textBox1.Clear();
                    break;

                case "zipcode":
                    Gegevens.Sorterenfilter = "zipcode";
                    textBox1.Clear();
                    break;

                case "email":
                    Gegevens.Sorterenfilter = "email";
                    textBox1.Clear();
                    break;

                case "city":
                    Gegevens.Sorterenfilter = "city";
                    textBox1.Clear();
                    break;

                case "phonenumber":
                    Gegevens.Sorterenfilter = "phonenumber";
                    textBox1.Clear();
                    break;

                default:
                    Gegevens.Sorterenfilter = " ";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // everytime timer ticks it refreshes
            if (cbfilterbar.Checked == true)
            {
                filterendoen();
            }
            else
            {
                OnderhoudenLoad();
            }
        }

        private void filterendoen()
        {
            // filtering
            if (Gegevens.Sorterenfilter == " ")
            {
                MessageBox.Show("Please fill in the filter category");
                textBox1.Clear();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    Connection.conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Queries.onderhoudLoad +
                                                                " WHERE " + Gegevens.Sorterenfilter + " LIKE '%" + textBox1.Text + "%';", Connection.conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    Connection.conn.Close();
                }
            }
        }

        private void OnderhoudenLoad()
        {
            // loading datagridview 
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                Connection.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Queries.onderhoudLoad, Connection.conn);
                DataTable table = new DataTable();
                Connection.conn.Close();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void TimerAfkChecker_Tick(object sender, EventArgs e)
        {
            // afk timer checker
            Hide();
            Close();
            TimerAfkChecker.Stop();
            MessageBox.Show("You were AFK and have been sent back to the login page");
            Login redirect = new Login();
            redirect.ShowDialog();
        }

        private void Klant_onderhouden_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void Klant_onderhouden_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void cbfilterbar_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void cmbfilter_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
            TimerDataRefresh.Stop();
            TimerDataRefresh.Start();
        }
    }
}
