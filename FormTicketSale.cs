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
    public partial class FormTicketSale : Form
    {
        private Button[] _seats;
        public static int _passengerid;
        private int _selectedDCityId;
        private int _selectedACityId;
        private int _selectedBusId;
        private DateTime _selectedDate;

        public FormTicketSale()
        {
            _seats = new Button[12];
            InitializeComponent();

            _selectedDate = DateTime.Today;
        }

        BusModel db = new BusModel();
        Trip trip;

        private void LoadSeats()
        {
            pSeats.Controls.Clear();

            if (_selectedACityId < 1 || _selectedBusId < 1 || _selectedDCityId < 1 || _selectedDate == null)
                return;

            //if (pSeats != null && pSeats.Controls.Count != 0)
            //{
            //    pSeats.Controls.Clear();
            //}
            int locX = 0, locY = 0;
            int seatNumber = 9;
            int buttonSize = 30;

            var trip = db.Trips.FirstOrDefault(x => x.DepartureCity.Id == _selectedDCityId && x.ArrivalCity.Id == _selectedACityId && x.DepartureTime == _selectedDate && x.Bus.Id == _selectedBusId);

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {

                    var buttonSeat = new Button
                    {
                        Text = seatNumber.ToString(),
                        Tag = seatNumber,
                        Location = new Point(locX, locY),
                        Size = new Size(buttonSize, buttonSize),
                        Name = seatNumber.ToString()
                    };


                    pSeats.Controls.Add(buttonSeat);
                    locY += buttonSeat.Size.Height;
                    if (y == 1)
                    {
                        locY += buttonSeat.Size.Height;
                    }

                    buttonSeat.Click += new EventHandler(buttonSeat_Click);
                    seatNumber++;
                }

                seatNumber -= 8;
                locY = 0;
                locX += buttonSize;
            }

            if (trip != null)
            {
                var tripPassengers = db.TripPassengerInfos.Where(t => t.Trip.Id == trip.Id).ToList();
                foreach (var tripPassenger in tripPassengers)
                {
                    Control button = pSeats.Controls[tripPassenger.RezervedSeat.ToString()];
                    button.Enabled = false;
                    button.BackColor = Color.Red;
                }
            }

        }

        private void buttonSeat_Click(object sender, EventArgs e)
        {
            Record(sender);



        }
        private void Record(object sender)
        {
            FormPassenger formPassenger = new FormPassenger();
            if (formPassenger.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = Color.Red;
                ((Button)sender).Enabled = false;
            }

            var trip = db.Trips.FirstOrDefault(x => x.DepartureCity.Id == _selectedDCityId && x.ArrivalCity.Id == _selectedACityId && x.DepartureTime == _selectedDate && x.Bus.Id == _selectedBusId);
            if (trip == null)
            {
                trip = new Trip();
                trip.DepartureTime = dateTimePickerDeperature.Value.Date;
                //.ArrivalTime = dateTimePickerArrival.Value;
                trip.DepartureCity = db.Cities.Find(cBDepartureCities.SelectedValue);
                trip.ArrivalCity = db.Cities.Find(cBArrivalCities.SelectedValue);
                trip.Bus = db.Buses.Find(cBBuses.SelectedValue);
                db.Trips.Add(trip);
                db.SaveChanges();


            }
            TripPassengerInfo tdp = new TripPassengerInfo();
            tdp.Trip = trip;
            tdp.Passenger = db.Passengers.Find(formPassenger.id);
            tdp.RezervedSeat = ((Button)sender).Text;
            db.TripPassengerInfos.Add(tdp);
            db.SaveChanges();
        }

        private void FormTicketSale_Load(object sender, EventArgs e)
        {

            ComboDepartureLists();
            LoadSeats();
            BusesLists();
        }
        private void Listele()
        {
            var list = db.Buses.Select(x => new
            {
                x.Name
            }).ToList();
        }

        private void ComboDepartureLists()
        {
            var list = db.Cities.Select(x => new
            {
                x.Name,
                x.Id
            }).OrderBy(x => x.Name).ToList();
            cBDepartureCities.DisplayMember = "Name";
            cBDepartureCities.ValueMember = "Id";
            cBDepartureCities.DataSource = list;

        }


        private void ComboArrivalLists()
        {
            var list = db.Cities.Select(x => new
            {
                x.Name,
                x.Id
            }).Where(x => x.Id != (_selectedDCityId)).OrderBy(x => x.Name).ToList();
            cBArrivalCities.DisplayMember = "Name";
            cBArrivalCities.ValueMember = "Id";
            cBArrivalCities.DataSource = list;
        }

        private void cBDepartureCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBDepartureCities.SelectedIndex == -1)
                return;

            _selectedDCityId = (int)(cBDepartureCities.SelectedValue);
            string z = _selectedDCityId.ToString();
            ComboArrivalLists();
            LoadSeats();
        }

        private void CBArrivalCities_ValueMemberChanged(object sender, EventArgs e)
        {
            ComboArrivalLists();
        }

        private void BusesLists()
        {
            cBBuses.DisplayMember = "PlateNumber";
            cBBuses.ValueMember = "Id";
            cBBuses.DataSource = db.Buses.ToList();

        }

        private void cBBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedBusId = (int)cBBuses.SelectedValue;

            label6.Text = cBBuses.SelectedValue.ToString();
            switch (cBBuses.SelectedIndex)
            {
                case 0:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    break;
                case 1:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    break;
                case 2:
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    break;
            }

            LoadSeats();
        }



        private void pSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pSeats_Click(object sender, EventArgs e)
        {

        }

        private void cBArrivalCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedACityId = (int)cBArrivalCities.SelectedValue;
            LoadSeats();
        }

        private void dateTimePickerArrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDeperature_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = dateTimePickerDeperature.Value.Date;
            LoadSeats();
        }
    }
}
