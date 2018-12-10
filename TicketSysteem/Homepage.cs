using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;

namespace TicketSysteem
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            Perspective();
            MyTicketsLoad();
        }

        private void Perspective()
        {
            // Building a perspective for your account level
            switch (Gegevens.Level_ID)
            {
                case 1:
                    lbloutputlevel.Text = lbloutputlevel.Text + " Client";
                    klantAanmakenToolStripMenuItem.Dispose();
                    klantOnderhoudenToolStripMenuItem.Dispose();
                    eventsToolStripMenuItem.Dispose();
                    btnnewtickets.Show();
                    break;

                case 2:
                    btncreatetickets.Hide();
                    lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
                    btnnewtickets.Show();
                    break;
            }

            Gegevens.Sorterenfilter = " ";
            pnlfilter.Hide();
            lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
            homepageToolStripMenuItem.BackColor = Color.LightGray;
            lbloutputpagina.Text = lbloutputpagina.Text + " Homepage";
            btnyourtickets.Hide();
            lbloutputdgvstatus.Text = "My Tickets";
        }

        // Loading Your own tickets
        private void MyTicketsLoad()
        {
            string sql_Frontpage = "";

            switch (Gegevens.Level_ID)
            {
                case 1:
                    sql_Frontpage = Queries.HomeTickets + " WHERE T.client_ID = " + Gegevens.ID + Queries.OrderbyDT;
                    break;

                case 2:
                    sql_Frontpage = Queries.HomeTickets + " WHERE T.admin_ID = " + Gegevens.ID + Queries.OrderbyDT;
                    break;

                default:
                    MessageBox.Show("You have no vallid level to enter this page, Contact an Admin");
                    Application.Exit();
                    break;
            }

            //Execute query
            Connection.conn.Open();
            SqlDataAdapter MyTickets = new SqlDataAdapter(sql_Frontpage, Connection.conn);
            DataTable Loading = new DataTable();

            // Binding with the datagridview
            MyTickets.Fill(Loading);
            Dgvhome.DataSource = Loading;
            Connection.conn.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            Hide();
            Close();
            Login kaas = new Login();
            kaas.ShowDialog();
        }

        private void btnnewtickets_Click(object sender, EventArgs e)
        {
            NewTicketsLoad();
        }

        private void NewTicketsLoad()
        {
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                // Creating connection and Starting a query
                Connection.conn.Open();
                string sql_newtickets = Queries.HomeTickets + " WHERE T.admin_ID = 0" + Queries.OrderbyDT;
                SqlDataAdapter newtickets = new SqlDataAdapter(sql_newtickets, Connection.conn);
                DataTable Table = new DataTable();

                // Binding with the datagridview
                newtickets.Fill(Table);
                Dgvhome.DataSource = Table;
                Connection.conn.Close();

                //Changing perspective
                lbloutputdgvstatus.Text = "New Tickets";
                btnyourtickets.Show();
                btnnewtickets.Hide();
            }
        }
        private void btnyourtickets_Click(object sender, EventArgs e)
        {
            //Changing perspective
            MyTicketsLoad();
            btnyourtickets.Hide();
            btnnewtickets.Show();
            lbloutputdgvstatus.Text = "My Tickets";
        }

        private void cbfilter_CheckedChanged(object sender, EventArgs e)
        {
            // if you check the filtering checkbox
            if (cbfilter.Checked == true)
            {
                pnlfilter.Show();
                cbxfilter.Text = "Subject";
                cbxfilter.DropDownStyle = ComboBoxStyle.DropDownList;
                txbfilter.Clear();
            }
            else if (cbfilter.Checked == false)  
            {
                if (lbloutputdgvstatus.Text == "My Tickets")
                {
                    MyTicketsLoad();
                }
                else
                {
                    NewTicketsLoad();
                }
                pnlfilter.Hide();
            }
        }

        private void cbxfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when text changes it will clear the textbox and hide the rest
            switch (cbxfilter.Text)
            {
                case "Priority":
                    Gegevens.Sorterenfilter = "P.Prio_desc";
                    txbfilter.Clear();
                    cmbstatus.Text = "";
                    cmbPrioriteit.Show();
                    txbfilter.Hide();
                    cmbstatus.Hide();
                    break;

                case "Status":
                    Gegevens.Sorterenfilter = "S.Stat_desc";
                    cmbPrioriteit.Text = "";
                    txbfilter.Clear();
                    cmbstatus.Show();
                    txbfilter.Hide();
                    cmbPrioriteit.Hide();
                    break;

                case "Subject":
                    Gegevens.Sorterenfilter = "T.subj";
                    cmbPrioriteit.Text = "";
                    cmbstatus.Text = "";
                    txbfilter.Clear();
                    txbfilter.Show();
                    cmbstatus.Hide();
                    cmbPrioriteit.Hide();
                    break;

                default:
                    Gegevens.Sorterenfilter = " ";
                    break;
            }
        }

        private void txbfilter_TextChanged(object sender, EventArgs e)
        {
            filterendoen();
        }

        private void btncreatetickets_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            Gegevens.Ticketpagina = 1;
            Hide();
            Close();
            Ticket_aanmaken klok = new Ticket_aanmaken();
            klok.ShowDialog();
        }

        private void Dgvhome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (lbloutputdgvstatus.Text)
            {
                case "My Tickets":
                    if (Gegevens.Level_ID == 1)
                    {
                        Gegevens.Ticketpagina = 2;
                    }
                    else
                    {
                        Gegevens.Ticketpagina = 4;
                    }
                    break;

                case "New Tickets":
                    Gegevens.Ticketpagina = 3;
                    break;
            }
            AutoLogout.Stop();
            DataRowView result = (DataRowView)Dgvhome.CurrentRow.DataBoundItem;
            Gegevens.data = result;
            Hide();
            Close();
            Ticket_aanmaken Redirect = new Ticket_aanmaken();
            Redirect.ShowDialog();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            eventpage lol = new eventpage();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            Gegevens.klantnummer = 1;
            Klant_maken lol = new Klant_maken();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void klantOnderhoudenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            Klant_onderhouden lol = new Klant_onderhouden();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void faqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerDatagrid.Stop();
            AutoLogout.Stop();
            Faq lol = new Faq();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void cmbPrioriteit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox select prioriteit
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

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox select status
            switch (cmbstatus.Text)
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

        private void Timerdatagridrefresh_Tick(object sender, EventArgs e)
        {
            //Timer refreshes datagridviews
            if (cbfilter.Checked == true)
            {
                filterendoen();
            }
            else
            {
                if (lbloutputdgvstatus.Text == "My Tickets")
                {
                    MyTicketsLoad();
                }
                else
                {
                    NewTicketsLoad();
                }
            }
        }

        private void filterendoen()
        {
            // filtering the datagridviews
            string sql_Frontpage = "";

            switch (lbloutputdgvstatus.Text)
            {
                case "My Tickets":
                    if (Gegevens.Level_ID == 2)
                    {
                            sql_Frontpage = Queries.HomeTickets +
                                                    " WHERE T.admin_ID = " + Gegevens.ID +
                                                    " AND " + Gegevens.Sorterenfilter + " LIKE '%" + txbfilter.Text + "%'" + Queries.OrderbyDT;

                    }
                    else
                    {
                            sql_Frontpage = Queries.HomeTickets +
                                                    " WHERE T.client_ID = " + Gegevens.ID +
                                                    " AND " + Gegevens.Sorterenfilter + " LIKE '%" + txbfilter.Text + "%'" + Queries.OrderbyDT;
                    }
                    break;

                case "New Tickets":
                        sql_Frontpage = Queries.HomeTickets +
                                                " WHERE T.admin_ID = 0 " +
                                                "AND " + Gegevens.Sorterenfilter + " LIKE '%" + txbfilter.Text + "%'" + Queries.OrderbyDT;
                    break;
            }

            // Executing query
            Connection.conn.Open();
            SqlDataAdapter filterfrontpage = new SqlDataAdapter(sql_Frontpage, Connection.conn);
            DataTable filterload = new DataTable();

            // Binding with the datagridview
            filterfrontpage.Fill(filterload);
            Dgvhome.DataSource = filterload;
            Connection.conn.Close();
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void Homepage_MouseMove(object sender, MouseEventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void AutoLogout_Tick(object sender, EventArgs e)
        {
            // logging out after timer ticks
            Hide();
            this.Close();
            AutoLogout.Stop();
            MessageBox.Show("You were AFK and have been sent back to the login page.");
            Login redirect = new Login();
            redirect.ShowDialog();
        }

        private void cbfilter_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void cbxfilter_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void cmbstatus_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void cmbPrioriteit_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void txbfilter_Click(object sender, EventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void txbfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void Dgvhome_MouseMove(object sender, MouseEventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
        }

        private void Dgvhome_Scroll(object sender, ScrollEventArgs e)
        {
            AutoLogout.Stop();
            AutoLogout.Start();
            TimerDatagrid.Stop();
            TimerDatagrid.Start();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
