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
    public partial class eventpage : Form
    {
        public eventpage()
        {
            InitializeComponent();
            eventsToolStripMenuItem.BackColor = Color.LightGray;
            EventsLoad();
            pnlfilter.Hide();
            TimerDataRefresh.Start();
        }

        private void eventpage_Load(object sender, EventArgs e)
        {
            // changing status and page
            lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
            lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
            lbloutputpagina.Text = lbloutputpagina.Text + " EventPagina";
            lbloutputdgvstatus.Text = "Events";
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Homepage Redirect = new Homepage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void EventsLoad()
        {
            // loading events on the page
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                Connection.conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Queries.Eventpagina + Gegevens.ID + " ORDER BY R.[timestamp] DESC;", Connection.conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvevent.DataSource = table;
                Connection.conn.Close();
            }
        }

        private void cbfilterbar_CheckedChanged(object sender, EventArgs e)
        {
            // filtering for events when checkbox is checked
            if (cbfilterbar.Checked == true)
            {
                pnlfilter.Show();
                cmbfilter.Text = "answer";
                cmbfilter.DropDownStyle = ComboBoxStyle.DropDownList;
                txbfilter.Clear();
            }
            else
            {
                EventsLoad();
                pnlfilter.Hide();
            }
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when text changes it clears and hides the rest
            switch (cmbfilter.Text)
            {
                case "Priority":
                    Gegevens.Sorterenfilter = "P.Prio_desc";
                    txbfilter.Clear();
                    cmbStatus.Text = "";
                    cmbPrioriteit.Show();
                    txbfilter.Hide();
                    cmbStatus.Hide();
                    break;

                case "Status":
                    Gegevens.Sorterenfilter = "S.Stat_desc";
                    cmbPrioriteit.Text = "";
                    txbfilter.Clear();
                    cmbStatus.Show();
                    txbfilter.Hide();
                    cmbPrioriteit.Hide();
                    break;

                case "answer":
                    Gegevens.Sorterenfilter = "R.answer";
                    cmbPrioriteit.Text = "";
                    cmbStatus.Text = "";
                    txbfilter.Clear();
                    txbfilter.Show();
                    cmbStatus.Hide();
                    cmbPrioriteit.Hide();
                    break;

                default:
                    Gegevens.Sorterenfilter = " ";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // filtering when text changes
            filterdoen();
        }

        private void dgvevent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Gegevens.Ticketpagina = 5;
            DataRowView result = (DataRowView)dgvevent.CurrentRow.DataBoundItem;
            Gegevens.eventdata = result;
            Hide();
            Close();
            Ticket_aanmaken Redirect = new Ticket_aanmaken();
            Redirect.ShowDialog();
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Gegevens.klantnummer = 1;
            Klant_maken Redirect = new Klant_maken();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void klantOnderhoudenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Klant_onderhouden Redirect = new Klant_onderhouden();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void faqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Faq Redirect = new Faq();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerDataRefresh.Stop();
            Login Redirect = new Login();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void pnlfilter_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checkbox for when the text changes in status
            switch (cmbStatus.Text)
            {
                case "new":
                    txbfilter.Text = "new";
                    break;

                case "in progress":
                    txbfilter.Text = "in progress";
                    break;

                case "finished":
                    txbfilter.Text = "finished";
                    break;

                case "":
                    txbfilter.Text = "";
                    break;
            }
        }

        private void cmbPrioriteit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checkbox for when the text changes in prioriteit
            switch (cmbPrioriteit.Text)
            {
                case "low":
                    txbfilter.Text = "low";
                    break;

                case "medium":
                    txbfilter.Text = "medium";
                    break;

                case "high":
                    txbfilter.Text = "high";
                    break;

                case "immediatly":
                    txbfilter.Text = "immediatly";
                    break;

                case "undetermined":
                    txbfilter.Text = "undetermined";
                    break;

                case "":
                    txbfilter.Text = "";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // refreshing after tick
            if (cbfilterbar.Checked == true)
            {
                filterdoen();
            }
            else
            {
                EventsLoad();
            }
        }

        private void filterdoen()
        {
            // Filtering
            if (Gegevens.Sorterenfilter == " ")
            {
                MessageBox.Show("Please fill in the filter category");
                txbfilter.Clear();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    Connection.conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Queries.Eventpagina + Gegevens.ID + " AND " + Gegevens.Sorterenfilter +
                        " LIKE '%" + txbfilter.Text + "%' ORDER BY R.[timestamp] DESC;", Connection.conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvevent.DataSource = table;
                    Connection.conn.Close();
                }
            }
        }

        private void TimerAfkChecker_Tick(object sender, EventArgs e)
        {
            // afk timer
            Hide();
            Close();
            TimerAfkChecker.Stop();
            MessageBox.Show("You were AFK and have been sent back to the login page");
            Login redirect = new Login();
            redirect.ShowDialog();
        }

        private void eventpage_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void eventpage_MouseMove(object sender, MouseEventArgs e)
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

        private void cmbStatus_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void cmbPrioriteit_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void txbfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void txbfilter_Click(object sender, EventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void dgvevent_MouseMove(object sender, MouseEventArgs e)
        {
            TimerAfkChecker.Stop();
            TimerAfkChecker.Start();
        }

        private void dgvevent_Scroll(object sender, ScrollEventArgs e)
        {
            TimerDataRefresh.Stop();
            TimerDataRefresh.Start();
        }
    }
}
