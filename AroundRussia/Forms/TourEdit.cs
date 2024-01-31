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
    public partial class TourEdit : Form
    {
        private readonly Tour tourEdit;
        public TourEdit()
        {
            InitializeComponent();
            Text = "Добавление тура";
            addButton.Text = "Добавить";
            deleteButton.Visible = false;
            countryComboBox.DisplayMember = nameof(Country.Name);
            typeComboBox.DisplayMember = nameof(Models.Type.Name);
            tourEdit = new Tour();

        }

        public TourEdit(Tour tour) : this()
        {
            Text = "Изменение тура";
            addButton.Text = "Изменить";
            this.tourEdit = tour;
            deleteButton.Visible = true;
            nameTextBox.Text = tour.Name;
            costTextBox.Text = tour.Price.ToString();
            isActualChecked.Checked = tour.IsActual;
            ticketsNumeric.Value = tour.TicketCount;
            
        }
    }
}
