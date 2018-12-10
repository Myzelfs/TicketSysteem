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
using System.Text.RegularExpressions;

namespace TicketSysteem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ActiveControl = Txbusername; //Starting instant in the username textbox
            lblOutput.Hide();
            Txbusername.Text = "Myzelf";
            Txbpassword.Text = "plopkoek33";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Checking connection
            OnlineStatus();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            // controlling on regular expressions
            string username = Txbusername.Text;
            string password = Txbpassword.Text;
            Regex checken = new Regex(regex.reg_username);
            Regex checken2 = new Regex(regex.reg_password);

            if (checken.IsMatch(username))
            {
                if (checken2.IsMatch(password))
                {
                    CheckLogin();
                }
                else
                {
                    lblOutput.Show();
                    lblOutput.Text = "Your password contains invallid characters";
                    Txbpassword.Clear();
                    Txbpassword.Focus();
                }
            }
            else
            {
                lblOutput.Show();
                lblOutput.Text = "Your username contains invallid characters";
                Txbusername.Clear();
                Txbusername.Focus();
            }
        }

        private void CheckLogin()
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                // fetching information from database
                Connection.conn.Open();
                SqlCommand login = new SqlCommand(@"SELECT username, ID, Level_ID, naam FROM client 
                                                    WHERE username = '" + Txbusername.Text + "' AND passw = '" + Txbpassword.Text + "'", Connection.conn);
                using (SqlDataReader reader = login.ExecuteReader())
                {
                    int ID = reader.GetOrdinal("ID");
                    int username = reader.GetOrdinal("username");
                    int naam = reader.GetOrdinal("naam");
                    int Level_ID = reader.GetOrdinal("Level_ID");
                    while (reader.Read())
                    {
                        //binding information to statics
                        Gegevens.ID = reader.GetInt32(ID);
                        Gegevens.Username = reader.GetString(username);
                        Gegevens.Naam = reader.GetString(naam);
                        Gegevens.Level_ID = reader.GetInt32(Level_ID);
                    }
                    // Reading rows and sending you to the right page
                    if (reader.HasRows)
                    {
                        Connection.conn.Close();
                        lblOutput.Show();
                        lblOutput.Text = "U bent succesfull ingelogd";
                        Hide();
                        Homepage Redirect = new Homepage();
                        Redirect.ShowDialog();
                    }
                    else
                    {
                        lblOutput.Show();
                        Connection.conn.Close();
                        lblOutput.Text = "Uw inloggegevens zijn fout , probeer opnieuw";
                    }
                }
            }
        }

        private void Txbusername_KeyDown(object sender, KeyEventArgs e)
        {
            // pressing login button if you press enter
            if (e.KeyCode == Keys.Enter)
            {
                Btnlogin.PerformClick();
            }
        }

        private void Txbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            // pressing login button if you press enter
            if (e.KeyCode == Keys.Enter)
            {
                Btnlogin.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void OnlineChecker_Tick(object sender, EventArgs e)
        {
            // checking online status every so often
            OnlineStatus();
        }

        private void OnlineStatus()
        {
            Classes connectie = new Classes();
            bool status = connectie.CheckDbConnection();

            if (status == false)
            {
                MessageBox.Show("Your connection to the database has been lost");
                Application.Exit();
            }
        }
    }
}
