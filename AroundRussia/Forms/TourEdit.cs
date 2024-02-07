using AroundRussia.DBContext;
using AroundRussia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AroundRussia.Forms
{
    public partial class TourEdit : Form
    {
        private readonly Tour tourEdit;

        public Tour Tour => tourEdit;
        public TourEdit()
        {
            InitializeComponent();
            Text = "Добавление тура";
            addButton.Text = "Добавить";
            deleteButton.Visible = false;
            countryComboBox.DisplayMember = nameof(Country.Name);
            typeComboBox.DisplayMember = nameof(Models.Type.Name);
            tourEdit = new Tour();

            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                countryComboBox.Items.AddRange(db.Countries.ToArray());
                countryComboBox.SelectedIndex = 0;
                typeComboBox.Items.AddRange(db.Types.ToArray());
            }
        }

        public TourEdit(Tour tour) : this()
        {
            Text = "Изменение тура";
            addButton.Text = "Изменить";
            this.tourEdit = tour;
            deleteButton.Visible = true;
            nameTextBox.Text = tour.Name;
            costTextBox.Text = tour.Price.ToString();
            isActualChecked.Checked = tour.IsActual;
            ticketsNumeric.Value = tour.TicketCount;
            descTextBox.Text = tour.Description;
            
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                countryComboBox.SelectedItem = db.Countries.FirstOrDefault(c => c.Code == tour.TourCountry);

                typeComboBox.SelectedItem = db.Types.FirstOrDefault(c => c.Id == tour.Id);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                db.Tours.Remove(tourEdit);
                db.SaveChanges();
            }
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                Tour newTour = new Tour
                {
                    Name = nameTextBox.Text,
                    TourCountry = countryComboBox.SelectedItem.ToString(),
                    TicketCount = Convert.ToInt32(ticketsNumeric.Value),
                    Description = descTextBox.Text,
                    Price = Convert.ToInt32(costTextBox.Text),
                    IsActual = isInternationalChecked.Checked,
                    IsInternational = isInternationalChecked.Checked,
                };
                db.Tours.Add(newTour);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
