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
    public partial class FormCitiesAdd : Form
    {
        public FormCitiesAdd()
        {
            InitializeComponent();
        }
        BusModel db = new BusModel();

        private void FormCitiesAdd_Load(object sender, EventArgs e)
        {
            Lists();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Name = txtCitiesName.Text;
            db.Cities.Add(city);
            db.SaveChanges();
            txtCitiesName.Clear();
            txtCitiesName.Focus();
            Lists();

        }

        private void Lists()
        {
            var list = db.Cities.Select(x => new
            {
                x.Name
            }).ToList();
            dataGridViewCities.DataSource = list;

        }
    }
}
