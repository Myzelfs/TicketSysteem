using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSysteem
{
    // ticketpagina id's
    // 1 = New ticket
    // 2 = client opens own ticket
    // 3 = Admin takes ticket to be his own
    // 4 = Admin changes his ticket
    // 5 = Admin comes from the event page

    public partial class Ticket_aanmaken : Form
    {
        public Ticket_aanmaken()
        {
            InitializeComponent();
            Perspectief();
            TicketCijfer();
            EventLoad();
            btnprint.Hide();
        }

        private void EventLoad()
        {
            // loading event grid
            if (Gegevens.Ticketpagina == 5)
            { 
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    Connection.conn.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(Queries.EventTicketLoad + Gegevens.eventdata[0] + " ORDER BY timestamp DESC;", Connection.conn);
                    DataTable Table = new DataTable();
                    Adapter.Fill(Table);
                    dgvevent.DataSource = Table;
                    Connection.conn.Close();
                }
            }
            else if (Gegevens.Ticketpagina == 1)
            {
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Connection.connString))
                {
                    Connection.conn.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(Queries.EventTicketLoad + Gegevens.data[0] + " ORDER BY timestamp DESC;", Connection.conn);
                    DataTable Table = new DataTable();
                    Adapter.Fill(Table);
                    dgvevent.DataSource = Table;
                    Connection.conn.Close();
                }
            }
        }

        private void TicketCijfer()
        {
            // changing perspective
            switch (Gegevens.Ticketpagina)
            {
                case 1:
                    btnprint.Hide();
                    pnlevent.Hide();
                    lbloutputdgvstatus.Text = "New Tickets";
                    lbloutputpagina.Text = lbloutputpagina.Text + " New Tickets";
                    pnlextrainfo.Hide();
                    label5.Hide();
                    txbDateCreated.Hide();
                    break;

                case 2:
                    btnprint.Hide();
                    ExtraFetch();
                    lbloutputdgvstatus.Text = "Eigen Ticket";
                    lbloutputpagina.Text = lbloutputpagina.Text + " Eigen tickets";
                    txbmaaksubj.Text = Gegevens.data[1].ToString();
                    txbmaaksubj.Enabled = false;
                    txbmaakdesc.Text = Gegevens.descr;
                    txbDateCreated.Text = Gegevens.DT_created.ToString();
                    txbDateCreated.Enabled = false;
                    cmbprioriteit.Text = Gegevens.data[4].ToString();
                    cmbprioriteit.Enabled = false;
                    cmbstatus.Text = Gegevens.data[3].ToString();
                    cmbstatus.Enabled = false;
                    break;

                case 3:
                    btnprint.Hide();
                    pnlevent.Hide();
                    ExtraFetch();
                    lbloutputdgvstatus.Text = "Aannemen";
                    lbloutputpagina.Text = lbloutputpagina.Text + " Ticket aannemen";
                    btnsave.Text = "Aannemen";
                    txbmaaksubj.Text = Gegevens.data[1].ToString();
                    txbmaaksubj.Enabled = false;
                    txbmaakdesc.Text = Gegevens.descr;
                    txbmaakdesc.Enabled = false;
                    txbDateCreated.Text = Gegevens.DT_created.ToString();
                    txbDateCreated.Enabled = false;
                    cmbprioriteit.Text = Gegevens.data[4].ToString();
                    cmbprioriteit.Enabled = false;
                    cmbstatus.Text = Gegevens.data[3].ToString();
                    cmbstatus.Enabled = false;
                    break;

                case 4:   
                    ExtraFetch();
                    lbloutputdgvstatus.Text = "inzien Ticket";
                    lbloutputpagina.Text = lbloutputpagina.Text + " Ticket inzien";
                    txbmaaksubj.Text = Gegevens.data[1].ToString();
                    txbmaaksubj.Enabled = false;
                    txbmaakdesc.Text = Gegevens.descr;
                    txbmaakdesc.Enabled = false;
                    txbDateCreated.Text = Gegevens.DT_created.ToString();
                    txbDateCreated.Enabled = false;
                    cmbprioriteit.Text = Gegevens.data[4].ToString();
                    cmbstatus.Text = Gegevens.data[3].ToString();
                    break;

                case 5:
                    EventFetch();
                    lbloutputdgvstatus.Text = "inzien Ticket";
                    lbloutputpagina.Text = lbloutputpagina.Text + " Ticket inzien";
                    txbmaaksubj.Text = Gegevens.subjevent;
                    txbmaaksubj.Enabled = false;
                    txbmaakdesc.Text = Gegevens.descr;
                    txbmaakdesc.Enabled = false;
                    txbDateCreated.Text = Gegevens.DT_created.ToString();
                    txbDateCreated.Enabled = false;
                    cmbprioriteit.Text = Gegevens.eventdata[3].ToString();
                    cmbstatus.Text = Gegevens.eventdata[4].ToString();
                    break;

                default:
                    break;
            }
        }

        private void EventFetch()
        {
            // extra information if you come from the event page
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                Connection.conn.Open();
                SqlCommand extraload = new SqlCommand(@"SELECT descript, subj, DT_created FROM Ticketdb WHERE ID = " + Gegevens.eventdata[0] + ";", Connection.conn);
                using (SqlDataReader reader = extraload.ExecuteReader())
                {
                    int descript = reader.GetOrdinal("descript");
                    int subject = reader.GetOrdinal("subj");
                    int admin = reader.GetOrdinal("DT_created");
                    while (reader.Read())
                    {
                        Gegevens.subjevent = reader.GetString(subject);
                        Gegevens.descr = reader.GetString(descript);
                        Gegevens.DT_created = reader.GetDateTime(admin);
                    }
                }
                Connection.conn.Close();
            }
        }

        private void ExtraFetch()
        {
            // extra information for 2/3/4
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                Connection.conn.Open();
                SqlCommand extraload = new SqlCommand(@"SELECT descript, DT_created FROM Ticketdb WHERE ID = " + Gegevens.data[0] + ";", Connection.conn);
                using (SqlDataReader reader = extraload.ExecuteReader())
                {
                    int descript = reader.GetOrdinal("descript");
                    int admin = reader.GetOrdinal("DT_created");
                    while (reader.Read())
                    {
                        Gegevens.descr = reader.GetString(descript);
                        Gegevens.DT_created = reader.GetDateTime(admin);
                    }
                }
                Connection.conn.Close();
            }
        }

        private void Perspectief()
        {
            //loading status
            lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;

            if (Gegevens.Level_ID == 2)
            {
                lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
            }
            else if (Gegevens.Level_ID == 1)
            {
                lbloutputlevel.Text = lbloutputlevel.Text + " Client";
                klantAanmakenToolStripMenuItem.Dispose();
                klantOnderhoudenToolStripMenuItem.Dispose();
                eventsToolStripMenuItem.Dispose();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //save button for all perspectives
            string query = "";

            switch (Gegevens.Ticketpagina)
            {
                case 1:
                   query = "INSERT INTO dbo.Ticketdb " +
                                              "(client_ID, subj, descript, status_ID, procent, DT_created, prio_ID, admin_ID) VALUES " +
                                              "('" + Gegevens.ID + "','" + txbmaaksubj.Text + "','" + txbmaakdesc.Text + "', '" + 1 + "'," + 0 +
                                                 ", GETDATE(), " + 5 + "," + 0 + ")";
                    break;

                case 2:
                    query = "UPDATE ticketdb SET descript = '" + txbmaakdesc.Text + "', DT_modified = GETDATE() " +
                                                                            "WHERE ID = " + Gegevens.data[0] + ";";
                    break;

                case 3:
                    btnsave.Text = "Ticket aannemen";
                    query = "UPDATE Ticketdb SET admin_ID = " + Gegevens.ID +
                                                                  " WHERE ID = " + Gegevens.data[0] + ";";
                    break;

                case 4:
                    query = "UPDATE Ticketdb SET prio_ID = " + Gegevens.prioUpdate + ", status_ID = " + Gegevens.StatUpdate +
                                                                      " WHERE ID = " + Gegevens.data[0] + ";";
                    break;

                case 5:
                    query = "UPDATE Ticketdb SET prio_ID = " + Gegevens.prioUpdate + ", status_ID = " + Gegevens.StatUpdate +
                                                                     " WHERE ID = " + Gegevens.eventdata[0] + ";";
                    break;
            }

            Connection.conn.Open();
            SqlCommand kaas = new SqlCommand(query, Connection.conn);
            kaas.ExecuteNonQuery();
            Connection.conn.Close();
            RedirectHome();
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //giving status a number so it is easier for inserting into database
            switch(cmbstatus.Text)
            {
                case "new":
                    Gegevens.StatUpdate = 1;
                    break;

                case "in progress":
                    Gegevens.StatUpdate = 2;
                    break;

                case "finished":
                    Gegevens.StatUpdate = 3;
                    break;

                default:
                    break;
            }
        }

        private void cmbprioriteit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //giving priority a number so it is easier for inserting into database
            switch (cmbprioriteit.Text)
            {
                case "low":
                    Gegevens.prioUpdate = 1;
                    break;

                case "medium":
                    Gegevens.prioUpdate = 2;
                    break;

                case "high":
                    Gegevens.prioUpdate = 3;
                    break;

                case "immediatly":
                    Gegevens.prioUpdate = 4;
                    break;

                case "undetermined":
                    Gegevens.prioUpdate = 5;
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                Login Redirect = new Login();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                eventpage Redirect = new eventpage();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void faqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                Faq Redirect = new Faq();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void klantOnderhoudenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                Klant_onderhouden Redirect = new Klant_onderhouden();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                Gegevens.klantnummer = 1;
                Klant_maken Redirect = new Klant_maken();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                TimerDataRefresh.Stop();
                Homepage Redirect = new Homepage();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void ControleRegex()
        {
            // Regex controle
            Regex checken = new Regex(regex.reg_username);
            if (checken.IsMatch(txbmaaksubj.Text))
            {
                if (checken.IsMatch(txbmaakdesc.Text))
                {
                }
                else
                {
                    MessageBox.Show("Your Description uses invallid characters");
                    txbmaakdesc.Clear();
                    txbmaakdesc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Your subject uses invallid characters");
                txbmaaksubj.Clear();
                txbmaaksubj.Focus();
            }
        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            // Uploading event information after regex controle
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Please fill in the event textbox");
            }
            else
            {
                string query = "";

                if (Gegevens.Ticketpagina == 5)
                {
                    query = "INSERT INTO reply " +
                                     "(ticket_id, answer, timestamp, client_id) " +
                                     "VALUES " +
                                     "(" + Gegevens.eventdata[0] + ",'" + textBox1.Text + "',GETDATE() ," + Gegevens.ID + ");";
                }
                else
                {
                    query = "INSERT INTO reply " +
                                    "(ticket_id, answer, timestamp, client_id) " +
                                    "VALUES (" + Gegevens.data[0] + ",'" + textBox1.Text + "',GETDATE() ," + Gegevens.ID + ");";
                }

                Connection.conn.Open();
                SqlCommand Command = new SqlCommand(query, Connection.conn);
                Command.ExecuteNonQuery();
                Connection.conn.Close();

                Ticket_aanmaken kaas = new Ticket_aanmaken();
                Hide();
                kaas.ShowDialog();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            TimerDataRefresh.Stop();
            print lol = new print();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvevent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView result = (DataRowView)dgvevent.CurrentRow.DataBoundItem;
            Gegevens.EventdataTickets = result;
            Event_Inzien Redirect = new Event_Inzien();
            Redirect.ShowDialog();
        }

        private void dgvevent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RedirectHome()
        {
            TimerDataRefresh.Stop();
            Homepage Redirect = new Homepage();
            Hide();
            Close();
            Redirect.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // event reload after timer ticks
            EventLoad();
        }
    }
}
