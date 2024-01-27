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
    public partial class TourOutput : UserControl
    {
        private readonly Tour tour;

        public TourOutput()
        {
            InitializeComponent();
        }

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
    }
}
