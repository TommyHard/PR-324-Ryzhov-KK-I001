
namespace FlightBookingForms
{
    partial class AdminPersonalArea
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label role_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label user_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPersonalArea));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.UserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine7 = new System.Windows.Forms.PictureBox();
            this.BoxLine6 = new System.Windows.Forms.PictureBox();
            this.BoxLine5 = new System.Windows.Forms.PictureBox();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine3 = new System.Windows.Forms.PictureBox();
            this.BoxLine2 = new System.Windows.Forms.PictureBox();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.role_IDLabel2 = new System.Windows.Forms.Label();
            this.loginLabel2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.RoleIDLabel = new System.Windows.Forms.Label();
            this.BoxLine1 = new System.Windows.Forms.PictureBox();
            this.user_IDLabel2 = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            role_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            user_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            loginLabel.Location = new System.Drawing.Point(80, 136);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(47, 19);
            loginLabel.TabIndex = 26;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            passwordLabel.Location = new System.Drawing.Point(80, 179);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 19);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Пароль";
            // 
            // role_IDLabel
            // 
            role_IDLabel.AutoSize = true;
            role_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            role_IDLabel.Location = new System.Drawing.Point(80, 93);
            role_IDLabel.Name = "role_IDLabel";
            role_IDLabel.Size = new System.Drawing.Size(58, 19);
            role_IDLabel.TabIndex = 28;
            role_IDLabel.Text = "ID роли";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(80, 222);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(36, 19);
            first_NameLabel.TabIndex = 29;
            first_NameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            patronymicLabel.Location = new System.Drawing.Point(80, 308);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(68, 19);
            patronymicLabel.TabIndex = 30;
            patronymicLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            surnameLabel.Location = new System.Drawing.Point(80, 265);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(66, 19);
            surnameLabel.TabIndex = 31;
            surnameLabel.Text = "Фамилия";
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
            this.UserName.Location = new System.Drawing.Point(12, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(103, 23);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Пользователь:";
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.Gray;
            this.BoxLine.Location = new System.Drawing.Point(14, 38);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(461, 2);
            this.BoxLine.TabIndex = 5;
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
            this.nameTextBox.TabIndex = 6;
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
            this.ButtonBackWards.Location = new System.Drawing.Point(14, 46);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(87, 33);
            this.ButtonBackWards.TabIndex = 1;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // BoxLine7
            // 
            this.BoxLine7.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine7.Location = new System.Drawing.Point(84, 330);
            this.BoxLine7.Name = "BoxLine7";
            this.BoxLine7.Size = new System.Drawing.Size(320, 2);
            this.BoxLine7.TabIndex = 38;
            this.BoxLine7.TabStop = false;
            // 
            // BoxLine6
            // 
            this.BoxLine6.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine6.Location = new System.Drawing.Point(84, 287);
            this.BoxLine6.Name = "BoxLine6";
            this.BoxLine6.Size = new System.Drawing.Size(320, 2);
            this.BoxLine6.TabIndex = 37;
            this.BoxLine6.TabStop = false;
            // 
            // BoxLine5
            // 
            this.BoxLine5.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine5.Location = new System.Drawing.Point(84, 244);
            this.BoxLine5.Name = "BoxLine5";
            this.BoxLine5.Size = new System.Drawing.Size(320, 2);
            this.BoxLine5.TabIndex = 36;
            this.BoxLine5.TabStop = false;
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(84, 201);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(320, 2);
            this.BoxLine4.TabIndex = 35;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine3
            // 
            this.BoxLine3.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine3.Location = new System.Drawing.Point(84, 158);
            this.BoxLine3.Name = "BoxLine3";
            this.BoxLine3.Size = new System.Drawing.Size(320, 2);
            this.BoxLine3.TabIndex = 34;
            this.BoxLine3.TabStop = false;
            // 
            // BoxLine2
            // 
            this.BoxLine2.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine2.Location = new System.Drawing.Point(84, 115);
            this.BoxLine2.Name = "BoxLine2";
            this.BoxLine2.Size = new System.Drawing.Size(320, 2);
            this.BoxLine2.TabIndex = 33;
            this.BoxLine2.TabStop = false;
            // 
            // flightBookingDBA
            // 
            this.flightBookingDBA.DataSetName = "FlightBookingDBA";
            this.flightBookingDBA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.flightBookingDBA;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RateTableAdapter = null;
            this.tableAdapterManager.Reservation_PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Seat_NumberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // role_IDLabel2
            // 
            this.role_IDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role ID", true));
            this.role_IDLabel2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.role_IDLabel2.Location = new System.Drawing.Point(203, 89);
            this.role_IDLabel2.Name = "role_IDLabel2";
            this.role_IDLabel2.Size = new System.Drawing.Size(201, 23);
            this.role_IDLabel2.TabIndex = 41;
            this.role_IDLabel2.Text = "ID";
            this.role_IDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.role_IDLabel2.Visible = false;
            // 
            // loginLabel2
            // 
            this.loginLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Login", true));
            this.loginLabel2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loginLabel2.Location = new System.Drawing.Point(203, 132);
            this.loginLabel2.Name = "loginLabel2";
            this.loginLabel2.Size = new System.Drawing.Size(201, 23);
            this.loginLabel2.TabIndex = 42;
            this.loginLabel2.Text = "Login";
            this.loginLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.passwordTextBox.Location = new System.Drawing.Point(203, 179);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ShortcutsEnabled = false;
            this.passwordTextBox.Size = new System.Drawing.Size(201, 19);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "First Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.first_NameTextBox.Location = new System.Drawing.Point(203, 222);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ShortcutsEnabled = false;
            this.first_NameTextBox.Size = new System.Drawing.Size(201, 19);
            this.first_NameTextBox.TabIndex = 3;
            this.first_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_NameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.surnameTextBox.Location = new System.Drawing.Point(203, 265);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ShortcutsEnabled = false;
            this.surnameTextBox.Size = new System.Drawing.Size(201, 19);
            this.surnameTextBox.TabIndex = 4;
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Patronymic", true));
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.patronymicTextBox.Location = new System.Drawing.Point(203, 308);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.ShortcutsEnabled = false;
            this.patronymicTextBox.Size = new System.Drawing.Size(201, 19);
            this.patronymicTextBox.TabIndex = 5;
            this.patronymicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicTextBox_KeyPress);
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
            this.ButtonSave.Location = new System.Drawing.Point(84, 347);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(320, 33);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Сохранить и обновить";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // RoleIDLabel
            // 
            this.RoleIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role ID", true));
            this.RoleIDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoleIDLabel.Location = new System.Drawing.Point(203, 89);
            this.RoleIDLabel.Name = "RoleIDLabel";
            this.RoleIDLabel.Size = new System.Drawing.Size(201, 23);
            this.RoleIDLabel.TabIndex = 43;
            this.RoleIDLabel.Text = "ID";
            this.RoleIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(512, 220);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(112, 19);
            user_IDLabel.TabIndex = 25;
            user_IDLabel.Text = "ID пользователя";
            // 
            // BoxLine1
            // 
            this.BoxLine1.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine1.Location = new System.Drawing.Point(516, 242);
            this.BoxLine1.Name = "BoxLine1";
            this.BoxLine1.Size = new System.Drawing.Size(320, 2);
            this.BoxLine1.TabIndex = 32;
            this.BoxLine1.TabStop = false;
            // 
            // user_IDLabel2
            // 
            this.user_IDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User ID", true));
            this.user_IDLabel2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.user_IDLabel2.Location = new System.Drawing.Point(635, 216);
            this.user_IDLabel2.Name = "user_IDLabel2";
            this.user_IDLabel2.Size = new System.Drawing.Size(201, 23);
            this.user_IDLabel2.TabIndex = 40;
            this.user_IDLabel2.Text = "ID";
            this.user_IDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPersonalArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 395);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginLabel2);
            this.Controls.Add(this.user_IDLabel2);
            this.Controls.Add(this.BoxLine7);
            this.Controls.Add(this.BoxLine6);
            this.Controls.Add(this.BoxLine5);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine3);
            this.Controls.Add(this.BoxLine2);
            this.Controls.Add(this.BoxLine1);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(role_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.RoleIDLabel);
            this.Controls.Add(this.role_IDLabel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPersonalArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный Кабинет";
            this.Load += new System.EventHandler(this.AdminPersonalArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserName;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.PictureBox BoxLine7;
        private System.Windows.Forms.PictureBox BoxLine6;
        private System.Windows.Forms.PictureBox BoxLine5;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine3;
        private System.Windows.Forms.PictureBox BoxLine2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.UsersTableAdapter usersTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel2;
        private System.Windows.Forms.Label role_IDLabel2;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private System.Windows.Forms.Label RoleIDLabel;
        private System.Windows.Forms.Label user_IDLabel2;
        private System.Windows.Forms.PictureBox BoxLine1;
    }
}