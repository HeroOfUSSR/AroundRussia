using AroundRussia.DBContext;
using AroundRussia.ModelResponse;
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
            Init_Datagrid();
        }

        private void Init_Datagrid()
        {
            using (var db = new AroundRussiaContext(DBOptions.Options()))
            {
                dataHotel.DataSource = db.Hotels.Select(x => new HotelResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    CountOfStars = x.CountOfStars,
                    CountryCode = x.CountryCode,
                    Description = x.Description
                }).ToList();
            }

        }
    }
}
