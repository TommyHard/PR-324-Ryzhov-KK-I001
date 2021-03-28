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
    public partial class AdminCCcreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        Country[] CurrentCountry = new Country[0];

        public AdminCCcreation()
        {
            InitializeComponent();
            cityBindingSource.AddNew();
            TimerLanguage.Start();
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
            }
            CountryComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (CountryComboBox.Text != "")
            {
                country_IDTextBox.Text = CurrentCountry[CountryComboBox.SelectedIndex].ID.ToString();
                if (nameTextBox1.Text != "" && country_IDTextBox.Text != "")
                {
                    try
                    {
                        using (cum = new SqlCommand("INSERT INTO City(Name, [Country ID]) SELECT @Name, @CountryID WHERE NOT EXISTS (SELECT 1 FROM City WHERE Name = @Name)", con))
                        {
                            cum.Parameters.AddWithValue("@CountryID", country_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", nameTextBox1.Text);
                            con.Open();
                            if (cum.ExecuteNonQuery() <= 0)
                            {
                                MessageBox.Show("Город с таким названием уже существует!", "Warning");
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
            else MessageBox.Show("Выберите страну!", "Warning");
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void nameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private async void ChangeText()
        {
            ButtonCreate.Enabled = false;
            ButtonCreate.Text = "Город добавлен";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
            cityBindingSource.AddNew();
        }
    }
}
