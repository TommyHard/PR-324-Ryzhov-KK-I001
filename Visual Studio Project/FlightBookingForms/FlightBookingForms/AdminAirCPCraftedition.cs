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
    public partial class AdminAirCPCraftedition : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        AirPorts[] CurrentAirPorts = new AirPorts[0];
        int AirPortIDD;

        public AdminAirCPCraftedition(AirCrafts newAirCrafts)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM AirCraft WHERE [AirCraft ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", newAirCrafts.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                airCraft_IDLabel1.Text = reader["AirCraft ID"].ToString();
                airPort_IDTextBox.Text = reader["AirPort ID"].ToString();
                airCraft_NameTextBox.Text = reader["AirCraft Name"].ToString();
                business_Class_CapacityTextBox.Text = reader["Business Class Capacity"].ToString();
                economy_Class_CapacityTextBox.Text = reader["Economy Class Capacity"].ToString();
            }
            reader.Close();
            con.Close();

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
                if (CurrentAirPorts[i].ID.ToString() == airPort_IDTextBox.Text)
                {
                    AirPortIDD = i;
                }
            }
            reader.Close();
            con.Close();
            AirPortsComboBox.SelectedIndex = AirPortIDD;
            AirPortsComboBox.DropDownHeight = 213;
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            airPort_IDTextBox.Text = CurrentAirPorts[AirPortsComboBox.SelectedIndex].ID.ToString();
            if (airCraft_NameTextBox.Text != "" && airPort_IDTextBox.Text != "" && business_Class_CapacityTextBox.Text != "" && economy_Class_CapacityTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("SELECT Count(*) FROM AirCraft WHERE [AirPort ID]=@AirPortID and [AirCraft Name]=@Name AND NOT [AirCraft ID]=@AirCraftID", con))
                    {
                        cum.Parameters.AddWithValue("@AirCraftID", airCraft_IDLabel1.Text);
                        cum.Parameters.AddWithValue("@AirPortID", airPort_IDTextBox.Text);
                        cum.Parameters.AddWithValue("@Name", airCraft_NameTextBox.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Самолёт уже есть в списке этого аэропорта!", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("UPDATE AirCraft SET [AirPort ID]=@AirPortID, [AirCraft Name]=@Name, [Business Class Capacity]=@Business, [Economy Class Capacity]=@Economy WHERE [AirCraft ID]=@id", con);
                            cum.Parameters.AddWithValue("@id", airCraft_IDLabel1.Text);
                            cum.Parameters.AddWithValue("@AirPortID", airPort_IDTextBox.Text);
                            cum.Parameters.AddWithValue("@Name", airCraft_NameTextBox.Text);
                            cum.Parameters.AddWithValue("@Business", business_Class_CapacityTextBox.Text);
                            cum.Parameters.AddWithValue("@Economy", economy_Class_CapacityTextBox.Text);
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

        private void airCraft_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && (l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"' && l != '-'))
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
