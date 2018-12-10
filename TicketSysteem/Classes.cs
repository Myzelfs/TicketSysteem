using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TicketSysteem
{
    public class Classes
    {
        public bool CheckDbConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.nl/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    public static partial class regex
    {
        // regex
        public static string reg_username = @"^(?=[a-zA-Z])[-\w.\s*]{0,23}([a-zA-Z\d]|(?<![-.])_)$";
        // Kan gebruikt worden voor password : ^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$  1 lower case , 1 upper case , +12 char , one nummeric , special char
        public static string reg_password = @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$";
        public static string reg_number = @"^[0-9]*$";
        public static string reg_email = @"^[a-z|0-9|A-Z]*([_][a-z|0-9|A-Z]+)*([.][a-z|0-9|A-Z]+)*([.][a-z|0-9|A-Z]+)*(([_][a-z|0-9|A-Z]+)*)?@[a-z][a-z|0-9|A-Z]*\.([a-z][a-z|0-9|A-Z]*(\.[a-z][a-z|0-9|A-Z]*)?)$";
        public static string reg_zipcode = @"^[1-9][0-9]{3}\s?([a-zA-Z]{2})?$";
    }

    public static class Connection
    {
        // connection string en connectie
        public static string connString = @"Data Source=AH-DB\PASSQL;Initial Catalog=Prj-Ticket2018;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(@"Data Source=AH-DB\PASSQL;Initial Catalog=Prj-Ticket2018;Integrated Security=True");
    }
    public static class Gegevens
    {
        // afvangen ID's van inloggen
        public static int ID { get; set; }
        public static string Username { get; set; }
        public static string Naam { get; set; }
        public static int Level_ID { get; set; }

        // het sorteren afvangen
        public static string Sorterenfilter { get; set; }

        //cijfertjes voor perspectief veranderen
        public static int Ticketpagina { get; set; }

        //data opslaan uit datagridview in arrays
        public static DataRowView data { get; set; }

        //gegevens die bij ticket zijn aangemaakt ophalen
        public static string descr { get; set; }
        public static DateTime DT_created { get; set; }
        public static int prioUpdate { get; set; }
        public static int StatUpdate { get; set; }

        //informatie al kom je bij tickets via event
        public static DataRowView eventdata { get; set; }
        public static string subjevent { get; set; }

        //cijfertjes voor klantenaanmaken / inzien
        public static int klantnummer { get; set; }
        public static int levelcijfer { get; set; }
        public static DataRowView klantdata { get; set; }

        //extra dingen voor klant onderhouden
        public static DataRowView onderhoudendata { get; set; }
        public static string passwordedit { get; set; }
        public static string usernameedit { get; set; }
        public static int level_IDedit { get; set; }

        //events uitvouwen op de ticket pagina
        public static DataRowView EventdataTickets { get; set; }
    }
    public static class Queries
    {
        public static string HomeTickets = "SELECT T.ID," +
                                                  "T.subj AS Subject, " +
                                                  "T.DT_Created AS Datum_Created, " +
                                                  "S.Stat_desc AS Status, P.Prio_desc AS Priority " +
                                           "FROM Ticketdb AS T " +
                                                  "INNER JOIN [status] AS S ON T.status_ID = S.id " +
                                                  "INNER JOIN prioriteit AS P ON T.prio_ID = P.id";

        public static string EventTicketLoad = "SELECT answer," +
                                                      "timestamp," +
                                                      "naam " +
                                               "FROM reply AS R " +
                                                      "INNER JOIN client AS C ON R.client_id = C.ID " +
                                               "WHERE ticket_id = ";

        public static string onderhoudLoad = "SELECT ID, " +
                                                    "naam, " +
                                                    "addres, " +
                                                    "zipcode, " +
                                                    "email, " +
                                                    "city, " +
                                                    "phonenumber " +
                                             "FROM client";

        public static string Eventpagina = "SELECT R.ticket_ID, " +
                                                  "R.answer," +
                                                  "R.[timestamp], " +
                                                  "P.Prio_desc AS Priority, " +
                                                  "S.Stat_desc AS Status " +
                                           "FROM Ticketdb AS T " +
                                                  "INNER JOIN reply AS R ON R.ticket_id = T.ID " +
                                                  "INNER JOIN prioriteit AS P ON T.prio_ID = P.id " +
                                                  "INNER JOIN [Status] AS S ON T.status_ID = S.id " +
                                           "WHERE T.admin_ID = ";

        public static string OrderbyDT = " ORDER BY T.DT_Created DESC;";
    }

    public static class FUTekst
    {
        public static string Sure = "Are you sure?";
        public static string Exit = "If you exit now your progress wont be saved";
    }
}
