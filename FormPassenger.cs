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
using static OtobusBiletRezervasyonu.FormTicketSale;

namespace OtobusBiletRezervasyonu
{
    public partial class FormPassenger : Form
    {
        public FormPassenger()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();
       public int id;
        
        private void FormPassenger_Load(object sender, EventArgs e)
        {
           
        }
        private void rbGenderMale_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Passenger psngr = new Passenger();
           

            psngr.FirstName = txtFirstName.Text;
            psngr.LastName = txtLastname.Text;
            psngr.PhoneNumber = txtPhoneNumber.Text;
            if (rbGenderMale.Checked == true)
                psngr.Gender = Gender.Male;
            else
                psngr.Gender = Gender.Famale;

            psngr.BirthDate = dateTimePicker1.Value;
            psngr.IdentificationNumber = txtTC.Text;
               
            db.Passengers.Add(psngr);
            db.SaveChanges();
            id = db.Passengers.FirstOrDefault(x => x.PhoneNumber == txtPhoneNumber.Text).Id;
            //_passengerid = db.Passengers.FirstOrDefault(x => x.PhoneNumber == txtPhoneNumber.Text).Id;
            Hide();
            DialogResult = DialogResult.OK;
        }
    }
}
