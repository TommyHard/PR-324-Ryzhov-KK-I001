
namespace FlightBookingForms
{
    partial class PrimaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.OriginCityID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AdLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DestinationCityID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DepartureDateTimer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ArrivalDateTimer = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonBuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LogoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonCurrency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonAuthorization = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flightBookingDNB = new FlightBookingForms.FlightBookingDNB();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
            // 
            // OriginCityID
            // 
            this.OriginCityID.Animated = true;
            this.OriginCityID.BackColor = System.Drawing.Color.Transparent;
            this.OriginCityID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OriginCityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginCityID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OriginCityID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OriginCityID.FocusedState.Parent = this.OriginCityID;
            this.OriginCityID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.OriginCityID.ForeColor = System.Drawing.Color.Black;
            this.OriginCityID.HoverState.Parent = this.OriginCityID;
            this.OriginCityID.ItemHeight = 30;
            this.OriginCityID.ItemsAppearance.Parent = this.OriginCityID;
            this.OriginCityID.Location = new System.Drawing.Point(67, 248);
            this.OriginCityID.Name = "OriginCityID";
            this.OriginCityID.ShadowDecoration.Parent = this.OriginCityID;
            this.OriginCityID.Size = new System.Drawing.Size(214, 36);
            this.OriginCityID.TabIndex = 0;
            this.OriginCityID.SelectedIndexChanged += new System.EventHandler(this.OriginCityID_SelectedIndexChanged);
            // 
            // AdLabel
            // 
            this.AdLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdLabel.Location = new System.Drawing.Point(369, 122);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(456, 47);
            this.AdLabel.TabIndex = 1;
            this.AdLabel.Text = "Поиск доступных авиабилетов";
            // 
            // DestinationCityID
            // 
            this.DestinationCityID.Animated = true;
            this.DestinationCityID.BackColor = System.Drawing.Color.Transparent;
            this.DestinationCityID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DestinationCityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCityID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DestinationCityID.FocusedState.Parent = this.DestinationCityID;
            this.DestinationCityID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DestinationCityID.ForeColor = System.Drawing.Color.Black;
            this.DestinationCityID.HoverState.Parent = this.DestinationCityID;
            this.DestinationCityID.ItemHeight = 30;
            this.DestinationCityID.ItemsAppearance.Parent = this.DestinationCityID;
            this.DestinationCityID.Location = new System.Drawing.Point(287, 248);
            this.DestinationCityID.Name = "DestinationCityID";
            this.DestinationCityID.ShadowDecoration.Parent = this.DestinationCityID;
            this.DestinationCityID.Size = new System.Drawing.Size(214, 36);
            this.DestinationCityID.TabIndex = 2;
            this.DestinationCityID.SelectedIndexChanged += new System.EventHandler(this.DestinationCityID_SelectedIndexChanged);
            // 
            // DepartureDateTimer
            // 
            this.DepartureDateTimer.Animated = true;
            this.DepartureDateTimer.BackColor = System.Drawing.Color.White;
            this.DepartureDateTimer.BorderColor = System.Drawing.Color.White;
            this.DepartureDateTimer.CheckedState.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.DepartureDateTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DepartureDateTimer.ForeColor = System.Drawing.Color.White;
            this.DepartureDateTimer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DepartureDateTimer.HoverState.BorderColor = System.Drawing.Color.White;
            this.DepartureDateTimer.HoverState.FillColor = System.Drawing.Color.White;
            this.DepartureDateTimer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.DepartureDateTimer.HoverState.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.Location = new System.Drawing.Point(507, 248);
            this.DepartureDateTimer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DepartureDateTimer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DepartureDateTimer.Name = "DepartureDateTimer";
            this.DepartureDateTimer.ShadowDecoration.Parent = this.DepartureDateTimer;
            this.DepartureDateTimer.Size = new System.Drawing.Size(219, 36);
            this.DepartureDateTimer.TabIndex = 68;
            this.DepartureDateTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartureDateTimer.Value = new System.DateTime(2021, 2, 28, 16, 6, 28, 142);
            this.DepartureDateTimer.ValueChanged += new System.EventHandler(this.DepartureDateTimer_ValueChanged);
            // 
            // ArrivalDateTimer
            // 
            this.ArrivalDateTimer.Animated = true;
            this.ArrivalDateTimer.BackColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.BorderColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.CheckedState.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ArrivalDateTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ArrivalDateTimer.ForeColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ArrivalDateTimer.HoverState.BorderColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.HoverState.FillColor = System.Drawing.Color.White;
            this.ArrivalDateTimer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ArrivalDateTimer.HoverState.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.Location = new System.Drawing.Point(732, 248);
            this.ArrivalDateTimer.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ArrivalDateTimer.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ArrivalDateTimer.Name = "ArrivalDateTimer";
            this.ArrivalDateTimer.ShadowDecoration.Parent = this.ArrivalDateTimer;
            this.ArrivalDateTimer.Size = new System.Drawing.Size(219, 36);
            this.ArrivalDateTimer.TabIndex = 70;
            this.ArrivalDateTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArrivalDateTimer.Value = new System.DateTime(2021, 2, 28, 16, 6, 28, 142);
            this.ArrivalDateTimer.ValueChanged += new System.EventHandler(this.ArrivalDateTimer_ValueChanged);
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.Animated = true;
            this.ButtonBuy.CheckedState.Parent = this.ButtonBuy;
            this.ButtonBuy.CustomImages.Parent = this.ButtonBuy;
            this.ButtonBuy.FillColor = System.Drawing.Color.Gold;
            this.ButtonBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBuy.ForeColor = System.Drawing.Color.Black;
            this.ButtonBuy.HoverState.Parent = this.ButtonBuy;
            this.ButtonBuy.Location = new System.Drawing.Point(957, 248);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.ShadowDecoration.Parent = this.ButtonBuy;
            this.ButtonBuy.Size = new System.Drawing.Size(180, 36);
            this.ButtonBuy.TabIndex = 71;
            this.ButtonBuy.Text = "Забронировать ✈";
            this.ButtonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(437, 175);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(312, 27);
            this.guna2HtmlLabel1.TabIndex = 72;
            this.guna2HtmlLabel1.Text = "Лучший способ купить авиабилеты";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.White;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(4, -90);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.ShadowDecoration.Parent = this.LogoPictureBox;
            this.LogoPictureBox.Size = new System.Drawing.Size(357, 266);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 73;
            this.LogoPictureBox.TabStop = false;
            // 
            // ButtonCurrency
            // 
            this.ButtonCurrency.Animated = true;
            this.ButtonCurrency.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ButtonCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonCurrency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ButtonCurrency.FocusedState.Parent = this.ButtonCurrency;
            this.ButtonCurrency.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ButtonCurrency.ForeColor = System.Drawing.Color.Black;
            this.ButtonCurrency.HoverState.Parent = this.ButtonCurrency;
            this.ButtonCurrency.ItemHeight = 30;
            this.ButtonCurrency.ItemsAppearance.Parent = this.ButtonCurrency;
            this.ButtonCurrency.Location = new System.Drawing.Point(771, 26);
            this.ButtonCurrency.Name = "ButtonCurrency";
            this.ButtonCurrency.ShadowDecoration.Parent = this.ButtonCurrency;
            this.ButtonCurrency.Size = new System.Drawing.Size(180, 36);
            this.ButtonCurrency.TabIndex = 75;
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.Animated = true;
            this.ButtonAuthorization.CheckedState.Parent = this.ButtonAuthorization;
            this.ButtonAuthorization.CustomImages.Parent = this.ButtonAuthorization;
            this.ButtonAuthorization.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonAuthorization.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonAuthorization.ForeColor = System.Drawing.Color.White;
            this.ButtonAuthorization.HoverState.Parent = this.ButtonAuthorization;
            this.ButtonAuthorization.Location = new System.Drawing.Point(957, 26);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.ShadowDecoration.Parent = this.ButtonAuthorization;
            this.ButtonAuthorization.Size = new System.Drawing.Size(180, 36);
            this.ButtonAuthorization.TabIndex = 76;
            this.ButtonAuthorization.Text = "Сотрудник";
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 221);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(63, 27);
            this.guna2HtmlLabel2.TabIndex = 77;
            this.guna2HtmlLabel2.Text = "Откуда";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(287, 221);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(43, 27);
            this.guna2HtmlLabel3.TabIndex = 78;
            this.guna2HtmlLabel3.Text = "Куда";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(507, 221);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(52, 27);
            this.guna2HtmlLabel4.TabIndex = 79;
            this.guna2HtmlLabel4.Text = "Когда";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(732, 221);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(79, 27);
            this.guna2HtmlLabel5.TabIndex = 80;
            this.guna2HtmlLabel5.Text = "Обратно";
            // 
            // flightBookingDNB
            // 
            this.flightBookingDNB.DataSetName = "FlightBookingDNB";
            this.flightBookingDNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.flightBookingDNB;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftTableAdapter = null;
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booked_TicketTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
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
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 421);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.ButtonAuthorization);
            this.Controls.Add(this.ButtonCurrency);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ButtonBuy);
            this.Controls.Add(this.ArrivalDateTimer);
            this.Controls.Add(this.DepartureDateTimer);
            this.Controls.Add(this.DestinationCityID);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.OriginCityID);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrimaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доступные авиабилеты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrimaryForm_FormClosed);
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2ComboBox DestinationCityID;
        private Guna.UI2.WinForms.Guna2HtmlLabel AdLabel;
        private Guna.UI2.WinForms.Guna2ComboBox OriginCityID;
        private Guna.UI2.WinForms.Guna2DateTimePicker DepartureDateTimer;
        private Guna.UI2.WinForms.Guna2Button ButtonAuthorization;
        private Guna.UI2.WinForms.Guna2ComboBox ButtonCurrency;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ButtonBuy;
        private Guna.UI2.WinForms.Guna2DateTimePicker ArrivalDateTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private FlightBookingDNB flightBookingDNB;
        private FlightBookingDNBTableAdapters.CityTableAdapter cityTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
    }
}