using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlightBookingForms
{
    public partial class PrimaryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        bool Choice = false;
        City[] CurrentCity = new City[0];
        public PrimaryForm()
        {
            InitializeComponent();
            ReaderCity();
            ButtonCurrency.Items.AddRange(new string[] { "RUB     Рубль", "EUR     Евро", "USD     Доллар", "KZT     Юань", "UAH     Гривна" });
            DepartureDateTimer.Value = DateTime.Today;
            ArrivalDateTimer.Value = DateTime.Today;
        }

        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            StartForm Authorization = new StartForm();
            this.Hide();
            Authorization.ShowDialog();
            if (Authorization.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void DepartureDateTimer_ValueChanged(object sender, EventArgs e)
        {
            if (DepartureDateTimer.Value < DateTime.Now && Choice)
            {
                MessageBox.Show("Дата отправления не может быть меньше текущей", "Warning");
                DepartureDateTimer.Value = DateTime.Now;
            }
            else
            {
                Choice = true;
            }
            ArrivalDateTimer.Value = DepartureDateTimer.Value;
        }

        private void ArrivalDateTimer_ValueChanged(object sender, EventArgs e)
        {
            if (ArrivalDateTimer.Value < DepartureDateTimer.Value)
            {
                MessageBox.Show("Дата возвращения должна быть больше Даты отправления", "Warning");
                ArrivalDateTimer.Value = DepartureDateTimer.Value;
            }
        }

        private void ReaderCity()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From City ORDER BY Name", con);
            reader = cum.ExecuteReader();
            for (int i = 0; reader.Read(); i++)
            {
                OriginCityID.Items.AddRange(new string[] { (string)reader["Name"] });
                Array.Resize(ref CurrentCity, i + 1);
                CurrentCity[i] = new City();
                CurrentCity[i].ID = (int)reader["City ID"];
                CurrentCity[i].Name = (string)reader["Name"];
            }
            DestinationCityID.DropDownHeight = 213;
            OriginCityID.DropDownHeight = 213;
            reader.Close();
            con.Close();
        }

        private void OriginCityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestinationCityID.Items.Clear();
            foreach (City city in CurrentCity)
            {
                if (city.Name != Convert.ToString(OriginCityID.Text))
                {
                    DestinationCityID.Items.Add(city.Name);
                }
            }
            PrimaryFormData.OriginID = CurrentCity[OriginCityID.SelectedIndex].ID;
        }

        private void DestinationCityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimaryFormData.DestinationID = OriginCityID.SelectedIndex > DestinationCityID.SelectedIndex ? CurrentCity[DestinationCityID.SelectedIndex].ID : CurrentCity[DestinationCityID.SelectedIndex + 1].ID;
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (OriginCityID.Text != "" && DestinationCityID.Text != "")
                {
                    PrimaryFormData.OriginCityID = OriginCityID.Text;
                    PrimaryFormData.DestinationCityID = DestinationCityID.Text;
                    PrimaryFormData.DepartureDateTimer = DepartureDateTimer.Value;
                    PrimaryFormData.ArrivalDateTimer = ArrivalDateTimer.Value;
                    PrimaryRegistration Registration = new PrimaryRegistration();
                    this.Hide();
                    Registration.ShowDialog();
                    if (Registration.DialogResult == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Заполните поля", "Warning");
                }
            }
            catch (System.ObjectDisposedException)
            {
                Application.Restart();
            }
        }

        private void PrimaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);

        }

        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flightBookingDNB.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.flightBookingDNB.City);

        }
    }
}
