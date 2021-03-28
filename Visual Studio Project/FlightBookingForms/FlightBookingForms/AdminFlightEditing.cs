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
using Microsoft.OData.Edm;

namespace FlightBookingForms
{
    public partial class AdminFlightEditing : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        AirPorts[] CurrentAirPorts = new AirPorts[0];
        AirCrafts[] CurrentAirCraft = new AirCrafts[0];
        City[] CurrentCity = new City[0];
        int AirPortIDD;
        int AirCraftIDD = -1;
        bool Choice = false;

        public AdminFlightEditing(Flight newFlight)
        {
            InitializeComponent();
            TimerLanguage.Start();
            ReaderAirPorts();
            ReaderCity();
            string SelectRealtyInfo = "SELECT * FROM [Flight Schedules] WHERE [Flight ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", newFlight.FlightID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                flight_IDLabel1.Text = reader["Flight ID"].ToString();
                airPort_IDTextBox.Text = reader["AirPort ID"].ToString();
                airCraft_IDTextBox.Text = reader["AirCraft ID"].ToString();
                origin_City_IDTextBox.Text = reader["Origin City ID"].ToString();
                destination_City_IDTextBox.Text = reader["Destination City ID"].ToString();
                departure_Date_TimeDateTimePicker.Value = Convert.ToDateTime(reader["Departure Date Time"]);
                arrival_Date_TimeDateTimePicker.Value = Convert.ToDateTime(reader["Arrival Date Time"]);
                DepartureDatePicker.Value = Convert.ToDateTime(reader["Departure Date Time"]);
                ArrivalDatePicker.Value = Convert.ToDateTime(reader["Arrival Date Time"]);
            }
            reader.Close();
            con.Close();
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
                if (CurrentAirPorts[i].ID.ToString() == airPort_IDTextBox.Text)
                {
                    AirPortIDD = i;
                }
            }
            reader.Close();
            con.Close();
            AirPortIDComboBox.SelectedIndex = AirPortIDD;
            AirPortIDComboBox.DropDownHeight = 213;
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
                    if (CurrentAirCraft[i].ID.ToString() == airCraft_IDTextBox.Text)
                    {
                        AirCraftIDD = i;
                    }
                }
                reader.Close();
                con.Close();
                if (AirCraftIDD != -1)
                {
                    AirCraftIDComboBox.SelectedIndex = AirCraftIDD;
                }
                AirCraftIDComboBox.DropDownHeight = 213;
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
            reader.Close();
            con.Close();
            DestinationCityIDComboBox.DropDownHeight = 213;
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

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (airPort_IDTextBox.Text != "" && airCraft_IDTextBox.Text != "" && origin_City_IDTextBox.Text != "" && destination_City_IDTextBox.Text != "")
            {
                try
                {
                    cum = new SqlCommand("UPDATE [Flight Schedules] SET [AirPort ID]=@AirPortID, [AirCraft ID]=@AirCraftID, [Origin City ID]=@OriginCityID, [Destination City ID]=@DestinationCityID, [Departure Date Time]=@DepartureDateTime, [Arrival Date Time]=@ArrivalDateTime WHERE [Flight ID]=@id", con);
                    con.Open();
                    cum.Parameters.AddWithValue("@id", flight_IDLabel1.Text);
                    cum.Parameters.AddWithValue("@AirPortID", airPort_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@AirCraftID", airCraft_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@OriginCityID", origin_City_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@DestinationCityID", destination_City_IDTextBox.Text);
                    cum.Parameters.AddWithValue("@DepartureDateTime", departure_Date_TimeDateTimePicker.Value);
                    cum.Parameters.AddWithValue("@ArrivalDateTime", arrival_Date_TimeDateTimePicker.Value);
                    cum.ExecuteNonQuery();
                    ChangeText();
                }
                finally
                {
                    con.Close();
                }
            }
            else MessageBox.Show("Заполните поля", "Warning");
        }

        private async void ChangeText()
        {
            ButtonSave.Enabled = false;
            ButtonSave.Text = "Информация обновлена";
            await Task.Delay(3000);
            ButtonSave.Text = "Сохранить";
            ButtonSave.Enabled = true;
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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void DepartureDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DepartureDatePicker.Value < DateTime.Now && Choice)
            {
                MessageBox.Show("Дата отправления не может быть меньше текущей", "Warning");
                DepartureDatePicker.Value = DateTime.Now;
            }
            else
            {
                Choice = true;
                departure_Date_TimeDateTimePicker.Value = DepartureDatePicker.Value;
            }
            ArrivalDatePicker.Value = DepartureDatePicker.Value;
        }

        private void ArrivalDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ArrivalDatePicker.Value < DepartureDatePicker.Value)
            {
                MessageBox.Show("Дата прибытия должна быть больше Даты отправления", "Warning");
                ArrivalDatePicker.Value = DepartureDatePicker.Value;
            }
            else
            {
                arrival_Date_TimeDateTimePicker.Value = ArrivalDatePicker.Value;
            }
        }
    }
}
