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
    public partial class AdminSeatNumber : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        public AdminSeatNumber()
        {
            InitializeComponent();
            Visibility();
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 2)
            {
                ButtonRemoving.Visible = false;
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void seat_NumberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seat_NumberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminSeatNumber_Load(object sender, EventArgs e)
        {
            this.seat_NumberTableAdapter.Fill(this.flightBookingDNB.Seat_Number);
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
                    cum.Parameters.AddWithValue("@FlightID", Convert.ToInt32(SeatNumberTable["dataGridViewTextBoxColumn2", SeatNumberTable.CurrentCell.RowIndex].Value));
                    cum.ExecuteNonQuery();
                    cum = new SqlCommand("DELETE FROM [Flight Schedules] WHERE [Flight ID] = @FlightID", con);
                    cum.Parameters.AddWithValue("@FlightID", Convert.ToInt32(SeatNumberTable["dataGridViewTextBoxColumn2", SeatNumberTable.CurrentCell.RowIndex].Value));
                    cum.ExecuteNonQuery();
                    con.Close();
                    AdminUsers_Load();
                }
                else { return; }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void AdminUsers_Load()
        {
            seat_NumberBindingSource.EndEdit();
            seat_NumberTableAdapter.Update(flightBookingDNB);
            seat_NumberTableAdapter.Fill(this.flightBookingDNB.Seat_Number);
        }
    }
}
