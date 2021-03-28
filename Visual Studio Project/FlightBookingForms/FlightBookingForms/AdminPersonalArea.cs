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
    public partial class AdminPersonalArea : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        FSP thisUser;

        public AdminPersonalArea(FSP CurrentUser)
        {
            InitializeComponent();
            thisUser = CurrentUser;
            //
            SqlCommand Command = new SqlCommand("SELECT * FROM Users WHERE Login=@login", con);
            Command.Parameters.AddWithValue("@login", Restriction.LoginNext);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                user_IDLabel2.Text = reader["User ID"].ToString();
                role_IDLabel2.Text = reader["Role ID"].ToString();
                loginLabel2.Text = reader["Login"].ToString();
                passwordTextBox.Text = reader["Password"].ToString();
                first_NameTextBox.Text = reader["First Name"].ToString();
                surnameTextBox.Text = reader["Surname"].ToString();
                patronymicTextBox.Text = reader["Patronymic"].ToString();
            }
            if (role_IDLabel2.Text == "0")
            {
                RoleIDLabel.Text = "Главный администратор";
            }
            if (role_IDLabel2.Text == "1")
            {
                RoleIDLabel.Text = "Администратор";
            }
            if (role_IDLabel2.Text == "2")
            {
                RoleIDLabel.Text = "Менеджер";
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
            thisUser.FirstName = first_NameTextBox.Text;
            thisUser.Patronymic = patronymicTextBox.Text;
            thisUser.Surname = surnameTextBox.Text;
            nameTextBox.Text = $"{surnameTextBox.Text} {first_NameTextBox.Text} {patronymicTextBox.Text}";
            usersBindingSource.EndEdit();
            string UpdateUser = "UPDATE Users SET Login=@Login, Password=@Password, Surname=@Surname, [Role ID]=@RoleID, [First Name]=@Name, Patronymic=@Patronymic WHERE [User ID]=@id";
            {
                SqlCommand Command = new SqlCommand(UpdateUser, con);
                Command.Parameters.AddWithValue("@id", user_IDLabel2.Text);
                Command.Parameters.AddWithValue("@Login", loginLabel2.Text);
                Command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                Command.Parameters.AddWithValue("@RoleID", role_IDLabel2.Text);
                Command.Parameters.AddWithValue("@Name", first_NameTextBox.Text);
                Command.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
                Command.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                con.Open();
                Command.ExecuteNonQuery();
                con.Close();
                ChangeText();
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

        private void AdminPersonalArea_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = $"{surnameTextBox.Text} {first_NameTextBox.Text} {patronymicTextBox.Text}";
        }

        private async void ChangeText()
        {
            ButtonSave.Enabled = false;
            ButtonSave.Text = "Данные обновлены";
            await Task.Delay(3000);
            ButtonSave.Enabled = true;
            ButtonSave.Text = "Сохранить и обновить";

        }
    }
}
