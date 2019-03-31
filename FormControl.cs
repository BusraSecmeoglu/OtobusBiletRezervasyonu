using OtobusBiletRezervasyonu.Entities;
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
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();

        Bus bus;

        private void FormControl_Load(object sender, EventArgs e)
        {
            LoadControl();
           
        }

        private void LoadControl()
        {

            foreach (var item in db.TripPassengerInfos)
            {

                lBNameSurname.Items.Add(item.Passenger.FirstName + item.Passenger.LastName );
                lBPlateNumber.Items.Add(item.Trip.Bus.PlateNumber);
                lBSeatNumber.Items.Add(item.RezervedSeat);
                lBTrip.Items.Add(item.Trip.DepartureCity.Name + "->" + item.Trip.ArrivalCity.Name);
            }
        }
        private void lBPlateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
