
namespace FlightBookingForms
{
    partial class AdminAirCPediting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAirCPediting));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AirPortsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.airPortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPortsTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.AirPortsTableAdapter();
            this.airport_IDLabel1 = new System.Windows.Forms.Label();
            this.airport_LocationTextBox = new System.Windows.Forms.TextBox();
            this.airport_NameTextBox = new System.Windows.Forms.TextBox();
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(93, 19);
            user_IDLabel.TabIndex = 48;
            user_IDLabel.Text = "ID аэропорта";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 101);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(101, 19);
            first_NameLabel.TabIndex = 52;
            first_NameLabel.Text = "Расположение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label1.Location = new System.Drawing.Point(19, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 19);
            label1.TabIndex = 74;
            label1.Text = "Наименование";
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
            this.ButtonBackWards.Size = new System.Drawing.Size(268, 33);
            this.ButtonBackWards.TabIndex = 1;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(23, 123);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(268, 2);
            this.BoxLine4.TabIndex = 59;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(23, 83);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(268, 2);
            this.BoxLine.TabIndex = 55;
            this.BoxLine.TabStop = false;
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
            this.LanLabel.Location = new System.Drawing.Point(73, 173);
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
            this.ButtonSave.Location = new System.Drawing.Point(23, 200);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(268, 33);
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
            this.pictureBox1.Location = new System.Drawing.Point(23, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 2);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // AirPortsComboBox
            // 
            this.AirPortsComboBox.BackColor = System.Drawing.Color.White;
            this.AirPortsComboBox.BorderColor = System.Drawing.Color.White;
            this.AirPortsComboBox.BorderThickness = 0;
            this.AirPortsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AirPortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirPortsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AirPortsComboBox.FocusedState.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AirPortsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AirPortsComboBox.HoverState.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.ItemHeight = 30;
            this.AirPortsComboBox.ItemsAppearance.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Location = new System.Drawing.Point(140, 87);
            this.AirPortsComboBox.Name = "AirPortsComboBox";
            this.AirPortsComboBox.ShadowDecoration.Parent = this.AirPortsComboBox;
            this.AirPortsComboBox.Size = new System.Drawing.Size(151, 36);
            this.AirPortsComboBox.TabIndex = 78;
            // 
            // airPortsBindingSource
            // 
            this.airPortsBindingSource.DataMember = "AirPorts";
            this.airPortsBindingSource.DataSource = this.flightBookingDBA;
            // 
            // airPortsTableAdapter
            // 
            this.airPortsTableAdapter.ClearBeforeFill = true;
            // 
            // airport_IDLabel1
            // 
            this.airport_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airPortsBindingSource, "Airport ID", true));
            this.airport_IDLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airport_IDLabel1.Location = new System.Drawing.Point(136, 57);
            this.airport_IDLabel1.Name = "airport_IDLabel1";
            this.airport_IDLabel1.Size = new System.Drawing.Size(155, 23);
            this.airport_IDLabel1.TabIndex = 79;
            this.airport_IDLabel1.Text = "ID";
            this.airport_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airport_LocationTextBox
            // 
            this.airport_LocationTextBox.BackColor = System.Drawing.Color.White;
            this.airport_LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airport_LocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airPortsBindingSource, "Airport Location", true));
            this.airport_LocationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airport_LocationTextBox.Location = new System.Drawing.Point(136, 101);
            this.airport_LocationTextBox.Name = "airport_LocationTextBox";
            this.airport_LocationTextBox.Size = new System.Drawing.Size(155, 19);
            this.airport_LocationTextBox.TabIndex = 80;
            this.airport_LocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // airport_NameTextBox
            // 
            this.airport_NameTextBox.BackColor = System.Drawing.Color.White;
            this.airport_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airport_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airPortsBindingSource, "Airport Name", true));
            this.airport_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.airport_NameTextBox.Location = new System.Drawing.Point(136, 141);
            this.airport_NameTextBox.Name = "airport_NameTextBox";
            this.airport_NameTextBox.ShortcutsEnabled = false;
            this.airport_NameTextBox.Size = new System.Drawing.Size(155, 19);
            this.airport_NameTextBox.TabIndex = 81;
            this.airport_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.airport_NameTextBox_KeyPress);
            // 
            // AdminAirCPediting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 243);
            this.Controls.Add(this.airport_NameTextBox);
            this.Controls.Add(this.airport_IDLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.AirPortsComboBox);
            this.Controls.Add(this.airport_LocationTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAirCPediting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private System.Windows.Forms.Timer TimerLanguage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox AirPortsComboBox;
        private System.Windows.Forms.BindingSource airPortsBindingSource;
        private FlightBookingDNBTableAdapters.AirPortsTableAdapter airPortsTableAdapter;
        private System.Windows.Forms.Label airport_IDLabel1;
        private System.Windows.Forms.TextBox airport_NameTextBox;
        private System.Windows.Forms.TextBox airport_LocationTextBox;
    }
}