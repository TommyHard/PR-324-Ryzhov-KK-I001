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
    public partial class AdminPayments : Form
    {
        public AdminPayments()
        {
            InitializeComponent();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonReservations_Click(object sender, EventArgs e)
        {
            AdminPaymentsReserv Reserv = new AdminPaymentsReserv();
            this.Hide();
            Reserv.ShowDialog();
            if (Reserv.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminPayments_Load(object sender, EventArgs e)
        {
            this.paymentsTableAdapter.Fill(this.flightBookingDNB.Payments);
        }
    }
}
