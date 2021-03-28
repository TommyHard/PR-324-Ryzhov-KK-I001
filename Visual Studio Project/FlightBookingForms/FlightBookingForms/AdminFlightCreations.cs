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
    public partial class AdminFlightCreations : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        AirPorts[] CurrentAirPorts = new AirPorts[0];
        AirCrafts[] CurrentAirCraft = new AirCrafts[0];
        City[] CurrentCity = new City[0];
        bool Choice = false;
        int Business = 0;
        int Economy = 0;
        int FlightID;

        public AdminFlightCreations()
        {
            InitializeComponent();
            DepartureDateTimer.Value = DateTime.Today;
            ArrivalDateTimer.Value = DateTime.Today;
            ReaderAirPorts();
            ReaderCity();
            TimerLanguage.Start();
            flight_SchedulesBindingSource.AddNew();
        }

        private void ReaderAirPorts()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From AirPorts ORDER BY [Airport Name]", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                AirPortIDComboBox.Items.AddRange(new string[] { (string)reader["Airport Name"] });
                Array.Resize(ref CurrentAirPorts, i + 1);
                CurrentAirPorts[i] = new AirPorts();
                CurrentAirPorts[i].ID = (int)reader["Airport ID"];
                CurrentAirPorts[i].AirPortLocation = (string)reader["Airport Location"];
                CurrentAirPorts[i].AirPortName = (string)reader["Airport Name"];
            }
            AirPortIDComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ReaderAirCraft()
        {
            if (AirPortIDComboBox.SelectedIndex >= 0)
            {
                con.Open();
                cum = new SqlCommand("SELECT * From AirCraft WHERE [AirPort ID]=@AirPortID ORDER BY [AirCraft Name]", con);
                cum.Parameters.AddWithValue("@AirPortID", CurrentAirPorts[AirPortIDComboBox.SelectedIndex].ID.ToString());
                reader = cum.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    AirCraftIDComboBox.Items.AddRange(new string[] { (string)reader["AirCraft Name"] });
                    Array.Resize(ref CurrentAirCraft, i + 1);
                    CurrentAirCraft[i] = new AirCrafts();
                    CurrentAirCraft[i].ID = (int)reader["AirCraft ID"];
                    CurrentAirCraft[i].Name = (string)reader["AirCraft Name"];
                }
                AirCraftIDComboBox.DropDownHeight = 213;
                reader.Close();
                con.Close();
            }
        }

        private void ReaderAirCraftSeat()
        {
            if (AirPortIDComboBox.SelectedIndex >= 0)
            {
                cum = new SqlCommand("SELECT * From AirCraft WHERE [AirPort ID]=@AirPortID", con);
                cum.Parameters.AddWithValue("@AirPortID", CurrentAirPorts[AirPortIDComboBox.SelectedIndex].ID.ToString());
                reader = cum.ExecuteReader();
                reader.Read();
                Business = (int)reader["Business Class Capacity"];
                Economy = (int)reader["Economy Class Capacity"];
                reader.Close();
            }
        }

        private void ReaderCity()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From City ORDER BY Name", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                Array.Resize(ref CurrentCity, i + 1);
                CurrentCity[i] = new City();
                CurrentCity[i].ID = (int)reader["City ID"];
                CurrentCity[i].Name = (string)reader["Name"];
            }
            DestinationCityIDComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void GenerateSeat()
        {
            String Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ReaderAirCraftSeat();
            for (int n = 0, SeatNumber = 0; n < 2; n++)
            {
                string TravelClass;
                if (n == 0)
                {
                    SeatNumber = Business;
                    TravelClass = "Business";
                }
                else
                {
                    SeatNumber = Economy;
                    TravelClass = "Economy";
                }
                for (int i = 0, number = 1, letter = 0; i < SeatNumber; i++, number++)
                {
                    if (number > 30)
                    {
                        number = 1;
                        letter++;
                    }
                    cum = new SqlCommand("INSERT INTO [Seat Number]([Flight ID], [Travel Class], [Seat Number], Free) VALUES (@FlightID, @TravelClass, @SeatNumber, @Free)", con);
                    cum.Parameters.AddWithValue("@FlightID", FlightID);
                    cum.Parameters.AddWithValue("@TravelClass", TravelClass);
                    cum.Parameters.AddWithValue("@SeatNumber", $"{number}{Letters[letter]}");
                    cum.Parameters.AddWithValue("@Free", "Yes");
                    cum.ExecuteNonQuery();
                }
            }
        }


        private void ReaderCityAirPorts()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From City WHERE Name=@Name", con);
            cum.Parameters.AddWithValue("@Name", CurrentAirPorts[AirPortIDComboBox.SelectedIndex].AirPortLocation);
            reader = cum.ExecuteReader();
            reader.Read();
            origin_City_IDTextBox.Text = Convert.ToString(reader["City ID"]);
            OriginCityLocation.Text = Convert.ToString(reader["Name"]);
            reader.Close();
            con.Close();
        }


        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (airPort_IDTextBox.Text != "" && airCraft_IDTextBox.Text != "" && origin_City_IDTextBox.Text != "" && destination_City_IDTextBox.Text != "")
            {
                try
                {
                    cum = new SqlCommand("INSERT INTO [Flight Schedules]([AirPort ID], [AirCraft ID], [Origin City ID], [Destination City ID], [Departure Date Time], [Arrival Date Time]) VALUES (@AirPortID, @AirCraftID, @OriginCityID, @DestinationCityID, @DepartureDateTime, @ArrivalDateTime) SELECT Scope_IDENTITY()", con);
                    con.Open();
                    cum.Parameters.AddWithValue("@AirPortID", airPort_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@AirCraftID", airCraft_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@OriginCityID", origin_City_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@DestinationCityID", destination_City_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@DepartureDateTime", departure_Date_TimeDateTimePicker.Value);
                    cum.Parameters.AddWithValue("@ArrivalDateTime", arrival_Date_TimeDateTimePicker.Value);
                    FlightID = Convert.ToInt32(cum.ExecuteScalar());
                    GenerateSeat();
                    ChangeText();
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

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            if (AirPortIDComboBox.SelectedIndex >= 0)
            {
                airPort_IDTextBox.Text = CurrentAirPorts[AirPortIDComboBox.SelectedIndex].ID.ToString();
            }

            if (AirCraftIDComboBox.SelectedIndex >= 0)
            {
                airCraft_IDTextBox.Text = CurrentAirCraft[AirCraftIDComboBox.SelectedIndex].ID.ToString();
            }

            if (DestinationCityIDComboBox.SelectedIndex >= 0)
            {
                destination_City_IDTextBox.Text = CurrentCity[DestinationCityIDComboBox.SelectedIndex].ID.ToString();
            }

            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private async void ChangeText()
        {
            ButtonCreate.Enabled = false;
            ButtonCreate.Text = "Рейс добавлен";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
        }

        private void flight_SchedulesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flight_SchedulesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }


        private void AirPortIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReaderCityAirPorts();
            DestinationCityIDComboBox.Items.Clear();
            foreach (City city in CurrentCity)
            {
                if (city.ID != Convert.ToInt32(origin_City_IDTextBox.Text))
                {
                    DestinationCityIDComboBox.Items.Add(city.Name);
                }
            }
            AirCraftIDComboBox.Items.Clear();
            ReaderAirCraft();
            airCraft_IDTextBox.Clear();
        }

        private void DepartureDateTimer_TextChanged(object sender, EventArgs e)
        {
            if (DepartureDateTimer.Value < DateTime.Now && Choice)
            {
                MessageBox.Show("Дата отправления не может быть меньше текущей", "Warning");
                DepartureDateTimer.Value = DateTime.Now;
            }
            else
            {
                Choice = true;
                departure_Date_TimeDateTimePicker.Value = DepartureDateTimer.Value;
            }
            ArrivalDateTimer.Value = DepartureDateTimer.Value;
        }

        private void ArrivalDateTimer_TextChanged(object sender, EventArgs e)
        {
            if (ArrivalDateTimer.Value < DepartureDateTimer.Value)
            {
                MessageBox.Show("Дата прибытия должна быть больше Даты отправления","Warning");
                ArrivalDateTimer.Value = DepartureDateTimer.Value;
            }
            else
            {
                arrival_Date_TimeDateTimePicker.Value = ArrivalDateTimer.Value;
            }
        }
    }
}
