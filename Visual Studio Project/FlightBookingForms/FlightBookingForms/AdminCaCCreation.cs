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
    public partial class AdminCaCCreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();

        public AdminCaCCreation()
        {
            InitializeComponent();
            TimerLanguage.Start();
            countryBindingSource.AddNew();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                try
                {
                    using (cum = new SqlCommand("INSERT INTO Country(Name) SELECT @Name WHERE NOT EXISTS (SELECT 1 FROM Country WHERE Name = @Name)", con))
                    {
                        cum.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        con.Open();
                        if (cum.ExecuteNonQuery() <= 0)
                        {
                            MessageBox.Show("Страна с таким названием уже существует!", "Warning");
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

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё' && l != '"' && l != '-')
            {
                e.Handled = true;
            }
        }

        private async void ChangeText()
        {
            ButtonCreate.Enabled = false;
            ButtonCreate.Text = "Страна добавлена";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
            countryBindingSource.AddNew();
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
