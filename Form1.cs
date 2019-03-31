using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtobusBiletRezervasyonu.Entities;

namespace OtobusBiletRezervasyonu
{
    public partial class Form1 : Form
    {
        private BusModel busModel;

        public Form1()
        {
            InitializeComponent();
            busModel = new BusModel();

            FillBusList();
        }
        private void FillBusList()
        {
            listboxBuses.Items.Clear();
            listboxBuses.Items.AddRange(busModel.Buses?.ToArray());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxBusName.Text) == false && string.IsNullOrWhiteSpace(tbxPlateNo.Text) == false)
            {
                var bus = new Bus
                {
                    Name = tbxBusName.Text,
                    PlateNumber = tbxPlateNo.Text,
                    SeatCount = (int)nudSeatCount.Value
                };
                busModel.Buses.Add(bus);
                busModel.SaveChanges();
                FillBusList();
            }
        }

        private void ListboxBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxBuses.SelectedIndex != -1)
            {
                var selectedBus = (Bus)listboxBuses.SelectedItem;
                tbxBusName.Text = selectedBus.Name;
                tbxPlateNo.Text = selectedBus.PlateNumber;
                nudSeatCount.Value = selectedBus.SeatCount;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (listboxBuses.SelectedIndex != -1)
            {
                var bus = new Bus
                {
                    Id = ((Bus)listboxBuses.SelectedItem).Id,
                    Name = tbxBusName.Text,
                    PlateNumber = tbxPlateNo.Text,
                    SeatCount = (int)nudSeatCount.Value
                };
                var original = busModel.Buses.FirstOrDefault(x => x.Id == bus.Id);
                if (original != null)
                {
                    original.Name = bus.Name;
                    original.PlateNumber = bus.PlateNumber;
                    original.SeatCount = bus.SeatCount;
                    busModel.SaveChanges();
                    FillBusList();
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listboxBuses.SelectedIndex != -1)
            {
                var busId = ((Bus)listboxBuses.SelectedItem).Id;
                Bus bus = busModel.Buses.FirstOrDefault(x => x.Id == busId);
                busModel.Buses.Remove(bus);
                busModel.SaveChanges();
                FillBusList();
            }
            tbxBusName.Clear();
            tbxPlateNo.Clear();
            nudSeatCount.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}