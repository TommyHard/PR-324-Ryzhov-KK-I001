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
    public partial class AdminMenu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        FSP CurrentUser = new FSP();

        public AdminMenu(String Login)
        {
            InitializeComponent();

            con.Open();
            cum = new SqlCommand($"SELECT Surname, [First Name], Patronymic, [Role ID] from Users where Login = '{Login}'", con);
            reader = cum.ExecuteReader();
            while (reader.Read())
            {
                CurrentUser.Surname = (string)reader[0];
                CurrentUser.FirstName = (string)reader[1];
                CurrentUser.Patronymic = (string)reader[2];
                Restriction.RoleIDD = (int)reader[3];
            }
            Restriction.LoginNext = Login;
            reader.Close();
            con.Close();
            nameTextBox.Text = $"{CurrentUser.Surname} {CurrentUser.FirstName} {CurrentUser.Patronymic}";
            OgrVer();
            //Visibility();
        }

        private void OgrVer()
        {
            ButtonBackWards.Text = "X";
            ButtonCaC.Text = "Демо версия";
            ButtonAirCP.Text = "Демо версия";
            ButtonFlights.Text = "Демо версия";
            ButtonPassengers.Text = "Демо версия";
            ButtonBookedTicket.Text = "Демо версия";
            ButtonRate.Text = "Демо версия";
            SeatNumber.Text = "Демо версия";
            ButtonPayment.Text = "Демо версия";
            ButtonBackWards.Enabled = false;
            ButtonCaC.Enabled = false;
            ButtonAirCP.Enabled = false;
            ButtonFlights.Enabled = false;
            ButtonPassengers.Enabled = false;
            ButtonBookedTicket.Enabled = false;
            ButtonRate.Enabled = false;
            SeatNumber.Enabled = false;
            ButtonPayment.Enabled = false;
        }

        private void Visibility()
        {
            if (Restriction.RoleIDD == 1)
            {
                ButtonUsers.Enabled = false;
                ButtonUsers.Text = "Недостаточно прав";
            }

            if (Restriction.RoleIDD == 2)
            {
                ButtonUsers.Enabled = false;
                ButtonUsers.Text = "Недостаточно прав";
                ButtonCaC.Enabled = false;
                ButtonCaC.Text = "Недостаточно прав";
                ButtonAirCP.Enabled = false;
                ButtonAirCP.Text = "Недостаточно прав";
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonPersonalArea_Click(object sender, EventArgs e)
        {
            AdminPersonalArea AdminPersonalArea = new AdminPersonalArea(CurrentUser);
            this.Hide();
            AdminPersonalArea.ShowDialog();
            if (AdminPersonalArea.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            nameTextBox.Text = $"{CurrentUser.Surname} {CurrentUser.FirstName} {CurrentUser.Patronymic}";
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            AdminUsers AdminUsers = new AdminUsers();
            this.Hide();
            AdminUsers.ShowDialog();
            if (AdminUsers.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonCaC_Click(object sender, EventArgs e)
        {
            AdminCaC CaC = new AdminCaC();
            this.Hide();
            CaC.ShowDialog();
            if (CaC.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonAirCP_Click(object sender, EventArgs e)
        {
            AdminAirCP AP = new AdminAirCP();
            this.Hide();
            AP.ShowDialog();
            if (AP.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonFlights_Click(object sender, EventArgs e)
        {
            AdminFlight Flight = new AdminFlight();
            this.Hide();
            Flight.ShowDialog();
            if (Flight.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonPassengers_Click(object sender, EventArgs e)
        {
            AdminPassengers Passengers = new AdminPassengers();
            this.Hide();
            Passengers.ShowDialog();
            if (Passengers.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonRate_Click(object sender, EventArgs e)
        {
            AdminRate Rate = new AdminRate();
            this.Hide();
            Rate.ShowDialog();
            if (Rate.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void SeatNumber_Click(object sender, EventArgs e)
        {
            AdminSeatNumber Seat = new AdminSeatNumber();
            this.Hide();
            Seat.ShowDialog();
            if (Seat.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            AdminPayments PayMents = new AdminPayments();
            this.Hide();
            PayMents.ShowDialog();
            if (PayMents.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void ButtonBookedTicket_Click(object sender, EventArgs e)
        {
            AdminBookedTicket Booked = new AdminBookedTicket();
            this.Hide();
            Booked.ShowDialog();
            if (Booked.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }
    }
}
