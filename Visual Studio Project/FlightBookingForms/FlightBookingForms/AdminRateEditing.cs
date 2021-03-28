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
    public partial class AdminRateEditing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();

        public AdminRateEditing(Rate newRate)
        {
            InitializeComponent();
            TimerLanguage.Start();
            string SelectRealtyInfo = "SELECT * FROM Rate WHERE [Rate ID]=@id";
            SqlCommand Command = new SqlCommand(SelectRealtyInfo, con);
            Command.Parameters.AddWithValue("@id", newRate.ID);
            con.Open();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                rate_IDLabel1.Text = reader["Rate ID"].ToString();
                hand_luggageLabel1.Text = reader["Hand luggage"].ToString();
                baggageLabel1.Text = reader["Baggage"].ToString();
                costTextBox.Text = reader["Cost"].ToString().Replace(",0000", "");
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
            con.Open();
            cum = new SqlCommand("UPDATE Rate SET [Hand luggage]=@Hand, Baggage=@Baggage, Cost=@Cost WHERE [Rate ID]=@id", con);
            cum.Parameters.AddWithValue("@id", rate_IDLabel1.Text);
            cum.Parameters.AddWithValue("@Hand", hand_luggageLabel1.Text);
            cum.Parameters.AddWithValue("@Baggage", baggageLabel1.Text);
            cum.Parameters.AddWithValue("@Cost", costTextBox.Text);
            cum.ExecuteNonQuery();
            con.Close();
            ChangeText();
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back && l != (char)Keys.Space)
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

        private void rateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }
    }
}
