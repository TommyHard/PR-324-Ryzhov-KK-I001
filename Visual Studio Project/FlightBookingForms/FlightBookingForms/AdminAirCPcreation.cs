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
    public partial class AdminAirCPcreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        City[] CurrentCity = new City[0];

        public AdminAirCPcreation()
        {
            InitializeComponent();
            airPortsBindingSource.AddNew();
            TimerLanguage.Start();
            con.Open();
            cum = new SqlCommand("SELECT * From City ORDER BY Name", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                LocationComboBox.Items.AddRange(new string[] { (string)reader["Name"] });
                Array.Resize(ref CurrentCity, i + 1);
                CurrentCity[i] = new City();
                CurrentCity[i].ID = (int)reader["City ID"];
                CurrentCity[i].Name = (string)reader["Name"];
            }
            LocationComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (LocationComboBox.Text != "")
            {
                airport_LocationTextBox.Text = CurrentCity[LocationComboBox.SelectedIndex].Name.ToString();
                if (airport_NameTextBox1.Text != "" && airport_LocationTextBox.Text != "")
                {
                    try
                    {
                        using (cum = new SqlCommand("INSERT INTO AirPorts([Airport Name], [Airport Location]) SELECT @Name, @AirPortLocation WHERE NOT EXISTS (SELECT 1 FROM AirPorts WHERE [Airport Name] = @Name)", con))
                        {
                            cum.Parameters.AddWithValue("@AirPortLocation", airport_LocationTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", airport_NameTextBox1.Text);
                            con.Open();
                            if (cum.ExecuteNonQuery() <= 0)
                            {
                                MessageBox.Show("Аэропорт с таким названием уже существует!", "Warning");
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
            else MessageBox.Show("Выберите город!", "Warning");
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void airport_NameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            this.airPortsBindingSource.EndEdit();
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
            ButtonCreate.Text = "Аэропорт добавлен";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
            airPortsBindingSource.AddNew();
        }
    }
}
