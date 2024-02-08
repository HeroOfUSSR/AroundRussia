using AroundRussia.DBContext;
using AroundRussia.ModelResponse;
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
        private readonly HotelResponse hotelEdit;

        public HotelResponse Hotel => hotelEdit;
        public HotelEdit()
        {
            InitializeComponent();

            editButton.Visible = false;
            addButton.Visible = true;
            deleteButton.Visible = false;
            countryComboBox.DisplayMember = nameof(Country.Code);
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                countryComboBox.Items.AddRange(db.Countries.ToArray());
                countryComboBox.SelectedItem = 0;
            }
        }

        public HotelEdit(HotelResponse hotel) : this()
        {
            Text = "Изменить";
            addButton.Visible = false;
            editButton.Visible = true;
            this.hotelEdit = hotel;
            nameTextBox.Text = hotel.Name;
            starsNumeric.Value = hotel.CountOfStars;
            descTextBox.Text = hotel.Description;

            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                //countryComboBox.SelectedItem = db.Countries.FirstOrDefault(c => c.Code == hotel.CountryCode);
                countryComboBox.SelectedItem = countryComboBox.Items.Cast<Country>()
                .FirstOrDefault(x => x.Code == hotel.CountryCode);
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
                    CountryCode = ((Country)countryComboBox.SelectedItem).Code,
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
                editHotel.CountryCode = ((Country)countryComboBox.SelectedItem).Code;
                editHotel.Description = descTextBox.Text;
                db.Hotels.Update(editHotel);
                db.SaveChanges();
            }
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                var deleteHotel = db.Hotels.FirstOrDefault(x => x.Id == hotelEdit.Id);
                db.Hotels.Remove(deleteHotel);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
