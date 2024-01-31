using AroundRussia.DBContext;
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

            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                var tours = db.Tours.ToList();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tours_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var tourEdit = new TourEdit();
            tourEdit.Show();
        }
    }
}
