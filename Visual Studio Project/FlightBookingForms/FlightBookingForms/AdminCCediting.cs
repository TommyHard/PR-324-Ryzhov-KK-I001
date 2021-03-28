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
    public partial class AdminCCediting : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        Country[] CurrentCountry = new Country[0];
        int CityIDD;

        public AdminCCediting(City NewCity)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM City WHERE [City ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", NewCity.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                city_IDLabel1.Text = reader["City ID"].ToString();
                country_IDTextBox.Text = reader["Country ID"].ToString();
                nameTextBox.Text = reader["Name"].ToString();
            }
            reader.Close();
            con.Close();

            con.Open();
            cum = new SqlCommand("SELECT * From Country ORDER BY Name", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                CountryComboBox.Items.AddRange(new string[] { (string)reader["Name"] });
                Array.Resize(ref CurrentCountry, i + 1);
                CurrentCountry[i] = new Country();
                CurrentCountry[i].ID = (int)reader["Country ID"];
                CurrentCountry[i].Name = (string)reader["Name"];
                if (CurrentCountry[i].ID.ToString() == country_IDTextBox.Text)
                {
                    CityIDD = i;
                }
            }
            reader.Close();
            con.Close();
            CountryComboBox.DropDownHeight = 213;
            CountryComboBox.SelectedIndex = CityIDD;
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            country_IDTextBox.Text = CurrentCountry[CountryComboBox.SelectedIndex].ID.ToString();
            if (nameTextBox.Text != "" && country_IDTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("SELECT Count(*) FROM City WHERE Name=@Name AND [City ID] NOT LIKE @CityID", con))
                    {
                        cum.Parameters.AddWithValue("@CityID", city_IDLabel1.Text);
                        cum.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Город с таким названием уже существует!", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("UPDATE City SET [Country ID]=@CountryID, Name=@Name WHERE [City ID]=@id", con);
                            cum.Parameters.AddWithValue("@id", city_IDLabel1.Text);
                            cum.Parameters.AddWithValue("@CountryID", country_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", nameTextBox.Text);
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

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"')
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
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }
    }
}
