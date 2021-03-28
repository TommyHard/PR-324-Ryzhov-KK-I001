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
    public partial class AdminAirCPcraft : Form
    {
        public AdminAirCPcraft()
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
            AdminAirCPCraftcreation Creation = new AdminAirCPCraftcreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.airCraftTableAdapter.Fill(this.flightBookingDBA.AirCraft);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    airCraftBindingSource.RemoveCurrent();
                    AdminAirPorts_Save();
                }
                else { return; }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            AirCrafts newAirCraft = new AirCrafts();
            newAirCraft.ID = Convert.ToInt32(AirCraftTable["dataGridViewTextBoxColumn4", AirCraftTable.CurrentCell.RowIndex].Value);
            AdminAirCPCraftedition Editing = new AdminAirCPCraftedition(newAirCraft);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.airCraftTableAdapter.Fill(this.flightBookingDBA.AirCraft);
        }

        private void AdminAirPorts_Save()
        {
            airCraftBindingSource.EndEdit();
            airCraftTableAdapter.Update(flightBookingDBA);
            airCraftTableAdapter.Fill(this.flightBookingDBA.AirCraft);
        }

        private void airCraftBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airCraftBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void AdminAirCPcraft_Load(object sender, EventArgs e)
        {
            this.airCraftTableAdapter.Fill(this.flightBookingDBA.AirCraft);
        }
    }
}
