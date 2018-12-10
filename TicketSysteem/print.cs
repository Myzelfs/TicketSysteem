using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSysteem
{
    public partial class print : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();

        public print()
        {
            InitializeComponent();
            Loads();
        }

        private void print_Load(object sender, EventArgs e)
        {

        }

        private void lbloutputCreated_Click(object sender, EventArgs e)
        {

        }
        private void Loads()
        {
            if (Gegevens.Ticketpagina == 5)
            {
                lbloutputCreated.Text = Gegevens.DT_created.ToString();
                lbloutputsub.Text = Gegevens.subjevent;
                lbloutputticket.Text = Gegevens.eventdata[0].ToString();
                lbloutputstat.Text = Gegevens.eventdata[4].ToString();
                lbloutputprio.Text = Gegevens.eventdata[3].ToString();
                lbloutputdescr.Text = Gegevens.descr;
            }
            else
            {
                lbloutputdescr.Text = Gegevens.descr;
                lbloutputCreated.Text = Gegevens.DT_created.ToString();
                lbloutputsub.Text = Gegevens.data[1].ToString();
                lbloutputstat.Text = Gegevens.data[3].ToString();
                lbloutputprio.Text = Gegevens.data[4].ToString();
                lbloutputticket.Text = Gegevens.data[0].ToString();
            }
        }

        private async void printen()
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            await CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;

        private async Task CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(Object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnprinten_Click(object sender, EventArgs e)
        {
            btnprinten.Hide();
            btnterug.Hide();
            printen();
            Thread.Sleep(1000);
            Ticket_aanmaken lol = new Ticket_aanmaken();
            Hide();
            Close();
            lol.ShowDialog();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            Ticket_aanmaken lol = new Ticket_aanmaken();
            Hide();
            Close();
            lol.ShowDialog();
        }
    }
}
