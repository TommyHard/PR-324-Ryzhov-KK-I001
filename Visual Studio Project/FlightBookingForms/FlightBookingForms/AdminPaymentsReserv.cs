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
    public partial class AdminPaymentsReserv : Form
    {
        public AdminPaymentsReserv()
        {
            InitializeComponent();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void reservation_PaymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservation_PaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminPaymentsReserv_Load(object sender, EventArgs e)
        {
            this.reservation_PaymentsTableAdapter.Fill(this.flightBookingDNB.Reservation_Payments);
        }
    }
}
