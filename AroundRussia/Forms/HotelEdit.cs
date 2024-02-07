using AroundRussia.DBContext;
using AroundRussia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AroundRussia.Forms
{
    public partial class HotelEdit : Form
    {
        private readonly Hotel hotelEdit;

        public Hotel Hotel => hotelEdit;
        public HotelEdit()
        {
            InitializeComponent();
            editButton.Visible = false; 
            deleteButton.Visible = false;
            countryComboBox.DisplayMember = nameof(Country.Name);
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                countryComboBox.Items.AddRange(db.Countries.ToArray());
                countryComboBox.SelectedItem = 0;
            }
        }

        public HotelEdit(Hotel hotel) : this()
        {
            Text = "Изменить";
            addButton.Visible = false;
            this.hotelEdit = hotel;
            nameTextBox.Text = hotel.Name;
            starsNumeric.Value = hotel.CountOfStars;
            descTextBox.Text = hotel.Description;

            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                countryComboBox.SelectedItem = db.Countries.FirstOrDefault(c => c.Code == hotel.CountryCode);
            }
        }

        private void HotelEdit_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                Hotel newHotel = new Hotel
                {
                    Name = nameTextBox.Text,
                    CountOfStars = Convert.ToInt32(starsNumeric.Value),
                    CountryCode = countryComboBox.SelectedItem.ToString(),
                    Description = descTextBox.Text
                };
                db.Hotels.Add(newHotel);
                db.SaveChanges();
            }
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                var editHotel = db.Hotels.FirstOrDefault(x => x.Id == hotelEdit.Id);
                editHotel.Name = nameTextBox.Text;
                editHotel.CountOfStars = Convert.ToInt32(starsNumeric.Value);
                editHotel.CountryCode = countryComboBox.SelectedItem.ToString();
                editHotel.Description = descTextBox.Text;
                db.Hotels.Update(editHotel);
                db.SaveChanges();
            }    
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                db.Hotels.Remove(hotelEdit);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
