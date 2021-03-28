
namespace FlightBookingForms
{
    partial class AdminCaCCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCaCCreation));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.ButtonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.CountryTableAdapter();
            this.country_IDLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(72, 19);
            user_IDLabel.TabIndex = 34;
            user_IDLabel.Text = "ID страны";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 110);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(104, 19);
            first_NameLabel.TabIndex = 38;
            first_NameLabel.Text = "Наименование";
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
            this.ButtonBackWards.Size = new System.Drawing.Size(268, 33);
            this.ButtonBackWards.TabIndex = 1;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(23, 132);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(268, 2);
            this.BoxLine4.TabIndex = 45;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(23, 83);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(268, 2);
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
            this.ButtonCreate.Location = new System.Drawing.Point(23, 169);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.ShadowDecoration.Parent = this.ButtonCreate;
            this.ButtonCreate.Size = new System.Drawing.Size(268, 33);
            this.ButtonCreate.TabIndex = 3;
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
            // LanLabel
            // 
            this.LanLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanLabel.Location = new System.Drawing.Point(73, 141);
            this.LanLabel.Name = "LanLabel";
            this.LanLabel.Size = new System.Drawing.Size(117, 22);
            this.LanLabel.TabIndex = 55;
            this.LanLabel.Text = "Ваша раскладка: ";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.flightBookingDBA;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // country_IDLabel1
            // 
            this.country_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Country ID", true));
            this.country_IDLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.country_IDLabel1.Location = new System.Drawing.Point(136, 57);
            this.country_IDLabel1.Name = "country_IDLabel1";
            this.country_IDLabel1.Size = new System.Drawing.Size(155, 23);
            this.country_IDLabel1.TabIndex = 56;
            this.country_IDLabel1.Text = "ID";
            this.country_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.nameTextBox.Location = new System.Drawing.Point(136, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ShortcutsEnabled = false;
            this.nameTextBox.Size = new System.Drawing.Size(155, 19);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
            // 
            // AdminCaCCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 210);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.country_IDLabel1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminCaCCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Страны";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private FlightBookingDNB flightBookingDBA;
        private Guna.UI2.WinForms.Guna2Button ButtonCreate;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private FlightBookingDNBTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label country_IDLabel1;
        private System.Windows.Forms.Timer TimerLanguage;
    }
}