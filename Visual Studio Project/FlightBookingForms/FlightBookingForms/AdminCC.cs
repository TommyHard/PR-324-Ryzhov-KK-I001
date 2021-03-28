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
    public partial class AdminCC : Form
    {
        public AdminCC()
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
            AdminCCcreation Creation = new AdminCCcreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.cityTableAdapter.Fill(this.flightBookingDBA.City);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            City newCity = new City();
            newCity.ID = Convert.ToInt32(CityTables["dataGridViewTextBoxColumn1", CityTables.CurrentCell.RowIndex].Value);
            AdminCCediting Editing = new AdminCCediting(newCity);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.cityTableAdapter.Fill(this.flightBookingDBA.City);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cityBindingSource.RemoveCurrent();
                    AdminCity_Load();
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

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void AdminCC_Load(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.flightBookingDBA.City);
        }

        private void AdminCity_Load()
        {
            cityBindingSource.EndEdit();
            cityTableAdapter.Update(flightBookingDBA);
            cityTableAdapter.Fill(this.flightBookingDBA.City);
        }
    }
}
