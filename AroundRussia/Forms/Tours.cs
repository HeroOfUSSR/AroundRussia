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
        private int toursSum = 0;
        public static Dictionary<Tour, int> intoOrder;
        public Tours()
        {
            InitializeComponent();

            intoOrder = new Dictionary<Tour, int>();

            sortComboBox.DisplayMember = nameof(Models.Type.Name);
            sortComboBox.ValueMember = nameof(Models.Type.Id);

            
        }

        private void Sort()
        {
            if (sortComboBox.SelectedItem == null) return;

            var selectedTypeId = ((Models.Type)sortComboBox.SelectedItem).Id;
            toursSum = 0;

            foreach (var item in flowLayoutPanel.Controls)
            {
                var visible = true;
                if (item is TourView tourView)
                {
                    if (selectedTypeId != "DEFAULT" &&
                        !tourView.Tour.Types.Any(x => x.Id == selectedTypeId))
                    {
                        visible = false;
                    }

                    if (isActualcheckBox.Checked && !tourView.Tour.IsActual)
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(searchTextBox.Text) ||
                        tourView.Tour.Name.Contains(searchTextBox.Text)))
                    {
                        visible = false;
                    }
                    if (visible)
                    {
                        toursSum += (int)(tourView.Tour.Price * tourView.Tour.TicketCount);
                    }
                    tourView.Visible = visible;
                }

                sumLabel.Text = $"{toursSum}";
            }
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

        private void TourView_CountOrdersChanged(object sender, EventArgs e)
        {
            orderCountLabel.Text = intoOrder.Count.ToString();
            orderButton.Visible = intoOrder.Count != 0;
        }

        private void Tours_Load_1(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();

                var types = db.Types.OrderBy(x => x.Name);

                sortComboBox.Items.Clear();
                sortComboBox.Items.AddRange(types.ToArray());
                sortComboBox.Items.Insert(0, new Models.Type()
                {
                    Id = "DEFAULT",
                    Name = "Все типы",
                });

                sortComboBox.SelectedIndex = 0;

                foreach (var tour in tours)
                {

                    var tourView = new TourView(tour);
                    tourView.Parent = flowLayoutPanel;

                    tourView.ImageChanged += TourView_ImageChanged;
                    tourView.CountNewOrders += TourView_CountOrdersChanged;
                    tourView.addIntoOrder += TourIntoOrder;

                    toursSum += (int)(tour.Price * tour.TicketCount);
                }

                sumLabel.Text = $"{toursSum}";
            }
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            var Hotels = new Hotels();
            Hotels.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void isActualcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void sortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void TourIntoOrder(Tour tour)
        {
            if (intoOrder.TryGetValue(tour, out var count))
            {
                intoOrder[tour] = ++count;
            }
            else
            {
                intoOrder.Add(tour, 1);
            }

        }

        private void sumLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void orderCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var orderForm = new Orders(intoOrder);
            orderForm.Show();
        }
    }
}
