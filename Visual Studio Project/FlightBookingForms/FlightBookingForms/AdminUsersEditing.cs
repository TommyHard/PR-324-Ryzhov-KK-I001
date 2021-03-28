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
    public partial class AdminUsersEditing : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        User[] CurrentUsers = new User[0];
        int CurrentUser;

        public AdminUsersEditing(User NewUser)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM Users WHERE [User ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", NewUser.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                user_IDLabel2.Text = reader["User ID"].ToString();
                role_IDTextBox.Text = reader["Role ID"].ToString();
                loginTextBox.Text = (string)reader["Login"];
                passwordTextBox.Text = (string)reader["Password"];
                first_NameTextBox.Text = (string)reader["First Name"];
                surnameTextBox.Text = (string)reader["Surname"];
                patronymicTextBox.Text = (string)reader["Patronymic"];
            }
            //
            if (Restriction.LoginNext == loginTextBox.Text)
            {
                role_IDComboBox.Enabled = false;
            }
            else
               role_IDComboBox.Enabled = true;
            //
            reader.Close();
            con.Close();

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
            role_IDComboBox.SelectedIndex = Restriction.RoleIDD == 0 ? Convert.ToInt32(role_IDTextBox.Text) - 1 : Convert.ToInt32(role_IDTextBox.Text) - 2;
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

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            role_IDTextBox.Text = role_IDComboBox.SelectedIndex.ToString();
            if (surnameTextBox.Text != "" && first_NameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                if (passwordTextBox.Text.Length > 7)
                {
                    string UpdateUser = "UPDATE Users SET Login=@Login, Password=@Password, Surname=@Surname, [Role ID]=@RoleID, [First Name]=@Name, Patronymic=@Patronymic WHERE [User ID]=@id";
                    {
                        SqlCommand Command = new SqlCommand(UpdateUser, con);
                        Command.Parameters.AddWithValue("@id", user_IDLabel2.Text);
                        Command.Parameters.AddWithValue("@Login", loginTextBox.Text);
                        Command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        Command.Parameters.AddWithValue("@RoleID", Restriction.RoleIDD == 0 ? Convert.ToInt32(role_IDTextBox.Text) + 1 : Convert.ToInt32(role_IDTextBox.Text) + 2);
                        Command.Parameters.AddWithValue("@Name", first_NameTextBox.Text);
                        Command.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
                        Command.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                        con.Open();
                        Command.ExecuteNonQuery();
                        con.Close();
                        ChangeText();
                    }
                }
                else MessageBox.Show("Пароль должен быть более 8 символов", "Warning");
            }
            else MessageBox.Show("Заполните поля", "Warning");
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private async void ChangeText()
        {
            ButtonSave.Enabled = false;
            ButtonSave.Text = "Информация обновлена";
            await Task.Delay(3000);
            ButtonSave.Text = "Сохранить";
            ButtonSave.Enabled = true;
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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);

        }
    }
}
