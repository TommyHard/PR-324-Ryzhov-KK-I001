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
    public partial class AdminAirCPediting : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        City[] CurrentCity = new City[0];
        int AirPortsIDD;

        public AdminAirCPediting(AirPorts newAirpots)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM AirPorts WHERE [Airport ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", newAirpots.ID);
            con.Open();
            reader = Command.ExecuteReader();
            while (reader.Read())
            {
                airport_IDLabel1.Text = reader["Airport ID"].ToString();
                airport_LocationTextBox.Text = reader["Airport Location"].ToString();
                airport_NameTextBox.Text = reader["Airport Name"].ToString();
            }
            reader.Close();
            con.Close();
            CityReader();
        }
        private void CityReader()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From City ORDER BY Name", con);
            reader = cum.ExecuteReader(); 
            for (int i = 0; reader.Read(); i++)
            {
                AirPortsComboBox.Items.AddRange(new string[] { (string)reader["Name"] });
                Array.Resize(ref CurrentCity, i + 1);
                CurrentCity[i] = new City();
                CurrentCity[i].ID = (int)reader["City ID"];
                CurrentCity[i].Name = (string)reader["Name"];
                if (CurrentCity[i].Name == airport_LocationTextBox.Text)
                {
                    AirPortsIDD = i;
                }
            }
            reader.Close();
            con.Close();
            AirPortsComboBox.DropDownHeight = 213;
            AirPortsComboBox.SelectedIndex = AirPortsIDD;
        }
        
        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            airport_LocationTextBox.Text = CurrentCity[AirPortsComboBox.SelectedIndex].Name.ToString();
            if (airport_NameTextBox.Text != "" && airport_LocationTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("SELECT Count(*) FROM AirPorts WHERE [Airport Name]=@Name AND [Airport ID] NOT LIKE @AirPortID", con))
                    {
                        cum.Parameters.AddWithValue("@AirPortID", airport_IDLabel1.Text);
                        cum.Parameters.AddWithValue("@Name", airport_NameTextBox.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Аэропорт с таким названием уже существует!", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("UPDATE AirPorts SET [Airport Location]=@AirPortsLocation, [Airport Name]=@Name WHERE [Airport ID]=@id", con);
                            cum.Parameters.AddWithValue("@id", airport_IDLabel1.Text);
                            cum.Parameters.AddWithValue("@AirPortsLocation", airport_LocationTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", airport_NameTextBox.Text);
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

        private void airport_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"' && l != '-')
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
            this.airPortsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }
    }
}
