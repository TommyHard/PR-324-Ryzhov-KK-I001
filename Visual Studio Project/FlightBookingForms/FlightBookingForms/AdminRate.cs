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
    public partial class AdminRate : Form
    {
        public AdminRate()
        {
            InitializeComponent();
            Visibility();
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 2)
            {
                ButtonEdit.Visible = false;
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminRate_Load(object sender, EventArgs e)
        {
            this.rateTableAdapter.Fill(this.flightBookingDNB.Rate);
        }

        private void RateSave()
        {
            rateBindingSource.EndEdit();
            rateTableAdapter.Update(flightBookingDNB);
            rateTableAdapter.Fill(this.flightBookingDNB.Rate);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Rate newRate = new Rate();
            newRate.ID = Convert.ToInt32(RateTables["dataGridViewTextBoxColumn1", RateTables.CurrentCell.RowIndex].Value);
            AdminRateEditing Editing = new AdminRateEditing(newRate);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.rateTableAdapter.Fill(this.flightBookingDNB.Rate);
        }
    }
}
