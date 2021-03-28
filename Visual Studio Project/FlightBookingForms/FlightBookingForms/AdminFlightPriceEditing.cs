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
    public partial class AdminFlightPriceEditing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        FlightSchedules[] CurrentFlight = new FlightSchedules[0];
        int FlightIDD;

        public AdminFlightPriceEditing(FlightSchedules newFlighting)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM [Flight Costs] WHERE [Costs ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", newFlighting.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                costs_IDTextBox.Text = reader["Costs ID"].ToString();
                flight_IDTextBox.Text = reader["Flight ID"].ToString();
                flight_CostTextBox.Text = reader["Flight Cost"].ToString().Replace(",0000", "");
            }
            reader.Close();
            con.Close();
            FlightReader();
        }
        private void FlightReader()
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
                if (CurrentFlight[i].FlightID.ToString() == flight_IDTextBox.Text)
                {
                    FlightIDD = i;
                }
            }
            FlightIDComboBox.SelectedIndex = FlightIDD;
            FlightIDComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            flight_IDTextBox.Text = CurrentFlight[FlightIDComboBox.SelectedIndex].FlightID.ToString();
            if (flight_CostTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("SELECT Count(*) FROM [Flight Costs] WHERE [Flight ID]=@FlightID AND [Costs ID] NOT LIKE @CostsID", con))
                    {
                        cum.Parameters.AddWithValue("@CostsID", costs_IDTextBox.Text);
                        cum.Parameters.AddWithValue("@FlightID", flight_IDTextBox.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Цена на данный рейс уже указана!", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("UPDATE [Flight Costs] SET [Flight ID]=@FlightID, [Flight Cost]=@Cost WHERE [Costs ID]=@id", con);
                            cum.Parameters.AddWithValue("@id", costs_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@FlightID", flight_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@Cost", Convert.ToString(flight_CostTextBox.Text));
                            cum.ExecuteNonQuery();
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
            ButtonSave.Enabled = false;
            ButtonSave.Text = "Информация обновлена";
            await Task.Delay(3000);
            ButtonSave.Text = "Сохранить";
            ButtonSave.Enabled = true;
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flight_CostsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }
    }
}
