
namespace FlightBookingForms
{
    partial class AdminUsersEditing
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label role_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label surnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersEditing));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.BoxLine6 = new System.Windows.Forms.PictureBox();
            this.BoxLine5 = new System.Windows.Forms.PictureBox();
            this.BoxLine4 = new System.Windows.Forms.PictureBox();
            this.BoxLine3 = new System.Windows.Forms.PictureBox();
            this.BoxLine2 = new System.Windows.Forms.PictureBox();
            this.BoxLine1 = new System.Windows.Forms.PictureBox();
            this.BoxLine = new System.Windows.Forms.PictureBox();
            this.role_IDComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.user_IDLabel2 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.LanLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.role_IDTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCopy = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonRdnPassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonCopyLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TimerLanguage = new System.Windows.Forms.Timer(this.components);
            user_IDLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            role_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRdnPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopyLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            user_IDLabel.Location = new System.Drawing.Point(28, 61);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(112, 19);
            user_IDLabel.TabIndex = 48;
            user_IDLabel.Text = "ID пользователя";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            loginLabel.Location = new System.Drawing.Point(28, 147);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(47, 19);
            loginLabel.TabIndex = 49;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            passwordLabel.Location = new System.Drawing.Point(28, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 19);
            passwordLabel.TabIndex = 50;
            passwordLabel.Text = "Пароль";
            // 
            // role_IDLabel
            // 
            role_IDLabel.AutoSize = true;
            role_IDLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            role_IDLabel.Location = new System.Drawing.Point(28, 104);
            role_IDLabel.Name = "role_IDLabel";
            role_IDLabel.Size = new System.Drawing.Size(58, 19);
            role_IDLabel.TabIndex = 51;
            role_IDLabel.Text = "ID роли";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            first_NameLabel.Location = new System.Drawing.Point(28, 233);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(36, 19);
            first_NameLabel.TabIndex = 52;
            first_NameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            patronymicLabel.Location = new System.Drawing.Point(28, 319);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(68, 19);
            patronymicLabel.TabIndex = 53;
            patronymicLabel.Text = "Отчество";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            surnameLabel.Location = new System.Drawing.Point(28, 276);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(66, 19);
            surnameLabel.TabIndex = 54;
            surnameLabel.Text = "Фамилия";
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
            this.ButtonBackWards.Location = new System.Drawing.Point(32, 12);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(268, 33);
            this.ButtonBackWards.TabIndex = 1;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // BoxLine6
            // 
            this.BoxLine6.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine6.Location = new System.Drawing.Point(32, 341);
            this.BoxLine6.Name = "BoxLine6";
            this.BoxLine6.Size = new System.Drawing.Size(268, 2);
            this.BoxLine6.TabIndex = 61;
            this.BoxLine6.TabStop = false;
            // 
            // BoxLine5
            // 
            this.BoxLine5.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine5.Location = new System.Drawing.Point(32, 298);
            this.BoxLine5.Name = "BoxLine5";
            this.BoxLine5.Size = new System.Drawing.Size(268, 2);
            this.BoxLine5.TabIndex = 60;
            this.BoxLine5.TabStop = false;
            // 
            // BoxLine4
            // 
            this.BoxLine4.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine4.Location = new System.Drawing.Point(32, 255);
            this.BoxLine4.Name = "BoxLine4";
            this.BoxLine4.Size = new System.Drawing.Size(268, 2);
            this.BoxLine4.TabIndex = 59;
            this.BoxLine4.TabStop = false;
            // 
            // BoxLine3
            // 
            this.BoxLine3.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine3.Location = new System.Drawing.Point(32, 212);
            this.BoxLine3.Name = "BoxLine3";
            this.BoxLine3.Size = new System.Drawing.Size(268, 2);
            this.BoxLine3.TabIndex = 58;
            this.BoxLine3.TabStop = false;
            // 
            // BoxLine2
            // 
            this.BoxLine2.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine2.Location = new System.Drawing.Point(32, 169);
            this.BoxLine2.Name = "BoxLine2";
            this.BoxLine2.Size = new System.Drawing.Size(268, 2);
            this.BoxLine2.TabIndex = 57;
            this.BoxLine2.TabStop = false;
            // 
            // BoxLine1
            // 
            this.BoxLine1.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine1.Location = new System.Drawing.Point(32, 126);
            this.BoxLine1.Name = "BoxLine1";
            this.BoxLine1.Size = new System.Drawing.Size(268, 2);
            this.BoxLine1.TabIndex = 56;
            this.BoxLine1.TabStop = false;
            // 
            // BoxLine
            // 
            this.BoxLine.BackColor = System.Drawing.Color.DarkGray;
            this.BoxLine.Location = new System.Drawing.Point(32, 83);
            this.BoxLine.Name = "BoxLine";
            this.BoxLine.Size = new System.Drawing.Size(268, 2);
            this.BoxLine.TabIndex = 55;
            this.BoxLine.TabStop = false;
            // 
            // role_IDComboBox
            // 
            this.role_IDComboBox.Animated = true;
            this.role_IDComboBox.BackColor = System.Drawing.Color.White;
            this.role_IDComboBox.BorderColor = System.Drawing.Color.White;
            this.role_IDComboBox.BorderThickness = 0;
            this.role_IDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_IDComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role_IDComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.role_IDComboBox.FocusedState.Parent = this.role_IDComboBox;
            this.role_IDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.role_IDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.role_IDComboBox.HoverState.Parent = this.role_IDComboBox;
            this.role_IDComboBox.ItemHeight = 30;
            this.role_IDComboBox.ItemsAppearance.Parent = this.role_IDComboBox;
            this.role_IDComboBox.Location = new System.Drawing.Point(127, 88);
            this.role_IDComboBox.Name = "role_IDComboBox";
            this.role_IDComboBox.ShadowDecoration.Parent = this.role_IDComboBox;
            this.role_IDComboBox.Size = new System.Drawing.Size(173, 36);
            this.role_IDComboBox.TabIndex = 2;
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
            // user_IDLabel2
            // 
            this.user_IDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "User ID", true));
            this.user_IDLabel2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.user_IDLabel2.Location = new System.Drawing.Point(145, 57);
            this.user_IDLabel2.Name = "user_IDLabel2";
            this.user_IDLabel2.Size = new System.Drawing.Size(155, 23);
            this.user_IDLabel2.TabIndex = 64;
            this.user_IDLabel2.Text = "ID";
            this.user_IDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Login", true));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loginTextBox.Location = new System.Drawing.Point(145, 147);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.ShortcutsEnabled = false;
            this.loginTextBox.Size = new System.Drawing.Size(155, 19);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.passwordTextBox.Location = new System.Drawing.Point(145, 190);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ShortcutsEnabled = false;
            this.passwordTextBox.Size = new System.Drawing.Size(155, 19);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "First Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.first_NameTextBox.Location = new System.Drawing.Point(145, 233);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ShortcutsEnabled = false;
            this.first_NameTextBox.Size = new System.Drawing.Size(155, 19);
            this.first_NameTextBox.TabIndex = 5;
            this.first_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_NameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.surnameTextBox.Location = new System.Drawing.Point(145, 276);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ShortcutsEnabled = false;
            this.surnameTextBox.Size = new System.Drawing.Size(155, 19);
            this.surnameTextBox.TabIndex = 6;
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Patronymic", true));
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.patronymicTextBox.Location = new System.Drawing.Point(145, 319);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.ShortcutsEnabled = false;
            this.patronymicTextBox.Size = new System.Drawing.Size(155, 19);
            this.patronymicTextBox.TabIndex = 7;
            this.patronymicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicTextBox_KeyPress);
            // 
            // LanLabel
            // 
            this.LanLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanLabel.Location = new System.Drawing.Point(82, 352);
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
            this.ButtonSave.Location = new System.Drawing.Point(32, 381);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(268, 33);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // role_IDTextBox
            // 
            this.role_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role ID", true));
            this.role_IDTextBox.Location = new System.Drawing.Point(200, 98);
            this.role_IDTextBox.Name = "role_IDTextBox";
            this.role_IDTextBox.ReadOnly = true;
            this.role_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_IDTextBox.TabIndex = 72;
            this.role_IDTextBox.Visible = false;
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCopy.Image")));
            this.ButtonCopy.Location = new System.Drawing.Point(85, 177);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.ShadowDecoration.Parent = this.ButtonCopy;
            this.ButtonCopy.Size = new System.Drawing.Size(28, 35);
            this.ButtonCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCopy.TabIndex = 74;
            this.ButtonCopy.TabStop = false;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonRdnPassword
            // 
            this.ButtonRdnPassword.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRdnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRdnPassword.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRdnPassword.Image")));
            this.ButtonRdnPassword.Location = new System.Drawing.Point(111, 176);
            this.ButtonRdnPassword.Name = "ButtonRdnPassword";
            this.ButtonRdnPassword.ShadowDecoration.Parent = this.ButtonRdnPassword;
            this.ButtonRdnPassword.Size = new System.Drawing.Size(34, 37);
            this.ButtonRdnPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRdnPassword.TabIndex = 73;
            this.ButtonRdnPassword.TabStop = false;
            this.ButtonRdnPassword.Click += new System.EventHandler(this.ButtonRdnPassword_Click);
            // 
            // ButtonCopyLogin
            // 
            this.ButtonCopyLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCopyLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCopyLogin.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCopyLogin.Image")));
            this.ButtonCopyLogin.Location = new System.Drawing.Point(85, 131);
            this.ButtonCopyLogin.Name = "ButtonCopyLogin";
            this.ButtonCopyLogin.ShadowDecoration.Parent = this.ButtonCopyLogin;
            this.ButtonCopyLogin.Size = new System.Drawing.Size(28, 35);
            this.ButtonCopyLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCopyLogin.TabIndex = 75;
            this.ButtonCopyLogin.TabStop = false;
            this.ButtonCopyLogin.Click += new System.EventHandler(this.ButtonCopyLogin_Click);
            // 
            // TimerLanguage
            // 
            this.TimerLanguage.Tick += new System.EventHandler(this.TimerLanguage_Tick);
            // 
            // AdminUsersEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 426);
            this.Controls.Add(this.ButtonCopyLogin);
            this.Controls.Add(this.LanLabel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.user_IDLabel2);
            this.Controls.Add(this.BoxLine6);
            this.Controls.Add(this.BoxLine5);
            this.Controls.Add(this.BoxLine4);
            this.Controls.Add(this.BoxLine3);
            this.Controls.Add(this.BoxLine2);
            this.Controls.Add(this.BoxLine1);
            this.Controls.Add(this.BoxLine);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(role_IDLabel);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.role_IDComboBox);
            this.Controls.Add(this.role_IDTextBox);
            this.Controls.Add(this.ButtonRdnPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminUsersEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRdnPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCopyLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.PictureBox BoxLine6;
        private System.Windows.Forms.PictureBox BoxLine5;
        private System.Windows.Forms.PictureBox BoxLine4;
        private System.Windows.Forms.PictureBox BoxLine3;
        private System.Windows.Forms.PictureBox BoxLine2;
        private System.Windows.Forms.PictureBox BoxLine1;
        private System.Windows.Forms.PictureBox BoxLine;
        private Guna.UI2.WinForms.Guna2ComboBox role_IDComboBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.UsersTableAdapter usersTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label user_IDLabel2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel LanLabel;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private System.Windows.Forms.TextBox role_IDTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonCopy;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonRdnPassword;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonCopyLogin;
        private System.Windows.Forms.Timer TimerLanguage;
    }
}