using OtobusBiletRezervasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletRezervasyonu
{
    public partial class FormTracking : Form
    {
        BusModel db = new BusModel();
        int _selectedBusId;
        int _selectedTripId;
        public FormTracking()
        {
            InitializeComponent();
            BusesLists();
        }

        private void BusesLists()
        {
            var list = db.Buses.Select(x => new
            {
                x.PlateNumber,
                x.Id
            }).OrderBy(x => x.PlateNumber).ToList();
            cbBuses.DisplayMember = "PlateNumber";
            cbBuses.ValueMember = "Id";
            cbBuses.DataSource = list;
        }

        private void cbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedBusId = (int)cbBuses.SelectedValue;
            cBTrip.Text = " ";
            _selectedTripId = 0;

            BringPassengerCount();


            cBTrip.DisplayMember = "CityNames";
            cBTrip.ValueMember = "Id";
            cBTrip.DataSource = db.Trips.Where(t => t.Bus.Id == _selectedBusId).ToList();

        }

        private void BringPassengerCount()
        {
            if (_selectedBusId < 1 || _selectedTripId < 1)
            {
                txtPersonNumber.Text = " 0";
                return;
            }
            int count = db.TripPassengerInfos.Count(tpi => tpi.Trip.Id == _selectedTripId);
            txtPersonNumber.Text = count.ToString();
        }

        private void cBTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTripId = (int)cBTrip.SelectedValue;
            BringPassengerCount();
        }

        private void btnBusAnimated_Click(object sender, EventArgs e)
        {
            lstPlate.Items.Add(cbBuses.Text);
            lstDate.Items.Add(DateTime.Now);
            int price = Convert.ToInt32(txtPersonNumber.Text) * 100;
            lstPrice.Items.Add(price.ToString());
            var trip = (Trip)cBTrip.SelectedItem;
            db.TripPassengerInfos.RemoveRange(db.TripPassengerInfos.Where(x => x.Trip.Id == trip.Id));
            db.Trips.Remove(trip);
            db.SaveChanges();
        }

        private void lstPlate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBusStateSave_Click(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var sb = new StringBuilder();
            for (int i = 0; i < lstPlate.Items.Count; i++)
            {
                var busS = new BusState();

                busS.PlateNumber = lstPlate.Items[i].ToString();
                busS.Date = (DateTime)(lstDate.Items[i]);
                busS.TotalPrice = Convert.ToInt32(lstPrice.Items[i]);

                sb.AppendLine(busS.ToString());
                db.BusStates.Add(busS);
            }
            using (var sW = new StreamWriter(desktopPath + @"\saved.txt"))
            {
                sW.Write(sb.ToString());
            }
            db.SaveChanges();
        }

        private void DailyArchive_Click(object sender, EventArgs e)
        {
            lstDailyRecordArchive.Items.Clear();
            var now = DateTime.Now;
            lstDailyRecordArchive.Items.AddRange(db.BusStates.Where(x => x.Date.Day == now.Day && x.Date.Month == now.Month && x.Date.Year == now.Year).ToArray());
        }
    }
}
