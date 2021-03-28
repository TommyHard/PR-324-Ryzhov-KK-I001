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
    public partial class AdminBookedTicket : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        int PaymentID;
        public AdminBookedTicket()
        {
            InitializeComponent();
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
                    cum = new SqlCommand("UPDATE [Seat Number] SET Free = 'Yes' WHERE [Seat ID]=@id", con);
                    cum.Parameters.AddWithValue("@id", BookedTicketTable["dataGridViewTextBoxColumn5", BookedTicketTable.CurrentCell.RowIndex].Value);
                    con.Open();
                    cum.ExecuteNonQuery();
                    //
                    cum = new SqlCommand("SELECT * FROM [Reservation Payments] WHERE [Reservation ID] = @ReservID", con);
                    cum.Parameters.AddWithValue("@ReservID", BookedTicketTable["dataGridViewTextBoxColumn1", BookedTicketTable.CurrentCell.RowIndex].Value);
                    //
                    reader = cum.ExecuteReader();
                    while (reader.Read())
                    {
                        PaymentID = (int)reader["Payment ID"];
                    }
                    reader.Close();
                    //
                    cum.ExecuteNonQuery();
                    //
                    cum = new SqlCommand("DELETE FROM [Reservation Payments] WHERE [Reservation ID] = @ReservID", con);
                    cum.Parameters.AddWithValue("@ReservID", BookedTicketTable["dataGridViewTextBoxColumn1", BookedTicketTable.CurrentCell.RowIndex].Value);
                    cum.ExecuteNonQuery();
                    //
                    cum = new SqlCommand("DELETE FROM Payments WHERE [Payment ID] = @PayID", con);
                    cum.Parameters.AddWithValue("@PayID", PaymentID);
                    cum.ExecuteNonQuery();
                    //
                    con.Close();
                    //
                    booked_TicketBindingSource.RemoveCurrent();
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

        private void booked_TicketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booked_TicketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void AdminBookedTicket_Load(object sender, EventArgs e)
        {
            this.booked_TicketTableAdapter.Fill(this.flightBookingDNB.Booked_Ticket);
        }

        private void AdminCountry_Load()
        {
            booked_TicketBindingSource.EndEdit();
            booked_TicketTableAdapter.Update(flightBookingDNB);
            booked_TicketTableAdapter.Fill(this.flightBookingDNB.Booked_Ticket);
        }
    }
}
