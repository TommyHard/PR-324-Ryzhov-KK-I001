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
using System.IO;
using System.Net.Mail;
using System.Net;

namespace FlightBookingForms
{
    public partial class PrimaryRegistration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TommyHard;Initial Catalog=FlightBookingPC;Integrated Security=True");
        SqlCommand cum = new SqlCommand();
        SqlDataReader reader;
        int FlightIDD = -1;
        int RateID;
        int BookedTicketID;
        int PaymentsID;
        int PassengerID = -1;
        bool Crutch = true;
        decimal [] Costs = new decimal[5];
        SeatNumber[] CurrentSeat = new SeatNumber[0];
        public PrimaryRegistration()
        {
            InitializeComponent();
            Visibility(false);
            MessageBox.Show("После заполнения всех полей необходимо нажать кнопку 'Внести данные'!", "Warning");
            TimerLanguage.Start();
            FillLabel();
            FlightReader();
            if (FlightIDD != -1)
            {
                FlightCosttt.Text = "Итого к оплате по карте: " + Costs[0].ToString().Replace(",0000", "") + " ₽";
                Costs[4] = Costs[0];
            }
        }

        private void Visibility(bool YN)
        {
            FlightTable.Enabled = YN;
            TravelClass.Enabled = YN;
            FlightSeatID.Enabled = YN;
            HandBaggageCheckBox.Enabled = YN;
            BaggageCheckBox.Enabled = YN;
            DateBox.Enabled = YN;
            OwnerBox.Enabled = YN;
            PayNumberBox.Enabled = YN;
            cvcBox.Enabled = YN;
            ButtonCreate.Enabled = YN; // оформить
            PayNumberLabel.Visible = YN;
            DateLabel.Visible = YN;
            OwnerLabel.Visible = YN;
            cvcLabel.Visible = YN;
        }

        private void EnabledCheck()
        {
            email_AddressBox.Enabled = false;
            phone_NumberBox.Enabled = false;
            seriesPassportTextBox.Enabled = false;
            SexPanel.Enabled = false;
            citizenshipBox.Enabled = false;
            PassportExpirationDate.Enabled = false;
            FirstNameBox.Enabled = false;
            PatronymicBox.Enabled = false;
            SurnameBox.Enabled = false;
        }

        private void FillLabel()
        {
            OriginCityID.Text = PrimaryFormData.OriginCityID;
            DestinationCityID.Text = PrimaryFormData.DestinationCityID;
            DepaartureDateLabel.Text = PrimaryFormData.DepartureDateTimer.ToString("dd.MM.yyyy");
            ArrivalDateLabel.Text = PrimaryFormData.ArrivalDateTimer.ToString("dd.MM.yyyy"); ;
        }

        private void FlightReader()
        {
            con.Open();
            cum = new SqlCommand("SELECT * From [Flight Schedules] WHERE [Origin City ID] = @OriginCityID AND [Destination City ID] = @DestinationCityID AND [Departure Date Time] >= @DepartureTime", con);
            cum.Parameters.AddWithValue("@OriginCityID", PrimaryFormData.OriginID);
            cum.Parameters.AddWithValue("@DestinationCityID", PrimaryFormData.DestinationID);
            cum.Parameters.AddWithValue("@DepartureTime", PrimaryFormData.DepartureDateTimer);
            reader = cum.ExecuteReader();
            while (reader.Read())
            {
                FlightTable.Rows.Add(new object[] { PrimaryFormData.OriginCityID, PrimaryFormData.DestinationCityID, Convert.ToDateTime(reader["Departure Date Time"]).ToString("dd.MM.yyyy") });
                FlightIDD = (int)reader["Flight ID"];
            }
            reader.Close();
            ReadCosts();
        }

