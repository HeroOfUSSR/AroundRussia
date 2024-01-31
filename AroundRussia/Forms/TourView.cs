using AroundRussia.DBContext;
using AroundRussia.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class TourView : UserControl
    {
        private readonly Tour tourView;
        private EventHandler<(Tour, byte[])> onImageChanged;

        public TourView(Tour tour)
        {
            InitializeComponent();
            this.tourView = tour;
            InitTour(tour);
        }

        public Tour Tour => tourView;
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

        public event EventHandler<(Tour, byte[])> ImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            var tourEdit = new TourEdit(Tour);
            var result = tourEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var db = new AroundRussiaContext())
                {
                    var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(t => t.Id == Tour.Id);
                    if (tour != null) { return; }
                    tour = tourEdit.Tour;
                    tour.Types.Clear();
                    db.SaveChanges();
                    InitTour(tour);
                }
            }
            else if (result == DialogResult.Yes)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {Tour.Name}\n\t" +
                    $"Цена: {Tour.Price}", "Предупреждение!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    using (var db = new AroundRussiaContext())
                    {
                        var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(x => x.Id == Tour.Id);
                        if (tour == null) { return; }
                        db.Tours.Remove(tour);
                        db.SaveChanges();
                        this.Hide();
                    }
                }
            }
        }
    }
}
