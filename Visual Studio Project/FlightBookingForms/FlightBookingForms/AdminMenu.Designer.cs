
namespace FlightBookingForms
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.UserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPersonalArea = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUsers = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCaC = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAirCP = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFlights = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPassengers = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRate = new Guna.UI2.WinForms.Guna2Button();
            this.SeatNumber = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPayment = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBookedTicket = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(15, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(103, 23);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Пользователь:";
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.Gray;
            this.BoxLine.Location = new System.Drawing.Point(15, 38);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(461, 2);
            this.BoxLine.TabIndex = 2;
            this.BoxLine.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Animated = true;
            this.nameTextBox.BorderColor = System.Drawing.Color.White;
            this.nameTextBox.BorderThickness = 0;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.Parent = this.nameTextBox;
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.FocusedState.Parent = this.nameTextBox;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.HoverState.Parent = this.nameTextBox;
            this.nameTextBox.Location = new System.Drawing.Point(121, 14);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.ShadowDecoration.Parent = this.nameTextBox;
            this.nameTextBox.Size = new System.Drawing.Size(354, 21);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TabStop = false;
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
            this.ButtonBackWards.Location = new System.Drawing.Point(15, 46);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(87, 33);
            this.ButtonBackWards.TabIndex = 7;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // ButtonPersonalArea
            // 
            this.ButtonPersonalArea.Animated = true;
            this.ButtonPersonalArea.CheckedState.Parent = this.ButtonPersonalArea;
            this.ButtonPersonalArea.CustomImages.Parent = this.ButtonPersonalArea;
            this.ButtonPersonalArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonPersonalArea.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonPersonalArea.ForeColor = System.Drawing.Color.White;
            this.ButtonPersonalArea.HoverState.Parent = this.ButtonPersonalArea;
            this.ButtonPersonalArea.Location = new System.Drawing.Point(297, 46);
            this.ButtonPersonalArea.Name = "ButtonPersonalArea";
            this.ButtonPersonalArea.ShadowDecoration.Parent = this.ButtonPersonalArea;
            this.ButtonPersonalArea.Size = new System.Drawing.Size(179, 33);
            this.ButtonPersonalArea.TabIndex = 8;
            this.ButtonPersonalArea.Text = "Личный кабинет";
            this.ButtonPersonalArea.Click += new System.EventHandler(this.ButtonPersonalArea_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.CheckedState.Parent = this.ButtonUsers;
            this.ButtonUsers.CustomImages.Parent = this.ButtonUsers;
            this.ButtonUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUsers.ForeColor = System.Drawing.Color.White;
            this.ButtonUsers.HoverState.Parent = this.ButtonUsers;
            this.ButtonUsers.Location = new System.Drawing.Point(15, 112);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.ShadowDecoration.Parent = this.ButtonUsers;
            this.ButtonUsers.Size = new System.Drawing.Size(461, 33);
            this.ButtonUsers.TabIndex = 9;
            this.ButtonUsers.Text = "Пользователи";
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonCaC
            // 
            this.ButtonCaC.CheckedState.Parent = this.ButtonCaC;
            this.ButtonCaC.CustomImages.Parent = this.ButtonCaC;
            this.ButtonCaC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonCaC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCaC.ForeColor = System.Drawing.Color.White;
            this.ButtonCaC.HoverState.Parent = this.ButtonCaC;
            this.ButtonCaC.Location = new System.Drawing.Point(15, 151);
            this.ButtonCaC.Name = "ButtonCaC";
            this.ButtonCaC.ShadowDecoration.Parent = this.ButtonCaC;
            this.ButtonCaC.Size = new System.Drawing.Size(461, 33);
            this.ButtonCaC.TabIndex = 10;
            this.ButtonCaC.Text = "Города | Страны";
            this.ButtonCaC.Click += new System.EventHandler(this.ButtonCaC_Click);
            // 
            // ButtonAirCP
            // 
            this.ButtonAirCP.CheckedState.Parent = this.ButtonAirCP;
            this.ButtonAirCP.CustomImages.Parent = this.ButtonAirCP;
            this.ButtonAirCP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonAirCP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAirCP.ForeColor = System.Drawing.Color.White;
            this.ButtonAirCP.HoverState.Parent = this.ButtonAirCP;
            this.ButtonAirCP.Location = new System.Drawing.Point(15, 190);
            this.ButtonAirCP.Name = "ButtonAirCP";
            this.ButtonAirCP.ShadowDecoration.Parent = this.ButtonAirCP;
            this.ButtonAirCP.Size = new System.Drawing.Size(461, 33);
            this.ButtonAirCP.TabIndex = 11;
            this.ButtonAirCP.Text = "Аэропорты | Самолёты";
            this.ButtonAirCP.Click += new System.EventHandler(this.ButtonAirCP_Click);
            // 
            // ButtonFlights
            // 
            this.ButtonFlights.CheckedState.Parent = this.ButtonFlights;
            this.ButtonFlights.CustomImages.Parent = this.ButtonFlights;
            this.ButtonFlights.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonFlights.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonFlights.ForeColor = System.Drawing.Color.White;
            this.ButtonFlights.HoverState.Parent = this.ButtonFlights;
            this.ButtonFlights.Location = new System.Drawing.Point(15, 229);
            this.ButtonFlights.Name = "ButtonFlights";
            this.ButtonFlights.ShadowDecoration.Parent = this.ButtonFlights;
            this.ButtonFlights.Size = new System.Drawing.Size(461, 33);
            this.ButtonFlights.TabIndex = 12;
            this.ButtonFlights.Text = "Рейсы | Цены";
            this.ButtonFlights.Click += new System.EventHandler(this.ButtonFlights_Click);
            // 
            // ButtonPassengers
            // 
            this.ButtonPassengers.CheckedState.Parent = this.ButtonPassengers;
            this.ButtonPassengers.CustomImages.Parent = this.ButtonPassengers;
            this.ButtonPassengers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonPassengers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPassengers.ForeColor = System.Drawing.Color.White;
            this.ButtonPassengers.HoverState.Parent = this.ButtonPassengers;
            this.ButtonPassengers.Location = new System.Drawing.Point(15, 268);
            this.ButtonPassengers.Name = "ButtonPassengers";
            this.ButtonPassengers.ShadowDecoration.Parent = this.ButtonPassengers;
            this.ButtonPassengers.Size = new System.Drawing.Size(461, 33);
            this.ButtonPassengers.TabIndex = 13;
            this.ButtonPassengers.Text = "Клиенты";
            this.ButtonPassengers.Click += new System.EventHandler(this.ButtonPassengers_Click);
            // 
            // ButtonRate
            // 
            this.ButtonRate.CheckedState.Parent = this.ButtonRate;
            this.ButtonRate.CustomImages.Parent = this.ButtonRate;
            this.ButtonRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRate.ForeColor = System.Drawing.Color.White;
            this.ButtonRate.HoverState.Parent = this.ButtonRate;
            this.ButtonRate.Location = new System.Drawing.Point(15, 346);
            this.ButtonRate.Name = "ButtonRate";
            this.ButtonRate.ShadowDecoration.Parent = this.ButtonRate;
            this.ButtonRate.Size = new System.Drawing.Size(461, 33);
            this.ButtonRate.TabIndex = 14;
            this.ButtonRate.Text = "Тарифы";
            this.ButtonRate.Click += new System.EventHandler(this.ButtonRate_Click);
            // 
            // SeatNumber
            // 
            this.SeatNumber.CheckedState.Parent = this.SeatNumber;
            this.SeatNumber.CustomImages.Parent = this.SeatNumber;
            this.SeatNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.SeatNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SeatNumber.ForeColor = System.Drawing.Color.White;
            this.SeatNumber.HoverState.Parent = this.SeatNumber;
            this.SeatNumber.Location = new System.Drawing.Point(15, 385);
            this.SeatNumber.Name = "SeatNumber";
            this.SeatNumber.ShadowDecoration.Parent = this.SeatNumber;
            this.SeatNumber.Size = new System.Drawing.Size(461, 33);
            this.SeatNumber.TabIndex = 15;
            this.SeatNumber.Text = "Посадочные места";
            this.SeatNumber.Click += new System.EventHandler(this.SeatNumber_Click);
            // 
            // ButtonPayment
            // 
            this.ButtonPayment.CheckedState.Parent = this.ButtonPayment;
            this.ButtonPayment.CustomImages.Parent = this.ButtonPayment;
            this.ButtonPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPayment.ForeColor = System.Drawing.Color.White;
            this.ButtonPayment.HoverState.Parent = this.ButtonPayment;
            this.ButtonPayment.Location = new System.Drawing.Point(15, 424);
            this.ButtonPayment.Name = "ButtonPayment";
            this.ButtonPayment.ShadowDecoration.Parent = this.ButtonPayment;
            this.ButtonPayment.Size = new System.Drawing.Size(461, 33);
            this.ButtonPayment.TabIndex = 16;
            this.ButtonPayment.Text = "История оплат";
            this.ButtonPayment.Click += new System.EventHandler(this.ButtonPayment_Click);
            // 
            // ButtonBookedTicket
            // 
            this.ButtonBookedTicket.CheckedState.Parent = this.ButtonBookedTicket;
            this.ButtonBookedTicket.CustomImages.Parent = this.ButtonBookedTicket;
            this.ButtonBookedTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonBookedTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBookedTicket.ForeColor = System.Drawing.Color.White;
            this.ButtonBookedTicket.HoverState.Parent = this.ButtonBookedTicket;
            this.ButtonBookedTicket.Location = new System.Drawing.Point(15, 307);
            this.ButtonBookedTicket.Name = "ButtonBookedTicket";
            this.ButtonBookedTicket.ShadowDecoration.Parent = this.ButtonBookedTicket;
            this.ButtonBookedTicket.Size = new System.Drawing.Size(461, 33);
            this.ButtonBookedTicket.TabIndex = 17;
            this.ButtonBookedTicket.Text = "Забронированные билеты";
            this.ButtonBookedTicket.Click += new System.EventHandler(this.ButtonBookedTicket_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 465);
            this.Controls.Add(this.ButtonBookedTicket);
            this.Controls.Add(this.ButtonPayment);
            this.Controls.Add(this.SeatNumber);
            this.Controls.Add(this.ButtonRate);
            this.Controls.Add(this.ButtonPassengers);
            this.Controls.Add(this.ButtonFlights);
            this.Controls.Add(this.ButtonAirCP);
            this.Controls.Add(this.ButtonCaC);
            this.Controls.Add(this.ButtonUsers);
            this.Controls.Add(this.ButtonPersonalArea);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserName;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private Guna.UI2.WinForms.Guna2Button ButtonPersonalArea;
        private Guna.UI2.WinForms.Guna2Button ButtonUsers;
        private Guna.UI2.WinForms.Guna2Button ButtonCaC;
        private Guna.UI2.WinForms.Guna2Button ButtonAirCP;
        private Guna.UI2.WinForms.Guna2Button ButtonFlights;
        private Guna.UI2.WinForms.Guna2Button ButtonPassengers;
        private Guna.UI2.WinForms.Guna2Button ButtonRate;
        private Guna.UI2.WinForms.Guna2Button SeatNumber;
        private Guna.UI2.WinForms.Guna2Button ButtonPayment;
        private Guna.UI2.WinForms.Guna2Button ButtonBookedTicket;
    }
}