        private void ReadCosts()
        {
            cum = new SqlCommand("SELECT * From [Flight Costs] WHERE [Flight ID] = @FlightID", con);
            cum.Parameters.AddWithValue("@FlightID", FlightIDD);
            reader = cum.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Costs[0] = (decimal)reader["Flight Cost"];
            }
            reader.Close();
            ReadRate();
        }

        private void ReadRate()
        {
            cum = new SqlCommand("SELECT * From Rate", con);
            reader = cum.ExecuteReader();
            for (int i = 1; reader.Read(); i++)
            {
                Costs[i] = (decimal)reader["Cost"];
            }
            reader.Close();
            con.Close();
        }

        private void ReaderSeat(string FlightClass)
        {
            if (FlightIDD != -1)
            {
                FlightSeatID.Items.Clear();
                con.Open();
                cum = new SqlCommand("SELECT * From [Seat Number] WHERE [Flight ID] = @FlightID AND [Travel Class] = @TravelClass AND Free = 'Yes'", con);
                cum.Parameters.AddWithValue("@FlightID", FlightIDD);
                cum.Parameters.AddWithValue("@TravelClass", FlightClass);
                reader = cum.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    FlightSeatID.Items.AddRange(new string[] { (string)reader["Seat Number"] });
                    Array.Resize(ref CurrentSeat, i + 1);
                    CurrentSeat[i] = new SeatNumber();
                    CurrentSeat[i].SeatID = (int)reader["Seat ID"];
                }
                FlightSeatID.DropDownHeight = 213;
                reader.Close();
                con.Close();
            }
        }

        private void ButtonBackWards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonSuccessfully_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Внимание! Перепроверьте данные и только после этого подтверждайте действие!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                String sDate = Convert.ToString(PassportExpirationDate.Value);
                DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
                String year = datevalue.Year.ToString();
                int today = DateTime.Now.Year;
                if (first_NameTextBox.Text != "" && surnameTextBox.Text != "" && citizenshipTextBox.Text != "")
                {
                    if (phone_NumberTextBox.Text.Length == 18)
                    {
                        if (series_and_number_of_passportTextBox.Text.Length == 11)
                        {
                            if (genderTextBox.Text != "")
                            {
                                if (today - (Convert.ToInt32(year)) > 15)
                                {
                                    try
                                    {
                                        using (cum = new SqlCommand("INSERT INTO Passengers([First Name], Patronymic, Surname, [Phone Number], [Email Address], Gender, Citizenship, [Series and number of passport], [Passport expiration date]) SELECT @Name, @Patronymic, @Surname, @Phone, @Email, @Gender, @Citizenship, @Series, @Expiration  WHERE NOT EXISTS (SELECT 1 FROM Passengers WHERE [Email Address]=@Email OR [Phone Number]=@Phone) SELECT SCOPE_IDENTITY()", con))
                                        {
                                            cum.Parameters.AddWithValue("@Name", first_NameTextBox.Text);
                                            cum.Parameters.AddWithValue("@Patronymic", patronymicTextBox.Text);
                                            cum.Parameters.AddWithValue("@Surname", surnameTextBox.Text);
                                            cum.Parameters.AddWithValue("@Phone", phone_NumberTextBox.Text);
                                            cum.Parameters.AddWithValue("@Email", email_AddressTextBox.Text);
                                            cum.Parameters.AddWithValue("@Gender", genderTextBox.Text);
                                            cum.Parameters.AddWithValue("@Citizenship", citizenshipTextBox.Text);
                                            cum.Parameters.AddWithValue("@Series", series_and_number_of_passportTextBox.Text);
                                            cum.Parameters.AddWithValue("@Expiration", passport_expiration_dateDateTimePicker.Value);
                                            con.Open();
                                            if ((PassengerID = Convert.ToInt32(cum.ExecuteScalar())) == -1)
                                            {
                                                MessageBox.Show("Логин и/или номер телефона занят!", "Warning");
                                            }
                                            else
                                            {
                                                Crutch = false;
                                                ButtonSuccessfully.Enabled = false;
                                                Visibility(true);
                                                EnabledCheck();
                                            }
                                        }
                                    }
                                    finally
                                    {
                                        con.Close();
                                    }
                                }
                                else MessageBox.Show("Лица младше 15 лет на допускаются к перелёту!", "Warning");
                            }
                            else MessageBox.Show("Выберите пол!", "Warning");
                        }
                        else MessageBox.Show("Заполните поле 'Серия и номер паспорта' до конца!", "Warning");
                    }
                    else MessageBox.Show("Заполните поле 'Телефон' до конца!", "Warning");
                }
                else MessageBox.Show("Заполните поля!", "Warning");
            }
            else { return; }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Внимание! Сумма будет списана в полном объёме, желаете продолжить?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (FlightSeatID.SelectedIndex >= 0)
                {
                    if (PayNumberBox.Text != "")
                    {
                        if (DateBox.Text != "")
                        {
                            if (OwnerBox.Text != "")
                            {
                                if (cvcBox.Text != "")
                                {
                                    cum = new SqlCommand("UPDATE [Seat Number] SET Free = 'No' WHERE [Seat ID]=@id", con);
                                    con.Open();
                                    cum.Parameters.AddWithValue("@id", CurrentSeat[FlightSeatID.SelectedIndex].SeatID);
                                    cum.ExecuteNonQuery();
                                    con.Close();
                                    //
                                    cum = new SqlCommand("INSERT INTO Payments([Payment Date], [Payment Amount]) SELECT @DateP, @Amount SELECT SCOPE_IDENTITY()", con);
                                    con.Open();
                                    cum.Parameters.AddWithValue("@DateP", DateTime.Today);
                                    cum.Parameters.AddWithValue("@Amount", Costs[4]);
                                    PaymentsID = Convert.ToInt32(cum.ExecuteScalar());
                                    con.Close();
                                    //
                                    cum = new SqlCommand("INSERT INTO [Booked Ticket]([Passenger ID], [Flight ID], [Rate ID], [Seat ID], [Ticket Cost], [Date Reservation]) SELECT @PassengerID, @FlightID, @RateID, @SeatID, @TicketCost, @DateServ SELECT SCOPE_IDENTITY()", con);
                                    con.Open();
                                    cum.Parameters.AddWithValue("@PassengerID", PassengerID);
                                    cum.Parameters.AddWithValue("@FlightID", FlightIDD);
                                    cum.Parameters.AddWithValue("@RateID", RateID);
                                    cum.Parameters.AddWithValue("@SeatID", CurrentSeat[FlightSeatID.SelectedIndex].SeatID);
                                    cum.Parameters.AddWithValue("@TicketCost", Costs[4]);
                                    cum.Parameters.AddWithValue("@DateServ", DateTime.Today);
                                    BookedTicketID = Convert.ToInt32(cum.ExecuteScalar());
                                    con.Close();
                                    //
                                    cum = new SqlCommand("INSERT INTO [Reservation Payments]([Reservation ID], [Payment ID]) SELECT @Reserv, @Payment", con);
                                    con.Open();
                                    cum.Parameters.AddWithValue("@Reserv", BookedTicketID);
                                    cum.Parameters.AddWithValue("@Payment", PaymentsID);
                                    cum.ExecuteNonQuery();
                                    con.Close();
                                    //
                                    ButtonCreate.Enabled = false;

                                    DialogResult respaswn = new DialogResult();
                                    respaswn = MessageBox.Show("Желаете сохранить билет в формате pdf ?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (respaswn == DialogResult.Yes)
                                    {
                                        PdfCreator();
                                    }
                                    else Succsesfull2();
                                }
                                else MessageBox.Show("Заполните данные по карте!", "Warning");
                            }
                            else MessageBox.Show("Заполните данные по карте!", "Warning");
                        }
                        else MessageBox.Show("Заполните данные по карте!", "Warning");
                    }
                    else MessageBox.Show("Заполните данные по карте!", "Warning");
                }
                else MessageBox.Show("Выберите посадочное место!", "Warning");
            }
            else { return; }
        }

        private void PdfCreator()
        {
            var document = new iTextSharp.text.Document();
            var document1 = new iTextSharp.text.Document();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF|*.pdf";
            saveFile.Title = "Save as PDF File";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(saveFile.FileName, FileMode.Create)))
                {
                    document.OpenDocument();
                    var logo = iTextSharp.text.Image.GetInstance(new FileStream(@"C:\Users\TommyHard\Desktop\GG\Assets\MAKET.jpg", FileMode.Open));
                    logo.SetAbsolutePosition(absoluteX: 25, absoluteY: 50);
                    logo.ScaleToFit(550, 900);
                    writer.DirectContent.AddImage(logo);
                    document.Close();
                    writer.Close();
                }
            }
            using (var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document1, new FileStream(@"C:\Users\TommyHard\Desktop\GG\pdf\pdf.pdf", FileMode.Create)))
            {
                document1.OpenDocument();
                var logo = iTextSharp.text.Image.GetInstance(new FileStream(@"C:\Users\TommyHard\Desktop\GG\Assets\MAKET1.jpg", FileMode.Open));
                logo.SetAbsolutePosition(absoluteX: 25, absoluteY: 50);
                logo.ScaleToFit(550, 900);
                writer.DirectContent.AddImage(logo);
                document1.Close();
                writer.Close();
            }
            Succsesfull1();
        }

        private void Succsesfull1()
        {
            DialogResult respaswn = new DialogResult();
            respaswn = MessageBox.Show("Файл успешно сохранен. Хотите получить его по электронной почте?", "Электронная почта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respaswn == DialogResult.Yes)
            {
                SendMail();
            }
        }

        private void Succsesfull2()
        {
            DialogResult respaswn = new DialogResult();
            respaswn = MessageBox.Show("Хотите получить билет по электронной почте?", "Электронная почта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respaswn == DialogResult.Yes)
            {
                SendMail();
            }
        }

        private void SendMail()
        {
            MailAddress from = new MailAddress("tommyhardo1488@gmail.com", "Бронирование авиабилетов (TommyHard)"); // адрес и нейм
            MailAddress to = new MailAddress("kirill.prototype.456v01@gmail.com"); // kuda
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Купленный билет"; // theme
            m.Body = "<h2>Электронный билет на самолёт</h2>" + "<br>Данное сообщение было отправлено автоматически, на него не нужно отвечать.</br>"; // text
            m.Attachments.Add(new Attachment(@"C:\Users\TommyHard\Desktop\GG\pdf\pdf.pdf"));
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // gmail
            smtp.Credentials = new NetworkCredential("tommyhardo1488@gmail.com", "XITman456"); // login, passoword
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }


        private void email_AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            char l = e.KeyChar;
            if (!Regex.Match(c, @"[a-zA-Z]|[0-9]").Success && e.KeyChar != (char)Keys.Back && l != '.' && l != '@' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void phone_NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void seriesPassportTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void citizenshipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            char l = e.KeyChar;
            if (!Regex.Match(c, @"[a-zA-Z]").Success && (l < 'А' || l > 'я') && e.KeyChar != (char)Keys.Back && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void PatronymicBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void SurnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != (char)Keys.Back && l != (char)Keys.Space && l != 'ё' && l != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightBookingDNB);
        }

        private void TimerLanguage_Tick(object sender, EventArgs e)
        {
            if (Crutch == true)
            {
                if (email_AddressBox.Text != "" && phone_NumberBox.Text != "" && seriesPassportTextBox.Text != "" && genderTextBox.Text != "" && citizenshipBox.Text != "" && FirstNameBox.Text != "" && SurnameBox.Text != "")
                {
                    ButtonSuccessfully.Enabled = true;
                }
                else ButtonSuccessfully.Enabled = false;
            }

            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;

            if (myCurrentLanguage != null)
                LanLabel.Text = "Ваша раскладка: " + myCurrentLanguage.LayoutName;
        }

        private void PayNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void DateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void OwnerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            char l = e.KeyChar;
            if (!Regex.Match(c, @"[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void cvcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!Char.IsDigit(l) && l != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void PayNumberBox_TextChanged(object sender, EventArgs e)
        {
            PayNumberBox.MaxLength = 19;
            string text;
            text = PayNumberBox.Text;
            if (text.Length == 4)
            {
                PayNumberBox.Text = PayNumberBox.Text + " ";
                PayNumberBox.SelectionStart = PayNumberBox.Text.Length;
            }

            if (text.Length == 9)
            {
                PayNumberBox.Text = PayNumberBox.Text + " ";
                PayNumberBox.SelectionStart = PayNumberBox.Text.Length;
            }

            if (text.Length == 14)
            {
                PayNumberBox.Text = PayNumberBox.Text + " ";
                PayNumberBox.SelectionStart = PayNumberBox.Text.Length;
            }
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {
            DateBox.MaxLength = 7;
            string text;
            text = DateBox.Text;
            if (text.Length == 2)
            {
                DateBox.Text += " / ";
                DateBox.SelectionStart = DateBox.Text.Length;
            }
        }

        private void BusinessClass_CheckedChanged(object sender, EventArgs e)
        {
            ReaderSeat("Business");
        }

        private void EconomyClass_CheckedChanged(object sender, EventArgs e)
        {
            ReaderSeat("Economy");
        }

        private void SexButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            genderTextBox.Text = "Мужской";
        }

        private void SexButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            genderTextBox.Text = "Женский";
        }

        private void PassportExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            passport_expiration_dateDateTimePicker.Value = PassportExpirationDate.Value;
        }

        private void email_AddressBox_TextChanged(object sender, EventArgs e)
        {
            email_AddressTextBox.Text = email_AddressBox.Text;
        }

        private void citizenshipBox_TextChanged(object sender, EventArgs e)
        {
            citizenshipTextBox.Text = citizenshipBox.Text;
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            first_NameTextBox.Text = FirstNameBox.Text;
        }

        private void PatronymicBox_TextChanged(object sender, EventArgs e)
        {
            patronymicTextBox.Text = PatronymicBox.Text;
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            surnameTextBox.Text = SurnameBox.Text;
        }

        private void HandBaggageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FlightIDD != -1)
            {
                if (HandBaggageCheckBox.Checked && BaggageCheckBox.Checked)
                {
                    Costs[4] = Costs[0] + Costs[3];
                    RateID = 2;
                }
                else if (BaggageCheckBox.Checked)
                {
                    Costs[4] = Costs[0] + Costs[2];
                    RateID = 1;
                }
                else if (HandBaggageCheckBox.Checked)
                {
                    Costs[4] = Costs[0] + Costs[1];
                    RateID = 0;
                }
                else
                {
                    Costs[4] = Costs[0];
                    RateID = 3;
                }
                FlightCosttt.Text = "Итого к оплате по карте: " + Costs[4].ToString().Replace(",0000", "") + " ₽";
            }
        }

        private void phone_NumberBox_TextChanged(object sender, EventArgs e)
        {
            phone_NumberBox.MaxLength = 18;
            string text;
            text = phone_NumberBox.Text;
            if (text.Length == 1)
            {
                phone_NumberBox.Text = "(" + phone_NumberBox.Text;
                phone_NumberBox.SelectionStart = phone_NumberBox.Text.Length;
            }

            if (text.Length == 4)
            {
                phone_NumberBox.Text = phone_NumberBox.Text + ")";
                phone_NumberBox.SelectionStart = phone_NumberBox.Text.Length;
            }

            if (text.Length == 8)
            {
                phone_NumberBox.Text = phone_NumberBox.Text + " - ";
                phone_NumberBox.SelectionStart = phone_NumberBox.Text.Length;
            }

            if (text.Length == 13)
            {
                phone_NumberBox.Text = phone_NumberBox.Text + " - ";
                phone_NumberBox.SelectionStart = phone_NumberBox.Text.Length;
            }

            if (text.Length == 18)
            {
                phone_NumberTextBox.Text = phone_NumberBox.Text;
            }
        }

        private void seriesPassportTextBox_TextChanged(object sender, EventArgs e)
        {
            seriesPassportTextBox.MaxLength = 11;
            string text;
            text = seriesPassportTextBox.Text;
            if (text.Length == 4)
            {
                seriesPassportTextBox.Text = seriesPassportTextBox.Text + " ";
                seriesPassportTextBox.SelectionStart = seriesPassportTextBox.Text.Length;
            }

            if (text.Length == 11)
            {
                series_and_number_of_passportTextBox.Text = seriesPassportTextBox.Text;
            }
        }
    }
}
