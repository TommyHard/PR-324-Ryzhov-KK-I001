using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlightBookingForms
{
    public partial class AdminFlightPrice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();

        public AdminFlightPrice()
        {
            InitializeComponent();
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 1)
            {
                ButtonRemoving.Enabled = false;
                ButtonRemoving.Text = "Недоступно";
            }

            if (Restriction.RoleIDD == 2)
            {
                ButtonRemoving.Enabled = false;
                ButtonRemoving.Text = "Недоступно";
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            AdminFlightPriceCreation Creation = new AdminFlightPriceCreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.flight_CostsTableAdapter.Fill(this.flightBookingDBA.Flight_Costs);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int FlightID = Convert.ToInt32(PriceTable["dataGridViewTextBoxColumn1", PriceTable.CurrentCell.RowIndex].Value);
                    flight_CostsBindingSource.RemoveCurrent();
                    AdminUsers_Load();
                    con.Open();
                    cum = new SqlCommand("DELETE FROM [Seat Number] WHERE [Flight ID] = @FlightID", con);
                    cum.Parameters.AddWithValue("@FlightID", FlightID);
                    cum.ExecuteNonQuery();
                    cum = new SqlCommand("DELETE FROM [Flight Schedules] WHERE [Flight ID] = @FlightID", con);
                    cum.Parameters.AddWithValue("@FlightID", FlightID);
                    cum.ExecuteNonQuery();
                    con.Close();
                }
                else { return; }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void flight_CostsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flight_CostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void AdminFlightPrice_Load(object sender, EventArgs e)
        {
            this.flight_CostsTableAdapter.Fill(this.flightBookingDBA.Flight_Costs);
        }

        private void AdminUsers_Load()
        {
            flight_CostsBindingSource.EndEdit();
            flight_CostsTableAdapter.Update(flightBookingDBA);
            flight_CostsTableAdapter.Fill(this.flightBookingDBA.Flight_Costs);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            FlightSchedules newFlighting = new FlightSchedules();
            newFlighting.ID = Convert.ToInt32(PriceTable["Column1", PriceTable.CurrentCell.RowIndex].Value);
            AdminFlightPriceEditing Editing = new AdminFlightPriceEditing(newFlighting);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.flight_CostsTableAdapter.Fill(this.flightBookingDBA.Flight_Costs);
        }
    }
}
