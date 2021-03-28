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
    public partial class AdminCaCEditing : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();

        public AdminCaCEditing(Country NewCountry)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM Country WHERE [Country ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", NewCountry.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                country_IDLabel1.Text = reader["Country ID"].ToString();
                nameTextBox.Text = reader["Name"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                try
                {   
                    using (cum = new SqlCommand("SELECT Count(*) FROM Country WHERE Name=@Name", con))
                    {
                        cum.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Страна с таким названием уже существует!", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("UPDATE Country SET Name=@Name WHERE [Country ID]=@id", con);
                            cum.Parameters.AddWithValue("@id", country_IDLabel1.Text);
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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }
    }
}
