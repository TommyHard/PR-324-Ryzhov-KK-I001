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
using System.Text.RegularExpressions;

namespace FlightBookingForms
{
    public partial class AdminFlightPriceCreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        FlightSchedules[] CurrentFlight = new FlightSchedules[0];

        public AdminFlightPriceCreation()
        {
            InitializeComponent();
            TimerLanguage.Start();
            ReaderFlights();
            flight_CostsBindingSource.AddNew();
        }

        private void ReaderFlights()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From [Flight Schedules] ORDER BY [Flight ID]", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                FlightIDComboBox.Items.AddRange(new string[] { reader["Flight ID"].ToString() });
                Array.Resize(ref CurrentFlight, i + 1);
                CurrentFlight[i] = new FlightSchedules();
                CurrentFlight[i].FlightID = (int)reader["Flight ID"];
            }
            FlightIDComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (flight_CostTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("INSERT INTO [Flight Costs]([Flight ID], [Flight Cost]) SELECT @FlightID, @FlightCost WHERE NOT EXISTS (SELECT 1 FROM [Flight Costs] WHERE [Flight ID] = @FlightID)", con))
                    {
                        cum.Parameters.AddWithValue("@FlightID", flight_IDTextBox.Text);
                        cum.Parameters.AddWithValue("@FlightCost", flight_CostTextBox.Text);
                        con.Open();
                        if (cum.ExecuteNonQuery() <= 0)
                        {
                            MessageBox.Show("Цена на данный рейс уже указана!", "Warning");
                        }
                        else
                        {
                            ChangeText();
                        }
                    }
                }
                finally
                {
                    con.Close();
                }
            }
            else MessageBox.Show("Заполните поля", "Warning");
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void flight_CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private async void ChangeText()
        {
            ButtonCreate.Enabled = false;
            ButtonCreate.Text = "Цена добавлена";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flight_CostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            if (FlightIDComboBox.SelectedIndex >= 0)
            {
                flight_IDTextBox.Text = CurrentFlight[FlightIDComboBox.SelectedIndex].FlightID.ToString();
            }

            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }
    }
}
