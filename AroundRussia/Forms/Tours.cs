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
    public partial class Tours : Form
    {
        public Tours()
        {
            InitializeComponent();

            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var tourEdit = new TourEdit();
            tourEdit.Show();
        }

        private void TourView_ImageChanged(object sender, (Tour, byte[]) e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                db.Entry(e.Item1).State = EntityState.Modified;
                e.Item1.ImagePreview = e.Item2;
                db.SaveChanges();
            }
        }

        private void Tours_Load_1(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach (var tour in tours)
                {

                    var tourInfo = new TourView(tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourView_ImageChanged;
                }
            }
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            var Hotels = new Hotels();
            Hotels.Show();
        }
    }
}
