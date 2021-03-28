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
    public partial class AdminUsersCreation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        User[] CurrentUsers = new User[0];

        public AdminUsersCreation()
        {
            InitializeComponent();
            TimerLanguage.Start();
            Roles();
            usersBindingSource.AddNew();
        }

        private void Roles()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From Roles ORDER BY Name", con);
            reader = cum.ExecuteReader();
            while (reader.Read())
            {
                if (Restriction.RoleIDD < (int)reader["Role ID"])
                {
                    role_IDComboBox.Items.AddRange(new string[] { (string)reader["Name"] });
                }
            }
            reader.Close();
            con.Close();
            role_IDComboBox.DropDownHeight = 213;
        }

        private void ButtonRdnPassword_Click(object sender, EventArgs e)
        {
            string Password = "";
            Random Rnd = new Random();
            while (Password.Length < 8)
            {
                Char c = (char)Rnd.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    Password += c;
            }
            passwordTextBox.Text = Password;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            role_IDTextBox.Text = role_IDComboBox.SelectedIndex.ToString();
            if (loginTextBox.Text != "" && surnameTextBox.Text != "" && first_NameTextBox.Text != "" && passwordTextBox.Text != "" && role_IDTextBox.Text != "" && role_IDComboBox.Text != "")
            {
                if (loginTextBox.Text.Length > 4)
                {
                    if (passwordTextBox.Text.Length > 7)
                    {
                        try
                        {
                            using (cum = new SqlCommand("INSERT INTO Users(Login,Password,[Role ID],[First Name],Surname,Patronymic) SELECT @Login, @Passoword, @RoleID, @FirstName, @Surname, @Patronymic  WHERE NOT EXISTS (SELECT 1 FROM Users WHERE Login = @Login)", con))
                            {
                                cum.Parameters.AddWithValue("@Login", loginTextBox.Text);
                                cum.Parameters.AddWithValue("@Passoword", passwordTextBox.Text);
                                cum.Parameters.AddWithValue("@RoleID", Restriction.RoleIDD == 0 ? Convert.ToInt32(role_IDTextBox.Text) + 1 : Convert.ToInt32(role_IDTextBox.Text) + 2);
                                cum.Parameters.AddWithValue("@FirstName", first_NameTextBox.Text);
                                cum.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
                                cum.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                                con.Open();
                                if (cum.ExecuteNonQuery() <= 0)
                                {
                                    MessageBox.Show("Данный логин занят!", "Warning");
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
                    else MessageBox.Show("Пароль должен быть более 8 символов", "Warning");
                }
                else MessageBox.Show("Логин должен быть более 5 символов", "Warning");
            }
            else MessageBox.Show("Заполните поля", "Warning");
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void first_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        string CopiedPassword;
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "")
            {
                CopiedPassword = passwordTextBox.Text;
                CopiedTextPassword();
                Clipboard.SetText(CopiedPassword);
            }
        }

        string CopiedLogin;
        private void ButtonCopyLogin_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "")
            {
                CopiedLogin = loginTextBox.Text;
                CopiedTextLogin();
                Clipboard.SetText(CopiedLogin);
            }
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private async void CopiedTextPassword()
        {
            passwordTextBox.Enabled = false;
            passwordTextBox.Text = "Скопировано";
            await Task.Delay(1500);
            passwordTextBox.Text = CopiedPassword;
            passwordTextBox.Enabled = true;
        }

        private async void CopiedTextLogin()
        {
            loginTextBox.Enabled = false;
            loginTextBox.Text = "Скопировано";
            await Task.Delay(1500);
            loginTextBox.Text = CopiedLogin;
            loginTextBox.Enabled = true;
        }

        private async void ChangeText()
        {
            ButtonCreate.Enabled = false;
            ButtonCreate.Text = "Пользователь добавлен";
            await Task.Delay(3000);
            ButtonCreate.Text = "Добавить";
            ButtonCreate.Enabled = true;
            usersBindingSource.AddNew();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.FlightBookingDNB);
        }
    }
}
