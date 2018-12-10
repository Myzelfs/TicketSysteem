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
    public partial class Event_Inzien : Form
    {
        public Event_Inzien()
        {
            InitializeComponent();
            Invullen();
            Disable();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invullen()
        {
            // filling in information in the textboxes
            txbEventTekst.Text = Gegevens.EventdataTickets[0].ToString();
            txbDateCrea.Text = Gegevens.EventdataTickets[1].ToString();
            txbname.Text = Gegevens.EventdataTickets[2].ToString();
            txbprioriteit.Text = Gegevens.data[4].ToString();
            txbstatus.Text = Gegevens.data[3].ToString();
            txbticketSub.Text = Gegevens.data[1].ToString();
        }

        private void Disable()
        {
            // disabling all textboxes
            txbname.Enabled = false;
            txbprioriteit.Enabled = false;
            txbstatus.Enabled = false;
            txbticketSub.Enabled = false;
            txbEventTekst.Enabled = false;
            txbDateCrea.Enabled = false;
        }
    }
}
