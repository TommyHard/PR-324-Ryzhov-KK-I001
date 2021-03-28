
namespace FlightBookingForms
{
    partial class AdminRateEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRateEditing));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            this.flightBookingDNB = new FlightBookingForms.FlightBookingDNB();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rateTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.RateTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.rate_IDLabel1 = new System.Windows.Forms.Label();
            this.hand_luggageLabel1 = new System.Windows.Forms.Label();
            this.baggageLabel1 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            user_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(19, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(73, 19);
            user_IDLabel.TabIndex = 76;
            user_IDLabel.Text = "ID тарифа";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(19, 98);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(94, 19);
            first_NameLabel.TabIndex = 77;
            first_NameLabel.Text = "Ручная кладь";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label1.Location = new System.Drawing.Point(19, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 19);
            label1.TabIndex = 83;
            label1.Text = "Багаж";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            label2.Location = new System.Drawing.Point(19, 178);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 19);
            label2.TabIndex = 85;
            label2.Text = "Стоимость";
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
            // 
            // LanLabel
            // 
            this.LanLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanLabel.Location = new System.Drawing.Point(73, 209);
            this.LanLabel.Name = "LanLabel";
            this.LanLabel.Size = new System.Drawing.Size(117, 22);
            this.LanLabel.TabIndex = 80;
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
            this.ButtonSave.Location = new System.Drawing.Point(23, 236);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(268, 33);
            this.ButtonSave.TabIndex = 75;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(23, 120);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(268, 2);
            this.BoxLine4.TabIndex = 79;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(23, 83);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(268, 2);
            this.BoxLine.TabIndex = 78;
            this.BoxLine.TabStop = false;
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
            this.ButtonBackWards.TabIndex = 73;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(23, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 2);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(23, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 2);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
            // 
            // flightBookingDNB
            // 
            this.flightBookingDNB.DataSetName = "FlightBookingDNB";
            this.flightBookingDNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataMember = "Rate";
            this.rateBindingSource.DataSource = this.flightBookingDNB;
            // 
            // rateTableAdapter
            // 
            this.rateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftTableAdapter = null;
            this.tableAdapterManager.AirPortsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Booked_TicketTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Flight_CostsTableAdapter = null;
            this.tableAdapterManager.Flight_SchedulesTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RateTableAdapter = this.rateTableAdapter;
            this.tableAdapterManager.Reservation_PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Seat_NumberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // rate_IDLabel1
            // 
            this.rate_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rateBindingSource, "Rate ID", true));
            this.rate_IDLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rate_IDLabel1.Location = new System.Drawing.Point(136, 57);
            this.rate_IDLabel1.Name = "rate_IDLabel1";
            this.rate_IDLabel1.Size = new System.Drawing.Size(155, 23);
            this.rate_IDLabel1.TabIndex = 88;
            this.rate_IDLabel1.Text = "ID";
            this.rate_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hand_luggageLabel1
            // 
            this.hand_luggageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rateBindingSource, "Hand luggage", true));
            this.hand_luggageLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.hand_luggageLabel1.Location = new System.Drawing.Point(136, 94);
            this.hand_luggageLabel1.Name = "hand_luggageLabel1";
            this.hand_luggageLabel1.Size = new System.Drawing.Size(155, 23);
            this.hand_luggageLabel1.TabIndex = 89;
            this.hand_luggageLabel1.Text = "Yes | No";
            this.hand_luggageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baggageLabel1
            // 
            this.baggageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rateBindingSource, "Baggage", true));
            this.baggageLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.baggageLabel1.Location = new System.Drawing.Point(136, 133);
            this.baggageLabel1.Name = "baggageLabel1";
            this.baggageLabel1.Size = new System.Drawing.Size(155, 23);
            this.baggageLabel1.TabIndex = 90;
            this.baggageLabel1.Text = "Yes | No";
            this.baggageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.Color.White;
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rateBindingSource, "Cost", true));
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.costTextBox.Location = new System.Drawing.Point(136, 178);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ShortcutsEnabled = false;
            this.costTextBox.Size = new System.Drawing.Size(155, 19);
            this.costTextBox.TabIndex = 91;
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // AdminRateEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 277);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.baggageLabel1);
            this.Controls.Add(this.hand_luggageLabel1);
            this.Controls.Add(this.rate_IDLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminRateEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerLanguage;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private FlightBookingDNB flightBookingDNB;
        private FlightBookingDNBTableAdapters.RateTableAdapter rateTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label baggageLabel1;
        private System.Windows.Forms.Label hand_luggageLabel1;
        private System.Windows.Forms.Label rate_IDLabel1;
    }
}