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
    public partial class AdminAirCPCraftcreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        AirPorts[] CurrentAirPorts = new AirPorts[0];

        public AdminAirCPCraftcreation()
        {
            InitializeComponent();
            airCraftBindingSource.AddNew();
            TimerLanguage.Start();
            con.Open();
            cum = new SqlCommand("SELECT * From AirPorts ORDER BY [Airport Name]", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                AirPortsComboBox.Items.AddRange(new string[] { (string)reader["Airport Name"] });
                Array.Resize(ref CurrentAirPorts, i + 1);
                CurrentAirPorts[i] = new AirPorts();
                CurrentAirPorts[i].ID = (int)reader["Airport ID"];
                CurrentAirPorts[i].AirPortName = (string)reader["Airport Name"];
            }
            AirPortsComboBox.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (AirPortsComboBox.Text != "")
            {
                airPort_IDTextBox.Text = CurrentAirPorts[AirPortsComboBox.SelectedIndex].ID.ToString();
                if (airCraft_NameTextBox.Text != "" && airPort_IDTextBox.Text != "" && business_Class_CapacityTextBox.Text != "" && economy_Class_CapacityTextBox.Text != "")
                {
                    try
                    {
                        using (cum = new SqlCommand("INSERT INTO AirCraft([AirPort ID], [AirCraft Name], [Business Class Capacity], [Economy Class Capacity]) SELECT @AirPortID, @Name, @Business, @Economy WHERE NOT EXISTS (SELECT 1 FROM AirCraft WHERE [AirPort ID] = @AirPortID AND [AirCraft Name]=@Name)", con))
                        {
                            cum.Parameters.AddWithValue("@AirPortID", airPort_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", airCraft_NameTextBox.Text);
                            cum.Parameters.AddWithValue("@Business", business_Class_CapacityTextBox.Text);
                            cum.Parameters.AddWithValue("@Economy", economy_Class_CapacityTextBox.Text);
                            con.Open();
                            if (cum.ExecuteNonQuery() <= 0)
                            {
                                MessageBox.Show("Самолёт уже есть в списке этого аэропорта!", "Warning");
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
            else MessageBox.Show("Выберите аэропорт!", "Warning");
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void airCraft_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"' && l != '-'))
            {
                e.Handled = true;
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airCraftBindingSource.EndEdit();
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
            ButtonCreate.Text = "Самолёт добавлен";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
            airCraftBindingSource.AddNew();
        }

        private void business_Class_CapacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back && l != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void economy_Class_CapacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back && l != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
