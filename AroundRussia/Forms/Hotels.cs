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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }



        private void Init_Datagrid()
        {
            using (var db = new AroundRussiaContext())
            {
                dataHotel.DataSource = db.Hotels.Select(x => new Hotel
                {

                })
            }

        }
    }
}
