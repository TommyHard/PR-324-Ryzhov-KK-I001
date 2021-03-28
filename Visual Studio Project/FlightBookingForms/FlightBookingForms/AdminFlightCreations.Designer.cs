
namespace FlightBookingForms
{
    partial class AdminFlightCreations
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
            System.Windows.Forms.Label UserID;
            System.Windows.Forms.Label AirPortID;
            System.Windows.Forms.Label DestinationCityID;
            System.Windows.Forms.Label ArrivalDate;
            System.Windows.Forms.Label DepartureDate;
            System.Windows.Forms.Label AirCraftID;
            System.Windows.Forms.Label OriginCityID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightCreations));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine6 = new System.Windows.Forms.PictureBox();
            this.BoxLine5 = new System.Windows.Forms.PictureBox();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine3 = new System.Windows.Forms.PictureBox();
            this.BoxLine2 = new System.Windows.Forms.PictureBox();
            this.BoxLine1 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.ButtonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.flight_SchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_SchedulesTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter();
            this.flight_IDLabel1 = new System.Windows.Forms.Label();
            this.airPort_IDTextBox = new System.Windows.Forms.TextBox();
            this.airCraft_IDTextBox = new System.Windows.Forms.TextBox();
            this.origin_City_IDTextBox = new System.Windows.Forms.TextBox();
            this.destination_City_IDTextBox = new System.Windows.Forms.TextBox();
            this.departure_Date_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrival_Date_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureDateTimer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ArrivalDateTimer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AirPortIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AirCraftIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DestinationCityIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.OriginCityLocation = new System.Windows.Forms.Label();
            UserID = new System.Windows.Forms.Label();
            AirPortID = new System.Windows.Forms.Label();
            DestinationCityID = new System.Windows.Forms.Label();
            ArrivalDate = new System.Windows.Forms.Label();
            DepartureDate = new System.Windows.Forms.Label();
            AirCraftID = new System.Windows.Forms.Label();
            OriginCityID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            UserID.Location = new System.Drawing.Point(19, 61);
            UserID.Name = "UserID";
            UserID.Size = new System.Drawing.Size(63, 19);
            UserID.TabIndex = 34;
            UserID.Text = "ID рейса";
            // 
            // AirPortID
            // 
            AirPortID.AutoSize = true;
            AirPortID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            AirPortID.Location = new System.Drawing.Point(19, 104);
            AirPortID.Name = "AirPortID";
            AirPortID.Size = new System.Drawing.Size(93, 19);
            AirPortID.TabIndex = 37;
            AirPortID.Text = "ID аэропорта";
            // 
            // DestinationCityID
            // 
            DestinationCityID.AutoSize = true;
            DestinationCityID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            DestinationCityID.Location = new System.Drawing.Point(19, 233);
            DestinationCityID.Name = "DestinationCityID";
            DestinationCityID.Size = new System.Drawing.Size(115, 19);
            DestinationCityID.TabIndex = 38;
            DestinationCityID.Text = "Город прибытия";
            // 
            // ArrivalDate
            // 
            ArrivalDate.AutoSize = true;
            ArrivalDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            ArrivalDate.Location = new System.Drawing.Point(19, 319);
            ArrivalDate.Name = "ArrivalDate";
            ArrivalDate.Size = new System.Drawing.Size(106, 19);
            ArrivalDate.TabIndex = 39;
            ArrivalDate.Text = "Дата прибытия";
            // 
            // DepartureDate
            // 
            DepartureDate.AutoSize = true;
            DepartureDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            DepartureDate.Location = new System.Drawing.Point(19, 276);
            DepartureDate.Name = "DepartureDate";
            DepartureDate.Size = new System.Drawing.Size(124, 19);
            DepartureDate.TabIndex = 40;
            DepartureDate.Text = "Дата отправления";
            // 
            // AirCraftID
            // 
            AirCraftID.AutoSize = true;
            AirCraftID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            AirCraftID.Location = new System.Drawing.Point(19, 147);
            AirCraftID.Name = "AirCraftID";
            AirCraftID.Size = new System.Drawing.Size(85, 19);
            AirCraftID.TabIndex = 65;
            AirCraftID.Text = "ID самолёта";
            // 
            // OriginCityID
            // 
            OriginCityID.AutoSize = true;
            OriginCityID.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            OriginCityID.Location = new System.Drawing.Point(19, 190);
            OriginCityID.Name = "OriginCityID";
            OriginCityID.Size = new System.Drawing.Size(133, 19);
            OriginCityID.TabIndex = 66;
            OriginCityID.Text = "Город отправления";
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
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
            // BoxLine6
            // 
            this.BoxLine6.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine6.Location = new System.Drawing.Point(23, 341);
            this.BoxLine6.Name = "BoxLine6";
            this.BoxLine6.Size = new System.Drawing.Size(355, 2);
            this.BoxLine6.TabIndex = 47;
            this.BoxLine6.TabStop = false;
            // 
            // BoxLine5
            // 
            this.BoxLine5.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine5.Location = new System.Drawing.Point(23, 298);
            this.BoxLine5.Name = "BoxLine5";
            this.BoxLine5.Size = new System.Drawing.Size(355, 2);
            this.BoxLine5.TabIndex = 46;
            this.BoxLine5.TabStop = false;
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(23, 255);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(355, 2);
            this.BoxLine4.TabIndex = 45;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine3
            // 
            this.BoxLine3.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine3.Location = new System.Drawing.Point(23, 212);
            this.BoxLine3.Name = "BoxLine3";
            this.BoxLine3.Size = new System.Drawing.Size(355, 2);
            this.BoxLine3.TabIndex = 44;
            this.BoxLine3.TabStop = false;
            // 
            // BoxLine2
            // 
            this.BoxLine2.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine2.Location = new System.Drawing.Point(23, 169);
            this.BoxLine2.Name = "BoxLine2";
            this.BoxLine2.Size = new System.Drawing.Size(355, 2);
            this.BoxLine2.TabIndex = 43;
            this.BoxLine2.TabStop = false;
            // 
            // BoxLine1
            // 
            this.BoxLine1.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine1.Location = new System.Drawing.Point(23, 126);
            this.BoxLine1.Name = "BoxLine1";
            this.BoxLine1.Size = new System.Drawing.Size(355, 2);
            this.BoxLine1.TabIndex = 42;
            this.BoxLine1.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(23, 83);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(355, 2);
            this.BoxLine.TabIndex = 41;
            this.BoxLine.TabStop = false;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Animated = true;
            this.ButtonCreate.CheckedState.Parent = this.ButtonCreate;
            this.ButtonCreate.CustomImages.Parent = this.ButtonCreate;
            this.ButtonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.HoverState.Parent = this.ButtonCreate;
            this.ButtonCreate.Location = new System.Drawing.Point(23, 377);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.ShadowDecoration.Parent = this.ButtonCreate;
            this.ButtonCreate.Size = new System.Drawing.Size(355, 33);
            this.ButtonCreate.TabIndex = 10;
            this.ButtonCreate.Text = "Добавить";
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
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
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.patronymicTextBox.Location = new System.Drawing.Point(136, 319);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.ShortcutsEnabled = false;
            this.patronymicTextBox.Size = new System.Drawing.Size(155, 19);
            this.patronymicTextBox.TabIndex = 9;
            this.patronymicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LanLabel
            // 
            this.LanLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanLabel.Location = new System.Drawing.Point(103, 349);
            this.LanLabel.Name = "LanLabel";
            this.LanLabel.Size = new System.Drawing.Size(117, 22);
            this.LanLabel.TabIndex = 55;
            this.LanLabel.Text = "Ваша раскладка: ";
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
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
            this.flight_IDLabel1.TabIndex = 58;
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
            this.airPort_IDTextBox.ReadOnly = true;
            this.airPort_IDTextBox.Size = new System.Drawing.Size(151, 19);
            this.airPort_IDTextBox.TabIndex = 59;
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
            this.airCraft_IDTextBox.TabIndex = 60;
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
            this.origin_City_IDTextBox.ReadOnly = true;
            this.origin_City_IDTextBox.Size = new System.Drawing.Size(206, 19);
            this.origin_City_IDTextBox.TabIndex = 61;
            this.origin_City_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.origin_City_IDTextBox.Visible = false;
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
            this.destination_City_IDTextBox.TabIndex = 62;
            this.destination_City_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // departure_Date_TimeDateTimePicker
            // 
            this.departure_Date_TimeDateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.departure_Date_TimeDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.departure_Date_TimeDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.departure_Date_TimeDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.departure_Date_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flight_SchedulesBindingSource, "Departure Date Time", true));
            this.departure_Date_TimeDateTimePicker.Location = new System.Drawing.Point(172, 273);
            this.departure_Date_TimeDateTimePicker.Name = "departure_Date_TimeDateTimePicker";
            this.departure_Date_TimeDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.departure_Date_TimeDateTimePicker.TabIndex = 63;
            // 
            // arrival_Date_TimeDateTimePicker
            // 
            this.arrival_Date_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flight_SchedulesBindingSource, "Arrival Date Time", true));
            this.arrival_Date_TimeDateTimePicker.Location = new System.Drawing.Point(172, 316);
            this.arrival_Date_TimeDateTimePicker.Name = "arrival_Date_TimeDateTimePicker";
            this.arrival_Date_TimeDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.arrival_Date_TimeDateTimePicker.TabIndex = 64;
            // 
            // DepartureDateTimer
            // 
            this.DepartureDateTimer.BackColor = System.Drawing.Color.White;
            this.DepartureDateTimer.CheckedState.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.FillColor = System.Drawing.Color.White;
            this.DepartureDateTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DepartureDateTimer.ForeColor = System.Drawing.Color.Black;
            this.DepartureDateTimer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DepartureDateTimer.HoverState.BorderColor = System.Drawing.Color.White;
            this.DepartureDateTimer.HoverState.FillColor = System.Drawing.Color.White;
            this.DepartureDateTimer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.DepartureDateTimer.HoverState.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.Location = new System.Drawing.Point(159, 260);
            this.DepartureDateTimer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DepartureDateTimer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DepartureDateTimer.Name = "DepartureDateTimer";
            this.DepartureDateTimer.ShadowDecoration.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.Size = new System.Drawing.Size(219, 36);
            this.DepartureDateTimer.TabIndex = 67;
            this.DepartureDateTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartureDateTimer.Value = new System.DateTime(2021, 2, 28, 16, 6, 28, 142);
            this.DepartureDateTimer.ValueChanged += new System.EventHandler(this.DepartureDateTimer_TextChanged);
            // 
            // ArrivalDateTimer
            // 
            this.ArrivalDateTimer.CheckedState.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.FillColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ArrivalDateTimer.ForeColor = System.Drawing.Color.Black;
            this.ArrivalDateTimer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ArrivalDateTimer.HoverState.BorderColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.HoverState.FillColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ArrivalDateTimer.HoverState.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.Location = new System.Drawing.Point(159, 303);
            this.ArrivalDateTimer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ArrivalDateTimer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ArrivalDateTimer.Name = "ArrivalDateTimer";
            this.ArrivalDateTimer.ShadowDecoration.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.Size = new System.Drawing.Size(219, 36);
            this.ArrivalDateTimer.TabIndex = 68;
            this.ArrivalDateTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArrivalDateTimer.Value = new System.DateTime(2021, 2, 28, 16, 6, 28, 142);
            this.ArrivalDateTimer.ValueChanged += new System.EventHandler(this.ArrivalDateTimer_TextChanged);
            // 
            // AirPortIDComboBox
            // 
            this.AirPortIDComboBox.Animated = true;
            this.AirPortIDComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AirPortIDComboBox.BorderColor = System.Drawing.Color.White;
            this.AirPortIDComboBox.BorderThickness = 0;
            this.AirPortIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirPortIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirPortIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortIDComboBox.FocusedState.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirPortIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirPortIDComboBox.HoverState.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.ItemHeight = 30;
            this.AirPortIDComboBox.ItemsAppearance.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Location = new System.Drawing.Point(159, 88);
            this.AirPortIDComboBox.Name = "AirPortIDComboBox";
            this.AirPortIDComboBox.ShadowDecoration.Parent = this.AirPortIDComboBox;
            this.AirPortIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.AirPortIDComboBox.TabIndex = 69;
            this.AirPortIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AirPortIDComboBox.SelectedIndexChanged += new System.EventHandler(this.AirPortIDComboBox_SelectedIndexChanged);
            // 
            // AirCraftIDComboBox
            // 
            this.AirCraftIDComboBox.Animated = true;
            this.AirCraftIDComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AirCraftIDComboBox.BorderColor = System.Drawing.Color.White;
            this.AirCraftIDComboBox.BorderThickness = 0;
            this.AirCraftIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirCraftIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirCraftIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirCraftIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirCraftIDComboBox.FocusedState.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AirCraftIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirCraftIDComboBox.HoverState.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.ItemHeight = 30;
            this.AirCraftIDComboBox.ItemsAppearance.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Location = new System.Drawing.Point(159, 131);
            this.AirCraftIDComboBox.Name = "AirCraftIDComboBox";
            this.AirCraftIDComboBox.ShadowDecoration.Parent = this.AirCraftIDComboBox;
            this.AirCraftIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.AirCraftIDComboBox.TabIndex = 70;
            this.AirCraftIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DestinationCityIDComboBox
            // 
            this.DestinationCityIDComboBox.Animated = true;
            this.DestinationCityIDComboBox.BackColor = System.Drawing.Color.Transparent;
            this.DestinationCityIDComboBox.BorderColor = System.Drawing.Color.White;
            this.DestinationCityIDComboBox.BorderThickness = 0;
            this.DestinationCityIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DestinationCityIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCityIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityIDComboBox.FocusedState.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DestinationCityIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DestinationCityIDComboBox.HoverState.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.ItemHeight = 30;
            this.DestinationCityIDComboBox.ItemsAppearance.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Location = new System.Drawing.Point(159, 217);
            this.DestinationCityIDComboBox.Name = "DestinationCityIDComboBox";
            this.DestinationCityIDComboBox.ShadowDecoration.Parent = this.DestinationCityIDComboBox;
            this.DestinationCityIDComboBox.Size = new System.Drawing.Size(219, 36);
            this.DestinationCityIDComboBox.TabIndex = 72;
            this.DestinationCityIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OriginCityLocation
            // 
            this.OriginCityLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_SchedulesBindingSource, "Flight ID", true));
            this.OriginCityLocation.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OriginCityLocation.Location = new System.Drawing.Point(172, 186);
            this.OriginCityLocation.Name = "OriginCityLocation";
            this.OriginCityLocation.Size = new System.Drawing.Size(206, 23);
            this.OriginCityLocation.TabIndex = 73;
            this.OriginCityLocation.Text = "City";
            this.OriginCityLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminFlightCreations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 420);
            this.Controls.Add(this.ArrivalDateTimer);
            this.Controls.Add(this.DestinationCityIDComboBox);
            this.Controls.Add(OriginCityID);
            this.Controls.Add(AirCraftID);
            this.Controls.Add(this.arrival_Date_TimeDateTimePicker);
            this.Controls.Add(this.destination_City_IDTextBox);
            this.Controls.Add(this.flight_IDLabel1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.BoxLine6);
            this.Controls.Add(this.BoxLine5);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine3);
            this.Controls.Add(this.BoxLine2);
            this.Controls.Add(this.BoxLine1);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(UserID);
            this.Controls.Add(AirPortID);
            this.Controls.Add(DestinationCityID);
            this.Controls.Add(ArrivalDate);
            this.Controls.Add(DepartureDate);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.OriginCityLocation);
            this.Controls.Add(this.origin_City_IDTextBox);
            this.Controls.Add(this.AirCraftIDComboBox);
            this.Controls.Add(this.airCraft_IDTextBox);
            this.Controls.Add(this.DepartureDateTimer);
            this.Controls.Add(this.departure_Date_TimeDateTimePicker);
            this.Controls.Add(this.AirPortIDComboBox);
            this.Controls.Add(this.airPort_IDTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminFlightCreations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Рейса";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private FlightBookingDNB flightBookingDBA;
        private Guna.UI2.WinForms.Guna2Button ButtonCreate;
        private System.Windows.Forms.PictureBox BoxLine6;
        private System.Windows.Forms.PictureBox BoxLine5;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine3;
        private System.Windows.Forms.PictureBox BoxLine2;
        private System.Windows.Forms.PictureBox BoxLine1;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private System.Windows.Forms.Timer TimerLanguage;
        private System.Windows.Forms.BindingSource flight_SchedulesBindingSource;
        private FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter flight_SchedulesTableAdapter;
        private System.Windows.Forms.DateTimePicker arrival_Date_TimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker departure_Date_TimeDateTimePicker;
        private System.Windows.Forms.TextBox destination_City_IDTextBox;
        private System.Windows.Forms.TextBox origin_City_IDTextBox;
        private System.Windows.Forms.TextBox airCraft_IDTextBox;
        private System.Windows.Forms.TextBox airPort_IDTextBox;
        private System.Windows.Forms.Label flight_IDLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ArrivalDateTimer;
        private Guna.UI2.WinForms.Guna2DateTimePicker DepartureDateTimer;
        private Guna.UI2.WinForms.Guna2ComboBox AirPortIDComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox DestinationCityIDComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox AirCraftIDComboBox;
        private System.Windows.Forms.Label OriginCityLocation;
    }
}