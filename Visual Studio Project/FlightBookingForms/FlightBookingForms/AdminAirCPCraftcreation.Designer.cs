
namespace FlightBookingForms
{
    partial class AdminAirCPCraftcreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAirCPCraftcreation));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.ButtonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.airport_NameTextBox = new System.Windows.Forms.TextBox();
            this.AirPortsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.airCraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airCraftTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.AirCraftTableAdapter();
            this.airCraft_IDLabel1 = new System.Windows.Forms.Label();
            this.airPort_IDTextBox = new System.Windows.Forms.TextBox();
            this.airCraft_NameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.business_Class_CapacityTextBox = new System.Windows.Forms.TextBox();
            this.economy_Class_CapacityTextBox = new System.Windows.Forms.TextBox();
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(85, 19);
            user_IDLabel.TabIndex = 34;
            user_IDLabel.Text = "ID самолёта";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 141);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(104, 19);
            first_NameLabel.TabIndex = 38;
            first_NameLabel.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label1.Location = new System.Drawing.Point(19, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 19);
            label1.TabIndex = 58;
            label1.Text = "ID аэропорта";
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
            this.BoxLine4.Location = new System.Drawing.Point(23, 163);
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
            this.ButtonCreate.Location = new System.Drawing.Point(23, 281);
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
            this.LanLabel.Location = new System.Drawing.Point(73, 254);
            this.LanLabel.Name = "LanLabel";
            this.LanLabel.Size = new System.Drawing.Size(117, 22);
            this.LanLabel.TabIndex = 55;
            this.LanLabel.Text = "Ваша раскладка: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(23, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 2);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
            // 
            // airport_NameTextBox
            // 
            this.airport_NameTextBox.BackColor = System.Drawing.Color.White;
            this.airport_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airport_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airport_NameTextBox.Location = new System.Drawing.Point(136, 141);
            this.airport_NameTextBox.Name = "airport_NameTextBox";
            this.airport_NameTextBox.Size = new System.Drawing.Size(155, 19);
            this.airport_NameTextBox.TabIndex = 64;
            this.airport_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AirPortsComboBox
            // 
            this.AirPortsComboBox.Animated = true;
            this.AirPortsComboBox.BackColor = System.Drawing.Color.White;
            this.AirPortsComboBox.BorderColor = System.Drawing.Color.White;
            this.AirPortsComboBox.BorderThickness = 0;
            this.AirPortsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirPortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirPortsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortsComboBox.FocusedState.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirPortsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirPortsComboBox.HoverState.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.ItemHeight = 30;
            this.AirPortsComboBox.ItemsAppearance.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Location = new System.Drawing.Point(127, 88);
            this.AirPortsComboBox.Name = "AirPortsComboBox";
            this.AirPortsComboBox.ShadowDecoration.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Size = new System.Drawing.Size(164, 36);
            this.AirPortsComboBox.TabIndex = 66;
            // 
            // airCraftBindingSource
            // 
            this.airCraftBindingSource.DataMember = "AirCraft";
            this.airCraftBindingSource.DataSource = this.flightBookingDBA;
            // 
            // airCraftTableAdapter
            // 
            this.airCraftTableAdapter.ClearBeforeFill = true;
            // 
            // airCraft_IDLabel1
            // 
            this.airCraft_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airCraftBindingSource, "AirCraft ID", true));
            this.airCraft_IDLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airCraft_IDLabel1.Location = new System.Drawing.Point(136, 57);
            this.airCraft_IDLabel1.Name = "airCraft_IDLabel1";
            this.airCraft_IDLabel1.Size = new System.Drawing.Size(155, 23);
            this.airCraft_IDLabel1.TabIndex = 68;
            this.airCraft_IDLabel1.Text = "ID";
            this.airCraft_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airPort_IDTextBox
            // 
            this.airPort_IDTextBox.BackColor = System.Drawing.Color.White;
            this.airPort_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airPort_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airCraftBindingSource, "AirPort ID", true));
            this.airPort_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airPort_IDTextBox.Location = new System.Drawing.Point(136, 101);
            this.airPort_IDTextBox.Name = "airPort_IDTextBox";
            this.airPort_IDTextBox.ReadOnly = true;
            this.airPort_IDTextBox.Size = new System.Drawing.Size(155, 19);
            this.airPort_IDTextBox.TabIndex = 69;
            // 
            // airCraft_NameTextBox
            // 
            this.airCraft_NameTextBox.BackColor = System.Drawing.Color.White;
            this.airCraft_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airCraft_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airCraftBindingSource, "AirCraft Name", true));
            this.airCraft_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airCraft_NameTextBox.Location = new System.Drawing.Point(136, 141);
            this.airCraft_NameTextBox.Name = "airCraft_NameTextBox";
            this.airCraft_NameTextBox.ShortcutsEnabled = false;
            this.airCraft_NameTextBox.Size = new System.Drawing.Size(155, 19);
            this.airCraft_NameTextBox.TabIndex = 70;
            this.airCraft_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.airCraft_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.airCraft_NameTextBox_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(23, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 2);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label2.Location = new System.Drawing.Point(19, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 19);
            label2.TabIndex = 71;
            label2.Text = "Бизнес класс";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.textBox2.Location = new System.Drawing.Point(136, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 19);
            this.textBox2.TabIndex = 73;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(25, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 2);
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label3.Location = new System.Drawing.Point(21, 222);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 19);
            label3.TabIndex = 75;
            label3.Text = "Эконом класс";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.textBox4.Location = new System.Drawing.Point(138, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 19);
            this.textBox4.TabIndex = 77;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // business_Class_CapacityTextBox
            // 
            this.business_Class_CapacityTextBox.BackColor = System.Drawing.Color.White;
            this.business_Class_CapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.business_Class_CapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airCraftBindingSource, "Business Class Capacity", true));
            this.business_Class_CapacityTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.business_Class_CapacityTextBox.Location = new System.Drawing.Point(136, 181);
            this.business_Class_CapacityTextBox.Name = "business_Class_CapacityTextBox";
            this.business_Class_CapacityTextBox.ShortcutsEnabled = false;
            this.business_Class_CapacityTextBox.Size = new System.Drawing.Size(155, 19);
            this.business_Class_CapacityTextBox.TabIndex = 79;
            this.business_Class_CapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.business_Class_CapacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.business_Class_CapacityTextBox_KeyPress);
            // 
            // economy_Class_CapacityTextBox
            // 
            this.economy_Class_CapacityTextBox.BackColor = System.Drawing.Color.White;
            this.economy_Class_CapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.economy_Class_CapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airCraftBindingSource, "Economy Class Capacity", true));
            this.economy_Class_CapacityTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.economy_Class_CapacityTextBox.Location = new System.Drawing.Point(136, 222);
            this.economy_Class_CapacityTextBox.Name = "economy_Class_CapacityTextBox";
            this.economy_Class_CapacityTextBox.ShortcutsEnabled = false;
            this.economy_Class_CapacityTextBox.Size = new System.Drawing.Size(155, 19);
            this.economy_Class_CapacityTextBox.TabIndex = 80;
            this.economy_Class_CapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.economy_Class_CapacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.economy_Class_CapacityTextBox_KeyPress);
            // 
            // AdminAirCPCraftcreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 322);
            this.Controls.Add(this.economy_Class_CapacityTextBox);
            this.Controls.Add(this.business_Class_CapacityTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.airCraft_NameTextBox);
            this.Controls.Add(this.airCraft_IDLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.airport_NameTextBox);
            this.Controls.Add(this.AirPortsComboBox);
            this.Controls.Add(this.airPort_IDTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAirCPCraftcreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Самолёта";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerLanguage;
        private Guna.UI2.WinForms.Guna2ComboBox AirPortsComboBox;
        private System.Windows.Forms.TextBox airport_NameTextBox;
        private System.Windows.Forms.BindingSource airCraftBindingSource;
        private FlightBookingDNBTableAdapters.AirCraftTableAdapter airCraftTableAdapter;
        private System.Windows.Forms.Label airCraft_IDLabel1;
        private System.Windows.Forms.TextBox airPort_IDTextBox;
        private System.Windows.Forms.TextBox airCraft_NameTextBox;
        private System.Windows.Forms.TextBox economy_Class_CapacityTextBox;
        private System.Windows.Forms.TextBox business_Class_CapacityTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}