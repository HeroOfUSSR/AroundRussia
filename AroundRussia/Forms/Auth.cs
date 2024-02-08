using AroundRussia.DBContext;
using AroundRussia.Forms;
using AroundRussia.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

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
                    var currentUser = db.Users.FirstOrDefault(a => a.Username == login && a.Password == password);
                    Tours ToursForm = new Tours();
                    ToursForm.Show();
                    switch (currentUser.RoleId)
                    {
                        case 1:
                            Profiles.Profiles.admin = true;
                            break;
                        case 2:
                            Profiles.Profiles.manager = true;
                            break;
                        case 3:
                            Profiles.Profiles.user = true;
                            break;
                    }

                } else
                {
                    MessageBox.Show("Неверный пароль или логин", "Ошибка авторизации");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profiles.Profiles.user = true;

            Tours ToursForm = new Tours();
            ToursForm.Show();
        }
    }
}