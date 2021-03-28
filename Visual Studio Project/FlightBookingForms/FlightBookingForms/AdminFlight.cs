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
    public partial class AdminFlight : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        public AdminFlight()
        {
            InitializeComponent();
            Visibility();
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
                ButtonCreation.Visible = false;
                ButtonRemoving.Visible = false;
                ButtonEdit.Visible = false;
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    con.Open();
                    cum = new SqlCommand("DELETE FROM [Seat Number] WHERE [Flight ID] = @FlightID", con);
                    cum.Parameters.AddWithValue("@FlightID", Convert.ToInt32(FlightTable["dataGridViewTextBoxColumn1", FlightTable.CurrentCell.RowIndex].Value));
                    cum.ExecuteNonQuery();
                    cum = new SqlCommand("DELETE FROM [Flight Costs] WHERE [Flight ID] = @FlightID", con);
                    cum.Parameters.AddWithValue("@FlightID", Convert.ToInt32(FlightTable["dataGridViewTextBoxColumn1", FlightTable.CurrentCell.RowIndex].Value));
                    cum.ExecuteNonQuery();
                    con.Close();
                    flight_SchedulesBindingSource.RemoveCurrent();
                    FlightSave();
                }
                else { return; }
            }
            catch(System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!","Warning");
            }
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            AdminFlightCreations Creation = new AdminFlightCreations();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.flight_SchedulesTableAdapter.Fill(this.flightBookingDBA.Flight_Schedules);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Flight newFlight = new Flight();
            newFlight.FlightID = Convert.ToInt32(FlightTable["dataGridViewTextBoxColumn1", FlightTable.CurrentCell.RowIndex].Value);
            AdminFlightEditing Editing = new AdminFlightEditing(newFlight);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.flight_SchedulesTableAdapter.Fill(this.flightBookingDBA.Flight_Schedules);
        }

        private void flight_SchedulesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flight_SchedulesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void AdminFlight_Load(object sender, EventArgs e)
        {
            this.flight_SchedulesTableAdapter.Fill(this.flightBookingDBA.Flight_Schedules);
        }

        private void FlightSave()
        {
            flight_SchedulesBindingSource.EndEdit();
            flight_SchedulesTableAdapter.Update(flightBookingDBA);
            flight_SchedulesTableAdapter.Fill(this.flightBookingDBA.Flight_Schedules);
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            AdminFlightPrice Price = new AdminFlightPrice();
            this.Hide();
            Price.ShowDialog();
            if (Price.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            flight_SchedulesTableAdapter.Fill(this.flightBookingDBA.Flight_Schedules);
        }
    }
}
