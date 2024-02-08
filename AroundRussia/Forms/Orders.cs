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
    public partial class Orders : Form
    {
        private Dictionary<Tour, int> orders;
        private decimal sum = 0;

        public Orders(Dictionary<Tour, int> orders)
        {
            InitializeComponent();
            this.orders = orders;
            pickComboBox.DisplayMember = nameof(PickUpPoint.PickUpAddress);

            foreach (var item in orders.Keys)
            {
                var orderView = new OrderView(item, orders[item]);

                orderView.countChange += UpdateSum;
                orderView.Visible = true;
                orderView.Parent = flowLayoutPanel1;

                sum += item.Price * orderView.Count;

                

            }
            labelCost.Text = $"{sum:C2}";

            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                pickComboBox.Items.AddRange(db.PickUpPoints.ToArray());
                pickComboBox.SelectedItem = 0;
            }
        }

        private void UpdateSum()
        {
            sum = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is OrderView orderView)
                {
                    sum += orderView.Tour.Price * orderView.Count;
                    if (orders.TryGetValue(orderView.Tour, out var count))
                    {
                        orders[orderView.Tour] = orderView.Count;
                    }
                }
            }
            labelCost.Text = $"{sum:C2}";

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                foreach (var item in orders.Keys)
                {
                    var orderView = new OrderView(item, orders[item]);

                    var order = new Order()
                    {
                        Cost = Convert.ToInt32(sum),
                        CodePickUp = ((PickUpPoint)pickComboBox.SelectedItem).PickUpCode,
                        DateOrder = DateTimeOffset.Now,
                        TourId = item.Id,
                        Amount = orderView.Count
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                MessageBox.Show("Заказ оформлен");
                this.Close();
            }
        }
           

    }
}
