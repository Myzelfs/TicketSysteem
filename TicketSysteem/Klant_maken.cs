using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSysteem
{
    public partial class Klant_maken : Form
    {
        // Klant ID
        // 1 = making new client
        // 2 = editing a client
        public Klant_maken()
        {
            InitializeComponent();
            lbloutputnaam.Text = lbloutputnaam.Text + " " + Gegevens.Naam;
            lbloutputlevel.Text = lbloutputlevel.Text + " Admin";
        }
               
        private void Klant_maken_Load(object sender, EventArgs e)
        {
            // perspective load
            if (Gegevens.klantnummer == 1)
            {
                rdbclient.Checked = true;
                btnonderhouden.Hide();
                lbloutputpagina.Text = lbloutputpagina.Text + " Klant Aanmaken";
                lbloutputdgvstatus.Text = "Klant aanmaken";
                klantAanmakenToolStripMenuItem.BackColor = Color.LightGray; 
            }
            else
            {
                // client ID 2
                ExtraLoad();

                lbloutputpagina.Text = lbloutputpagina.Text + " Klant Onderhouden";
                lbloutputdgvstatus.Text = "Klant onderhouden";
                klantOnderhoudenToolStripMenuItem.BackColor = Color.LightGray;

                txbnaam.Text = Gegevens.onderhoudendata[1].ToString();
                txbadress.Text = Gegevens.onderhoudendata[2].ToString();
                txbzipcode.Text = Gegevens.onderhoudendata[3].ToString();
                txbemail.Text = Gegevens.onderhoudendata[4].ToString();
                txbcity.Text = Gegevens.onderhoudendata[5].ToString();
                txbphone.Text = Gegevens.onderhoudendata[6].ToString();

                txbusername.Text = Gegevens.usernameedit;
                txbpassword.Text = Gegevens.passwordedit;

                if (Gegevens.level_IDedit == 1)
                {
                    rdbclient.Checked = true;
                }
                else if (Gegevens.level_IDedit == 2)
                {
                    rdbadmin.Checked = true;
                }
                else
                {
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // checking all things
            RadioCheck();
            ControleRegex();
        }

        private void ExtraLoad()
        {
            // loading extra info
            using (SqlConnection connection = new SqlConnection(Connection.connString))
            {
                Connection.conn.Open();
                SqlCommand extraload = new SqlCommand("SELECT level_ID, username, passw FROM client WHERE ID = " + Gegevens.onderhoudendata[0] + ";", Connection.conn);
                using (SqlDataReader reader = extraload.ExecuteReader())
                {
                    int Level_ID = reader.GetOrdinal("level_ID");
                    int username = reader.GetOrdinal("username");
                    int passw = reader.GetOrdinal("passw");
                    while (reader.Read())
                    {
                        Gegevens.level_IDedit = reader.GetInt32(Level_ID);
                        Gegevens.usernameedit = reader.GetString(username);
                        Gegevens.passwordedit = reader.GetString(passw);
                    }
                    Connection.conn.Close();
                }
            }
        }

        private void RadioCheck()
        {
            // loading buttons
            if (rdbadmin.Checked == true)
            {
                Gegevens.levelcijfer = 2;
            }
            else if (rdbclient.Checked == true)
            {
                Gegevens.levelcijfer = 1;
            }
        }
        private void ControleRegex()
        {
            // regex controle
            string naam = txbnaam.Text;
            string adress = txbadress.Text;
            string zipcode = txbzipcode.Text;
            string email = txbemail.Text;
            string City = txbcity.Text;
            string phone = txbphone.Text;
            string username = txbusername.Text;
            string password = txbpassword.Text;

            Regex checken = new Regex(regex.reg_username);
            Regex checken2 = new Regex(regex.reg_number);
            Regex checken3 = new Regex(regex.reg_email);

            if (checken.IsMatch(naam))
            {
                if (checken.IsMatch(adress))
                {
                    if (checken3.IsMatch(email))
                    {
                        if (checken.IsMatch(City))
                        {
                            if (checken.IsMatch(username))
                            {
                                if (checken.IsMatch(password))
                                {
                                    if (checken2.IsMatch(phone))
                                    {
                                        if (rdbadmin.Checked == true)
                                        {
                                            Gegevens.levelcijfer = 2;
                                            InsertUpdate();
                                        }
                                        else if (rdbclient.Checked == true)
                                        {
                                            Gegevens.levelcijfer = 1;
                                            InsertUpdate();
                                        }
                                        else
                                        {
                                            lbloutput.Text = "Please fill in a vallid level";
                                        }
                                    }
                                    else
                                    {
                                        lbloutput.Text = "Your phonenumber contains invallid characters";
                                        txbphone.Clear();
                                        txbphone.Focus();
                                    }
                                }
                                else
                                {
                                    lbloutput.Text = "Your password contains invallid characters";
                                    txbpassword.Clear();
                                    txbpassword.Focus();
                                }
                            }
                            else
                            {
                                lbloutput.Text = "Your username contains invallid characters";
                                txbusername.Clear();
                                txbusername.Focus();
                            }
                        }
                        else
                        {
                            lbloutput.Text = "Your city contains invallid characters";
                            txbcity.Clear();
                            txbcity.Focus();
                        }
                    }
                    else
                    {
                        lbloutput.Text = "Your email contains invallid characters";
                        txbemail.Clear();
                        txbemail.Focus();
                    }
                }
                else
                {
                    lbloutput.Text = "Your address contains invallid characters";
                    txbadress.Clear();
                    txbadress.Focus();
                }
            }
            else
            {
                lbloutput.Text = "Your naam contains invallid characters";
                txbnaam.Clear();
                txbnaam.Focus();
            }
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Homepage Redirect = new Homepage();
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
                Klant_onderhouden Redirect = new Klant_onderhouden();
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
                Faq Redirect = new Faq();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Login Redirect = new Login();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void klantAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Gegevens.klantnummer == 2)
            {
                DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    Gegevens.klantnummer = 1;
                    Klant_maken Redirect = new Klant_maken();
                    Hide();
                    Close();
                    Redirect.ShowDialog();
                }
            }
        }

        private void btnonderhouden_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(FUTekst.Exit, FUTekst.Sure, MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Gegevens.klantnummer = 1;
                Klant_onderhouden Redirect = new Klant_onderhouden();
                Hide();
                Close();
                Redirect.ShowDialog();
            }
        }

        private void InsertUpdate()
        {
            // making query and executing them to insert or update a client
            string query = "";

            if (Gegevens.klantnummer == 2)
            {
                query = "UPDATE client SET " +
                               "naam = '" + txbnaam.Text + "', " +
                               "addres = '" + txbadress.Text + "', " +
                               "zipcode = '" + txbzipcode.Text + "', " +
                               "email = '" + txbemail.Text + "', " +
                               "city = '" + txbcity.Text +
                             "',phonenumber = '" + txbphone.Text + "', " +
                               "level_ID = '" + Gegevens.levelcijfer + "', " +
                               "username = '" + txbusername.Text + "', " +
                               "passw = '" + txbpassword.Text + "' " +
                         "WHERE ID = " + Gegevens.onderhoudendata[0] + ";";
            }
            else if (Gegevens.klantnummer == 1)
            {
                Connection.conn.Open();
                SqlCommand login = new SqlCommand(@"SELECT naam FROM client 
                                                    WHERE username = '" + txbusername.Text + "' AND passw = '" + txbpassword.Text + "'", Connection.conn);
                SqlDataReader reader = login.ExecuteReader();

                // rows lezen en redirecten
                if (reader.HasRows)
                {
                    Connection.conn.Close();
                    lbloutput.Text = "Deze combinatie van wachtwoord en username is helaas niet mogelijk";
                }
                else
                {
                    Connection.conn.Close();
                    query = "INSERT INTO client (naam, addres, zipcode, email, city, phonenumber, level_ID, username, passw) " +
                        "VALUES ('" + txbnaam.Text + "','" + txbadress.Text + "','" + txbzipcode.Text + "','" + txbemail.Text + "','" + txbcity.Text +
                       "','" + txbphone.Text + "','" + Gegevens.levelcijfer + "','" + txbusername.Text + "','" + txbpassword.Text + "');";

                }
            }

            Connection.conn.Open();
            SqlCommand command = new SqlCommand(query, Connection.conn);
            command.ExecuteNonQuery();
            Connection.conn.Close();

            Hide();
            Close();
            Klant_onderhouden Redirect = new Klant_onderhouden();
            Redirect.ShowDialog();
        }

        private void txbpassword_MouseEnter(object sender, EventArgs e)
        {
            // making password visible
            txbpassword.PasswordChar = '\0';
        }

        private void txbpassword_MouseLeave(object sender, EventArgs e)
        {
            // making password invisible
            txbpassword.PasswordChar = '*';
        }
    }
}
