
namespace FlightBookingForms
{
    partial class AdminFlightPriceEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlightPriceEditing));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.FlightIDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flight_CostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_CostsTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.Flight_CostsTableAdapter();
            this.flight_IDTextBox = new System.Windows.Forms.TextBox();
            this.flight_CostTextBox = new System.Windows.Forms.TextBox();
            this.costs_IDTextBox = new System.Windows.Forms.TextBox();
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_CostsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 63);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(63, 19);
            user_IDLabel.TabIndex = 48;
            user_IDLabel.Text = "ID рейса";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 103);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(77, 19);
            first_NameLabel.TabIndex = 52;
            first_NameLabel.Text = "Стоимость";
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
            this.BoxLine4.Location = new System.Drawing.Point(23, 125);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(268, 2);
            this.BoxLine4.TabIndex = 59;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(23, 85);
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
            this.LanLabel.Location = new System.Drawing.Point(73, 134);
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
            this.ButtonSave.Location = new System.Drawing.Point(23, 160);
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
            // FlightIDComboBox
            // 
            this.FlightIDComboBox.BackColor = System.Drawing.Color.White;
            this.FlightIDComboBox.BorderColor = System.Drawing.Color.White;
            this.FlightIDComboBox.BorderThickness = 0;
            this.FlightIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FlightIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightIDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightIDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightIDComboBox.FocusedState.Parent = this.FlightIDComboBox;
            this.FlightIDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FlightIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FlightIDComboBox.HoverState.Parent = this.FlightIDComboBox;
            this.FlightIDComboBox.ItemHeight = 30;
            this.FlightIDComboBox.ItemsAppearance.Parent = this.FlightIDComboBox;
            this.FlightIDComboBox.Location = new System.Drawing.Point(88, 48);
            this.FlightIDComboBox.Name = "FlightIDComboBox";
            this.FlightIDComboBox.ShadowDecoration.Parent = this.FlightIDComboBox;
            this.FlightIDComboBox.Size = new System.Drawing.Size(203, 36);
            this.FlightIDComboBox.TabIndex = 78;
            this.FlightIDComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flight_CostsBindingSource
            // 
            this.flight_CostsBindingSource.DataMember = "Flight Costs";
            this.flight_CostsBindingSource.DataSource = this.flightBookingDBA;
            // 
            // flight_CostsTableAdapter
            // 
            this.flight_CostsTableAdapter.ClearBeforeFill = true;
            // 
            // flight_IDTextBox
            // 
            this.flight_IDTextBox.BackColor = System.Drawing.Color.White;
            this.flight_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flight_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_CostsBindingSource, "Flight ID", true));
            this.flight_IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.flight_IDTextBox.Location = new System.Drawing.Point(136, 63);
            this.flight_IDTextBox.Name = "flight_IDTextBox";
            this.flight_IDTextBox.Size = new System.Drawing.Size(155, 19);
            this.flight_IDTextBox.TabIndex = 79;
            this.flight_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flight_CostTextBox
            // 
            this.flight_CostTextBox.BackColor = System.Drawing.Color.White;
            this.flight_CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flight_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_CostsBindingSource, "Flight Cost", true));
            this.flight_CostTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.flight_CostTextBox.Location = new System.Drawing.Point(136, 103);
            this.flight_CostTextBox.Name = "flight_CostTextBox";
            this.flight_CostTextBox.ShortcutsEnabled = false;
            this.flight_CostTextBox.Size = new System.Drawing.Size(155, 19);
            this.flight_CostTextBox.TabIndex = 80;
            this.flight_CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.flight_CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flight_CostTextBox_KeyPress);
            // 
            // costs_IDTextBox
            // 
            this.costs_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flight_CostsBindingSource, "Costs ID", true));
            this.costs_IDTextBox.Location = new System.Drawing.Point(640, 134);
            this.costs_IDTextBox.Name = "costs_IDTextBox";
            this.costs_IDTextBox.ReadOnly = true;
            this.costs_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.costs_IDTextBox.TabIndex = 81;
            // 
            // AdminFlightPriceEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 204);
            this.Controls.Add(this.costs_IDTextBox);
            this.Controls.Add(this.flight_CostTextBox);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.FlightIDComboBox);
            this.Controls.Add(this.flight_IDTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminFlightPriceEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_CostsBindingSource)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ComboBox FlightIDComboBox;
        private System.Windows.Forms.BindingSource flight_CostsBindingSource;
        private FlightBookingDNBTableAdapters.Flight_CostsTableAdapter flight_CostsTableAdapter;
        private System.Windows.Forms.TextBox flight_IDTextBox;
        private System.Windows.Forms.TextBox flight_CostTextBox;
        private System.Windows.Forms.TextBox costs_IDTextBox;
    }
}