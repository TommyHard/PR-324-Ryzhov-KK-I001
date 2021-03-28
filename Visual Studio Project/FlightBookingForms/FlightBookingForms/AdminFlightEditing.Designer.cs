
namespace FlightBookingForms
{
    partial class AdminFlightEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label user_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label ArrivalDate;
            System.Windows.Forms.Label DepartureDate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightEditing));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.country_IDTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BoxLine6 = new System.Windows.Forms.PictureBox();
            this.BoxLine5 = new System.Windows.Forms.PictureBox();
            this.flight_SchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_SchedulesTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter();
            this.flight_IDLabel1 = new System.Windows.Forms.Label();
            this.airPort_IDTextBox = new System.Windows.Forms.TextBox();
            this.airCraft_IDTextBox = new System.Windows.Forms.TextBox();
            this.origin_City_IDTextBox = new System.Windows.Forms.TextBox();
            this.destination_City_IDTextBox = new System.Windows.Forms.TextBox();
            this.departure_Date_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrival_Date_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AirPortIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AirCraftIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DestinationCityIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DepartureDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ArrivalDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.OriginCityLocation = new System.Windows.Forms.Label();
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ArrivalDate = new System.Windows.Forms.Label();
            DepartureDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(63, 19);
            user_IDLabel.TabIndex = 48;
            user_IDLabel.Text = "ID рейса";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 104);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(93, 19);
            first_NameLabel.TabIndex = 52;
            first_NameLabel.Text = "ID аэропорта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label1.Location = new System.Drawing.Point(19, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 19);
            label1.TabIndex = 74;
            label1.Text = "ID самолёта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label2.Location = new System.Drawing.Point(19, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 19);
            label2.TabIndex = 80;
            label2.Text = "Город отправления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label3.Location = new System.Drawing.Point(19, 233);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 19);
            label3.TabIndex = 84;
            label3.Text = "Город прибытия";
            // 
            // ArrivalDate
            // 
            ArrivalDate.AutoSize = true;
            ArrivalDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            ArrivalDate.Location = new System.Drawing.Point(19, 319);
            ArrivalDate.Name = "ArrivalDate";
            ArrivalDate.Size = new System.Drawing.Size(106, 19);
            ArrivalDate.TabIndex = 86;
            ArrivalDate.Text = "Дата прибытия";
            // 
            // DepartureDate
            // 
            DepartureDate.AutoSize = true;
            DepartureDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            DepartureDate.Location = new System.Drawing.Point(19, 276);
            DepartureDate.Name = "DepartureDate";
            DepartureDate.Size = new System.Drawing.Size(124, 19);
            DepartureDate.TabIndex = 87;
            DepartureDate.Text = "Дата отправления";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 300;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // ButtonBackWards
            // 
            this.ButtonBackWards.Animated = true;
            this.ButtonBackWards.CheckedState.Parent = this.ButtonBackWards;
            this.ButtonBackWards.CustomImages.Parent = this.ButtonBackWards;
            this.ButtonBackWards.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonBackWards.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonBackWards.ForeColor = System.Drawing.Color.White;
            this.ButtonBackWards.HoverState.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Location = new System.Drawing.Point(23, 12);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(355, 33);
            this.ButtonBackWards.TabIndex = 1;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(23, 126);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(355, 2);
            this.BoxLine4.TabIndex = 59;
            this.BoxLine4.TabStop = false;
            // 
            // flightBookingDBA
            // 
            this.flightBookingDBA.DataSetName = "FlightBookingDBA";
            this.flightBookingDBA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftTableAdapter = null;
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booked_TicketTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Flight_CostsTableAdapter = null;
            this.tableAdapterManager.Flight_SchedulesTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RateTableAdapter = null;
            this.tableAdapterManager.Reservation_PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Seat_NumberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // LanLabel
            // 
            this.LanLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanLabel.Location = new System.Drawing.Point(103, 349);
            this.LanLabel.Name = "LanLabel";
            this.LanLabel.Size = new System.Drawing.Size(117, 22);
            this.LanLabel.TabIndex = 71;
            this.LanLabel.Text = "Ваша раскладка: ";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(23, 377);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(355, 33);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(23, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 2);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // country_IDTextBox
            // 
            this.country_IDTextBox.BackColor = System.Drawing.Color.White;
            this.country_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.country_IDTextBox.Location = new System.Drawing.Point(221, 104);
            this.country_IDTextBox.Name = "country_IDTextBox";
            this.country_IDTextBox.ReadOnly = true;
            this.country_IDTextBox.ShortcutsEnabled = false;
            this.country_IDTextBox.Size = new System.Drawing.Size(155, 19);
            this.country_IDTextBox.TabIndex = 77;
            this.country_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(23, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 2);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(23, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 2);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.Location = new System.Drawing.Point(23, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(355, 2);
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // BoxLine6
            // 
            this.BoxLine6.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine6.Location = new System.Drawing.Point(23, 341);
            this.BoxLine6.Name = "BoxLine6";
            this.BoxLine6.Size = new System.Drawing.Size(355, 2);
            this.BoxLine6.TabIndex = 89;
            this.BoxLine6.TabStop = false;
            // 
            // BoxLine5
            // 
            this.BoxLine5.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine5.Location = new System.Drawing.Point(23, 298);
            this.BoxLine5.Name = "BoxLine5";
            this.BoxLine5.Size = new System.Drawing.Size(355, 2);
            this.BoxLine5.TabIndex = 88;
            this.BoxLine5.TabStop = false;
            // 
            // flight_SchedulesBindingSource
            // 
            this.flight_SchedulesBindingSource.DataMember = "Flight Schedules";
            this.flight_SchedulesBindingSource.DataSource = this.flightBookingDBA;
            // 
            // flight_SchedulesTableAdapter
            // 
            this.flight_SchedulesTableAdapter.ClearBeforeFill = true;
            // 
            // flight_IDLabel1
            // 
            this.flight_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "Flight ID", true));
            this.flight_IDLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.flight_IDLabel1.Location = new System.Drawing.Point(172, 57);
            this.flight_IDLabel1.Name = "flight_IDLabel1";
            this.flight_IDLabel1.Size = new System.Drawing.Size(206, 23);
            this.flight_IDLabel1.TabIndex = 90;
            this.flight_IDLabel1.Text = "ID";
            this.flight_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airPort_IDTextBox
            // 
            this.airPort_IDTextBox.BackColor = System.Drawing.Color.White;
            this.airPort_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airPort_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "AirPort ID", true));
            this.airPort_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airPort_IDTextBox.Location = new System.Drawing.Point(172, 104);
            this.airPort_IDTextBox.Name = "airPort_IDTextBox";
            this.airPort_IDTextBox.Size = new System.Drawing.Size(206, 19);
            this.airPort_IDTextBox.TabIndex = 91;
            this.airPort_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // airCraft_IDTextBox
            // 
            this.airCraft_IDTextBox.BackColor = System.Drawing.Color.White;
            this.airCraft_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airCraft_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "AirCraft ID", true));
            this.airCraft_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airCraft_IDTextBox.Location = new System.Drawing.Point(172, 147);
            this.airCraft_IDTextBox.Name = "airCraft_IDTextBox";
            this.airCraft_IDTextBox.ReadOnly = true;
            this.airCraft_IDTextBox.Size = new System.Drawing.Size(206, 19);
            this.airCraft_IDTextBox.TabIndex = 92;
            this.airCraft_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // origin_City_IDTextBox
            // 
            this.origin_City_IDTextBox.BackColor = System.Drawing.Color.White;
            this.origin_City_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.origin_City_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "Origin City ID", true));
            this.origin_City_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.origin_City_IDTextBox.Location = new System.Drawing.Point(172, 190);
            this.origin_City_IDTextBox.Name = "origin_City_IDTextBox";
            this.origin_City_IDTextBox.Size = new System.Drawing.Size(206, 19);
            this.origin_City_IDTextBox.TabIndex = 93;
            this.origin_City_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // destination_City_IDTextBox
            // 
            this.destination_City_IDTextBox.BackColor = System.Drawing.Color.White;
            this.destination_City_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destination_City_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "Destination City ID", true));
            this.destination_City_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.destination_City_IDTextBox.Location = new System.Drawing.Point(172, 233);
            this.destination_City_IDTextBox.Name = "destination_City_IDTextBox";
            this.destination_City_IDTextBox.ReadOnly = true;
            this.destination_City_IDTextBox.Size = new System.Drawing.Size(206, 19);
            this.destination_City_IDTextBox.TabIndex = 94;
            this.destination_City_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departure_Date_TimeDateTimePicker
            // 
            this.departure_Date_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flight_SchedulesBindingSource, "Departure Date Time", true));
            this.departure_Date_TimeDateTimePicker.Location = new System.Drawing.Point(178, 273);
            this.departure_Date_TimeDateTimePicker.Name = "departure_Date_TimeDateTimePicker";
            this.departure_Date_TimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.departure_Date_TimeDateTimePicker.TabIndex = 95;
            this.departure_Date_TimeDateTimePicker.Visible = false;
            // 
            // arrival_Date_TimeDateTimePicker
            // 
            this.arrival_Date_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flight_SchedulesBindingSource, "Arrival Date Time", true));
            this.arrival_Date_TimeDateTimePicker.Location = new System.Drawing.Point(176, 316);
            this.arrival_Date_TimeDateTimePicker.Name = "arrival_Date_TimeDateTimePicker";
            this.arrival_Date_TimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.arrival_Date_TimeDateTimePicker.TabIndex = 96;
            this.arrival_Date_TimeDateTimePicker.Visible = false;
            // 
            // AirPortIDComboBox
            // 
            this.AirPortIDComboBox.BackColor = System.Drawing.Color.White;
            this.AirPortIDComboBox.BorderColor = System.Drawing.Color.White;
            this.AirPortIDComboBox.BorderThickness = 0;
            this.AirPortIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirPortIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirPortIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortIDComboBox.FocusedState.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AirPortIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirPortIDComboBox.HoverState.BorderColor = System.Drawing.Color.White;
            this.AirPortIDComboBox.HoverState.FillColor = System.Drawing.Color.White;
            this.AirPortIDComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.AirPortIDComboBox.HoverState.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.ItemHeight = 30;
            this.AirPortIDComboBox.ItemsAppearance.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Location = new System.Drawing.Point(159, 88);
            this.AirPortIDComboBox.Name = "AirPortIDComboBox";
            this.AirPortIDComboBox.ShadowDecoration.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.AirPortIDComboBox.TabIndex = 97;
            this.AirPortIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AirPortIDComboBox.SelectedIndexChanged += new System.EventHandler(this.AirPortIDComboBox_SelectedIndexChanged);
            // 
            // AirCraftIDComboBox
            // 
            this.AirCraftIDComboBox.BackColor = System.Drawing.Color.White;
            this.AirCraftIDComboBox.BorderColor = System.Drawing.Color.White;
            this.AirCraftIDComboBox.BorderThickness = 0;
            this.AirCraftIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirCraftIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirCraftIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirCraftIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirCraftIDComboBox.FocusedState.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AirCraftIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirCraftIDComboBox.HoverState.BorderColor = System.Drawing.Color.White;
            this.AirCraftIDComboBox.HoverState.FillColor = System.Drawing.Color.White;
            this.AirCraftIDComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.AirCraftIDComboBox.HoverState.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.ItemHeight = 30;
            this.AirCraftIDComboBox.ItemsAppearance.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Location = new System.Drawing.Point(159, 131);
            this.AirCraftIDComboBox.Name = "AirCraftIDComboBox";
            this.AirCraftIDComboBox.ShadowDecoration.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.AirCraftIDComboBox.TabIndex = 98;
            this.AirCraftIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DestinationCityIDComboBox
            // 
            this.DestinationCityIDComboBox.BackColor = System.Drawing.Color.White;
            this.DestinationCityIDComboBox.BorderColor = System.Drawing.Color.White;
            this.DestinationCityIDComboBox.BorderThickness = 0;
            this.DestinationCityIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DestinationCityIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCityIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityIDComboBox.FocusedState.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DestinationCityIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DestinationCityIDComboBox.HoverState.BorderColor = System.Drawing.Color.White;
            this.DestinationCityIDComboBox.HoverState.FillColor = System.Drawing.Color.White;
            this.DestinationCityIDComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.DestinationCityIDComboBox.HoverState.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.ItemHeight = 30;
            this.DestinationCityIDComboBox.ItemsAppearance.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Location = new System.Drawing.Point(159, 217);
            this.DestinationCityIDComboBox.Name = "DestinationCityIDComboBox";
            this.DestinationCityIDComboBox.ShadowDecoration.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.DestinationCityIDComboBox.TabIndex = 99;
            this.DestinationCityIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CheckedState.Parent = this.DepartureDatePicker;
            this.DepartureDatePicker.FillColor = System.Drawing.Color.White;
            this.DepartureDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DepartureDatePicker.HoverState.BorderColor = System.Drawing.Color.White;
            this.DepartureDatePicker.HoverState.FillColor = System.Drawing.Color.White;
            this.DepartureDatePicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.DepartureDatePicker.HoverState.Parent = this.DepartureDatePicker;
            this.DepartureDatePicker.Location = new System.Drawing.Point(159, 260);
            this.DepartureDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DepartureDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.ShadowDecoration.Parent = this.DepartureDatePicker;
            this.DepartureDatePicker.Size = new System.Drawing.Size(219, 36);
            this.DepartureDatePicker.TabIndex = 100;
            this.DepartureDatePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartureDatePicker.Value = new System.DateTime(2021, 2, 28, 22, 35, 41, 40);
            this.DepartureDatePicker.ValueChanged += new System.EventHandler(this.DepartureDatePicker_ValueChanged);
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.CheckedState.Parent = this.ArrivalDatePicker;
            this.ArrivalDatePicker.FillColor = System.Drawing.Color.White;
            this.ArrivalDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ArrivalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ArrivalDatePicker.HoverState.BorderColor = System.Drawing.Color.White;
            this.ArrivalDatePicker.HoverState.FillColor = System.Drawing.Color.White;
            this.ArrivalDatePicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ArrivalDatePicker.HoverState.Parent = this.ArrivalDatePicker;
            this.ArrivalDatePicker.Location = new System.Drawing.Point(159, 303);
            this.ArrivalDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ArrivalDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.ShadowDecoration.Parent = this.ArrivalDatePicker;
            this.ArrivalDatePicker.Size = new System.Drawing.Size(219, 36);
            this.ArrivalDatePicker.TabIndex = 101;
            this.ArrivalDatePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArrivalDatePicker.Value = new System.DateTime(2021, 2, 28, 22, 35, 41, 40);
            this.ArrivalDatePicker.ValueChanged += new System.EventHandler(this.ArrivalDatePicker_ValueChanged);
            // 
            // OriginCityLocation
            // 
            this.OriginCityLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "Flight ID", true));
            this.OriginCityLocation.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OriginCityLocation.Location = new System.Drawing.Point(172, 186);
            this.OriginCityLocation.Name = "OriginCityLocation";
            this.OriginCityLocation.Size = new System.Drawing.Size(206, 23);
            this.OriginCityLocation.TabIndex = 102;
            this.OriginCityLocation.Text = "City";
            this.OriginCityLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminFlightEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 420);
            this.Controls.Add(this.DestinationCityIDComboBox);
            this.Controls.Add(this.AirPortIDComboBox);
            this.Controls.Add(this.ArrivalDatePicker);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.OriginCityLocation);
            this.Controls.Add(this.origin_City_IDTextBox);
            this.Controls.Add(this.flight_IDLabel1);
            this.Controls.Add(this.BoxLine6);
            this.Controls.Add(this.BoxLine5);
            this.Controls.Add(ArrivalDate);
            this.Controls.Add(DepartureDate);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.destination_City_IDTextBox);
            this.Controls.Add(this.departure_Date_TimeDateTimePicker);
            this.Controls.Add(this.arrival_Date_TimeDateTimePicker);
            this.Controls.Add(this.country_IDTextBox);
            this.Controls.Add(this.airPort_IDTextBox);
            this.Controls.Add(this.AirCraftIDComboBox);
            this.Controls.Add(this.airCraft_IDTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminFlightEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.PictureBox BoxLine4;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private System.Windows.Forms.Timer TimerLanguage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox country_IDTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BoxLine6;
        private System.Windows.Forms.PictureBox BoxLine5;
        private System.Windows.Forms.BindingSource flight_SchedulesBindingSource;
        private FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter flight_SchedulesTableAdapter;
        private System.Windows.Forms.Label flight_IDLabel1;
        private System.Windows.Forms.TextBox airPort_IDTextBox;
        private System.Windows.Forms.TextBox airCraft_IDTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox AirPortIDComboBox;
        private System.Windows.Forms.DateTimePicker arrival_Date_TimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker departure_Date_TimeDateTimePicker;
        private System.Windows.Forms.TextBox destination_City_IDTextBox;
        private System.Windows.Forms.TextBox origin_City_IDTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox AirCraftIDComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker DepartureDatePicker;
        private Guna.UI2.WinForms.Guna2ComboBox DestinationCityIDComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker ArrivalDatePicker;
        private System.Windows.Forms.Label OriginCityLocation;
    }
}