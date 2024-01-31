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
    public partial class TourOutput2 : UserControl
    {
        private readonly Tour tourOutput;

        public TourOutput2(Tour tour)
        {
            InitializeComponent();
            this.tourOutput = tour;
            InitTour(tour);
        }

        public Tour Tour => tourOutput;
        private void InitTour(Tour tour)
        {
            labelName.Text = tour.Name;
            labelPrice.Text = $"{tour.Price}";
            labelisActual.Text = tour.IsActual ? "Актуален" : "Не актуален";
            labelisActual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
            labelTickets.Text = tour.TicketCount.ToString();
            if (tour.ImagePreview != null)
            {
                pictureTour.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
        }

        private void pictureTour_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var tourEdit = new TourEdit(Tour);
            var result = tourEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var db = new AroundRussiaContext())
                {
                }
            }
        }
    }
}
