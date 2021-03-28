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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "" && PasswordField.Text == "")
            {
                MessageBox.Show("Введите данные", "Warning");
            }
            if (LoginField.Text != "" && PasswordField.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "Select Password from [Users] where Login = '" + LoginField.Text + "'";
                        string Password = Convert.ToString(cmd.ExecuteScalar());
                        if (Password != "")
                        {
                            if (PasswordField.Text == Password)
                            {
                                cmd.CommandText = "Select [Role ID] from [Users] where Login = '" + LoginField.Text + "'";
                                string RoleID = Convert.ToString(cmd.ExecuteScalar());
                                string Login = Convert.ToString(LoginField.Text);
                                switch (RoleID)
                                {
                                    case "0":
                                        {
                                            AdminMenu Menu = new AdminMenu(Login);
                                            this.Hide();
                                            Menu.ShowDialog();
                                            if (Menu.DialogResult == DialogResult.Cancel)
                                            {
                                                Application.Exit();
                                            }
                                            LoginField.Clear();
                                            PasswordField.Clear();
                                            this.Show();
                                        }

                                        break;
                                    case "1":
                                        {
                                            AdminMenu Menu = new AdminMenu(Login);
                                            this.Hide();
                                            Menu.ShowDialog();
                                            if (Menu.DialogResult == DialogResult.Cancel)
                                            {
                                                Application.Exit();
                                            }
                                            LoginField.Clear();
                                            PasswordField.Clear();
                                            this.Show();
                                        }
                                        break;

                                    case "2":
                                        {
                                            AdminMenu Menu = new AdminMenu(Login);
                                            this.Hide();
                                            Menu.ShowDialog();
                                            if (Menu.DialogResult == DialogResult.Cancel)
                                            {
                                                Application.Exit();
                                            }
                                            LoginField.Clear();
                                            PasswordField.Clear();
                                            this.Show();
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пароль не верен", "Warning");
                            }
                        }
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            char l = e.KeyChar;
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back && l != '.')
            {
                e.Handled = true;
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
