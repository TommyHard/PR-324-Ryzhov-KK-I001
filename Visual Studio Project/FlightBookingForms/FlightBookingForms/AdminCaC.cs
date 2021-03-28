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
    public partial class AdminCaC : Form
    {
        public AdminCaC()
        {
            InitializeComponent();
            Visibility();
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 1)
            {
                ButtonCreation.Visible = false;
                ButtonRemoving.Visible = false;
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            AdminCaCCreation Creation = new AdminCaCCreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.countryTableAdapter.Fill(this.flightBookingDBA.Country);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    countryBindingSource.RemoveCurrent();
                    AdminCountry_Load();
                }
                else
                {
                    return;
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Country newCountry = new Country();
            newCountry.ID = Convert.ToInt32(CountryTable["dataGridViewTextBoxColumn1", CountryTable.CurrentCell.RowIndex].Value);
            AdminCaCEditing Editing = new AdminCaCEditing(newCountry);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.countryTableAdapter.Fill(this.flightBookingDBA.Country);
        }

        private void ButtonCities_Click(object sender, EventArgs e)
        {
            AdminCC CC = new AdminCC();
            this.Hide();
            CC.ShowDialog();
            if (CC.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void AdminCaC_Load(object sender, EventArgs e)
        {
            this.countryTableAdapter.Fill(this.flightBookingDBA.Country);
        }

        private void AdminCountry_Load()
        {
            countryBindingSource.EndEdit();
            countryTableAdapter.Update(flightBookingDBA);
            countryTableAdapter.Fill(this.flightBookingDBA.Country);
        }
    }
}
