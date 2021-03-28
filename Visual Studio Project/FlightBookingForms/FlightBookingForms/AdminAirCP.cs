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
    public partial class AdminAirCP : Form
    {
        public AdminAirCP()
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
            AdminAirCPcreation Creation = new AdminAirCPcreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.airPortsTableAdapter.Fill(this.flightBookingDBA.AirPorts);
        }

        private void AdminAirPC_Load(object sender, EventArgs e)
        {
            this.airPortsTableAdapter.Fill(this.flightBookingDBA.AirPorts);
        }

        private void airPortsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airPortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    airPortsBindingSource.RemoveCurrent();
                    AdminAirPorts_Save();
                }
                else { return; }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void AdminAirPorts_Save()
        {
            airPortsBindingSource.EndEdit();
            airPortsTableAdapter.Update(flightBookingDBA);
            airPortsTableAdapter.Fill(this.flightBookingDBA.AirPorts);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            AirPorts newAirPorts = new AirPorts();
            newAirPorts.ID = Convert.ToInt32(AirPortsTable["dataGridViewTextBoxColumn1", AirPortsTable.CurrentCell.RowIndex].Value);
            AdminAirCPediting Editing = new AdminAirCPediting(newAirPorts);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.airPortsTableAdapter.Fill(this.flightBookingDBA.AirPorts);
        }

        private void ButtonAirCraft_Click(object sender, EventArgs e)
        {
            AdminAirCPcraft AirCraft = new AdminAirCPcraft();
            this.Hide();
            AirCraft.ShowDialog();
            if (AirCraft.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }
    }
}
