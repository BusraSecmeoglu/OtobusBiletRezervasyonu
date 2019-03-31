using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletRezervasyonu
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void bTicket_Click(object sender, EventArgs e)
        {
            FormTicketSale formTicketSale = new FormTicketSale();
            formTicketSale.Show();
        }

        private void bControl_Click(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl();
            formControl.Show();
        }

        private void bVehicleControl_Click(object sender, EventArgs e)
        {
            FormTracking formTracking = new FormTracking();
            formTracking.Show();
        }
    }
}
