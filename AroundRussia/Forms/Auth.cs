using AroundRussia.DBContext;
using AroundRussia.Forms;
using AroundRussia.Models;
using Microsoft.EntityFrameworkCore;

namespace AroundRussia
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            { 

                var login = loginTextBox.Text;
                var password = passTextBox.Text;

                if (db.Users.Any(a => a.Username == login && a.Password == password))
                {
                    Tours ToursForm = new Tours();
                    ToursForm.Show();
                } else
                {
                    MessageBox.Show("рш веосую");
                }

                /*var admin = db.Users.FirstOrDefault(a => a.Username).Where(a => a.RoleId == 1);
                var manager = db.Users.FirstOrDefault(m => m.RoleId == 2);
                var user = db.Users.FirstOrDefault(u => u.RoleId == 3);

                switch (login.Text)
                {
                    case admin:
                        break;

                }

                var admins = db.Users
                    .Where(a => a.RoleId == 1)
                    .Select(a => a.Username)
                    .ToList();

                var managers = db.Users
                    .Where(a => a.RoleId == 2)
                    .Select(a => a.Username)
                    .ToList();

                var clients = db.Users
                    .Where(a => a.RoleId == 3)
                    .Select(a => a.Username)
                    .ToList();

                foreach (var admin in admins) 
                { 
                    if (login.Text == admin.ToString())
                    {
                        Tours ToursForm = new Tours();
                        ToursForm.Show();
                    } 
                    switch login.Text {
                       case 
                    }
                }*/

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tours ToursForm = new Tours();
            ToursForm.Show();
        }
    }
}