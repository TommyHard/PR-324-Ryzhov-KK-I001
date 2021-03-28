using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingForms
{
    public partial class AdminPassengers : Form
    {
        public AdminPassengers()
        {
            InitializeComponent();
            Visibility();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 1 || Restriction.RoleIDD == 2)
            {
                ButtonRemoving.Visible = false;
            }
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    passengersBindingSource.RemoveCurrent();
                    PassengersSave();
                }
                else { return; }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminPassengers_Load(object sender, EventArgs e)
        {
            this.passengersTableAdapter.Fill(this.flightBookingDNB.Passengers);
        }

        private void PassengersSave()
        {
            passengersBindingSource.EndEdit();
            passengersTableAdapter.Update(flightBookingDNB);
            passengersTableAdapter.Fill(this.flightBookingDNB.Passengers);
        }
    }
}
