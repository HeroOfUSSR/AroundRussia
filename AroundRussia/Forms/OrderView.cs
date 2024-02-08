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
    public partial class OrderView : UserControl
    {
        public Tour Tour;
        public int Count;
        public Action countChange;
        public OrderView(Tour tour, int count)
        {
            InitializeComponent();
            this.Tour = tour;
            Count = count;
            labelName.Text = Tour.Name;
            labelPrice.Text = $"{Tour.Price}";
            countryLabel.Text = Tour.TourCountry;
            descLabel.Text = Tour.Description;
            labelTickets.Text = Tour.TicketCount.ToString();
            numericUpDown.Value = count;
            if (Tour.ImagePreview != null)
            {
                pictureTour.Image = Image.FromStream(new MemoryStream(Tour.ImagePreview));
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Count = (int)numericUpDown.Value;
            countChange?.Invoke();
        }
    }
}
