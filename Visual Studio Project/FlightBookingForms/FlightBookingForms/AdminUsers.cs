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

namespace FlightBookingForms
{
    public partial class AdminUsers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();

        public AdminUsers()
        {
            InitializeComponent();
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonCreation_Click(object sender, EventArgs e)
        {
            AdminUsersCreation Creation = new AdminUsersCreation();
            this.Hide();
            Creation.ShowDialog();
            if (Creation.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.usersTableAdapter.Fill(this.flightBookingDBA.Users);
        }

        private void ButtonRemoving_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User();
                newUser.Login = Convert.ToString(UsersTable["dataGridViewTextBoxColumn8", UsersTable.CurrentCell.RowIndex].Value);
                if (Restriction.LoginNext == newUser.Login)
                {
                    MessageBox.Show("Суицид запрещён!", "Warning");
                }
                else
                {
                    DialogResult res = new DialogResult();
                    res = MessageBox.Show("Подтвердите удаление", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        usersBindingSource.RemoveCurrent();
                        AdminUsers_Load();
                    }
                    else { return; }
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Данных для удаления нет!", "Warning");
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            User newUser = new User();
            newUser.ID = Convert.ToInt32(UsersTable["dataGridViewTextBoxColumn1", UsersTable.CurrentCell.RowIndex].Value);
            newLogin.Logins = Convert.ToString(UsersTable["dataGridViewTextBoxColumn8", UsersTable.CurrentCell.RowIndex].Value);
            if (Restriction.LoginNext == newLogin.Logins)
            {
                FSP CurrentUser = new FSP();
                AdminPersonalArea Area = new AdminPersonalArea(CurrentUser);
                this.Hide();
                Area.ShowDialog();
                this.Show();
                this.usersTableAdapter.Fill(this.flightBookingDBA.Users);
            }
            else
            {
            AdminUsersEditing Editing = new AdminUsersEditing(newUser);
            this.Hide();
            Editing.ShowDialog();
            if (Editing.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
            this.usersTableAdapter.Fill(this.flightBookingDBA.Users);
            }
        }

        private void AdminUsers_Load()
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(flightBookingDBA);
            usersTableAdapter.Fill(this.flightBookingDBA.Users);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDBA);

        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.flightBookingDBA.Users);
        }
    }
}
