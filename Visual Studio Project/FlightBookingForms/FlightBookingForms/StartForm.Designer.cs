
namespace FlightBookingForms
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.PictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PasswordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginField = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicturePassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.ShadowDecoration.Parent = this.PictureLogo;
            this.PictureLogo.Size = new System.Drawing.Size(268, 218);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 9;
            this.PictureLogo.TabStop = false;
            // 
            // PasswordField
            // 
            this.PasswordField.Animated = true;
            this.PasswordField.BorderColor = System.Drawing.Color.White;
            this.PasswordField.BorderThickness = 0;
            this.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordField.DefaultText = "";
            this.PasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.DisabledState.Parent = this.PasswordField;
            this.PasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.FocusedState.Parent = this.PasswordField;
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.HideSelection = false;
            this.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.HoverState.Parent = this.PasswordField;
            this.PasswordField.Location = new System.Drawing.Point(12, 303);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PasswordField.PlaceholderText = "";
            this.PasswordField.SelectedText = "";
            this.PasswordField.ShadowDecoration.Parent = this.PasswordField;
            this.PasswordField.Size = new System.Drawing.Size(268, 36);
            this.PasswordField.TabIndex = 2;
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordField_KeyPress);
            // 
            // LoginField
            // 
            this.LoginField.Animated = true;
            this.LoginField.BorderColor = System.Drawing.Color.White;
            this.LoginField.BorderThickness = 0;
            this.LoginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginField.DefaultText = "";
            this.LoginField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginField.DisabledState.Parent = this.LoginField;
            this.LoginField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginField.FocusedState.Parent = this.LoginField;
            this.LoginField.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.LoginField.ForeColor = System.Drawing.Color.Black;
            this.LoginField.HideSelection = false;
            this.LoginField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginField.HoverState.Parent = this.LoginField;
            this.LoginField.Location = new System.Drawing.Point(12, 254);
            this.LoginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.PlaceholderForeColor = System.Drawing.Color.Black;
            this.LoginField.PlaceholderText = "";
            this.LoginField.SelectedText = "";
            this.LoginField.ShadowDecoration.Parent = this.LoginField;
            this.LoginField.Size = new System.Drawing.Size(268, 36);
            this.LoginField.TabIndex = 1;
            this.LoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginField_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 337);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 2);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 2);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PicturePassword
            // 
            this.PicturePassword.BackColor = System.Drawing.Color.White;
            this.PicturePassword.FillColor = System.Drawing.Color.Silver;
            this.PicturePassword.Image = ((System.Drawing.Image)(resources.GetObject("PicturePassword.Image")));
            this.PicturePassword.Location = new System.Drawing.Point(16, 309);
            this.PicturePassword.Name = "PicturePassword";
            this.PicturePassword.ShadowDecoration.Parent = this.PicturePassword;
            this.PicturePassword.Size = new System.Drawing.Size(26, 25);
            this.PicturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePassword.TabIndex = 14;
            this.PicturePassword.TabStop = false;
            // 
            // PictureLogin
            // 
            this.PictureLogin.BackColor = System.Drawing.Color.White;
            this.PictureLogin.FillColor = System.Drawing.Color.Silver;
            this.PictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogin.Image")));
            this.PictureLogin.Location = new System.Drawing.Point(16, 259);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.ShadowDecoration.Parent = this.PictureLogin;
            this.PictureLogin.Size = new System.Drawing.Size(26, 25);
            this.PictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogin.TabIndex = 13;
            this.PictureLogin.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Animated = true;
            this.ButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.BorderColor = System.Drawing.Color.Gold;
            this.ButtonLogin.CheckedState.Parent = this.ButtonLogin;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.CustomImages.Parent = this.ButtonLogin;
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.HoverState.Parent = this.ButtonLogin;
            this.ButtonLogin.Location = new System.Drawing.Point(12, 363);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.ShadowDecoration.Parent = this.ButtonLogin;
            this.ButtonLogin.Size = new System.Drawing.Size(268, 36);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Вход";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonBackWards
            // 
            this.ButtonBackWards.Animated = true;
            this.ButtonBackWards.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBackWards.BorderColor = System.Drawing.Color.Gold;
            this.ButtonBackWards.CheckedState.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackWards.CustomImages.Parent = this.ButtonBackWards;
            this.ButtonBackWards.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonBackWards.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonBackWards.ForeColor = System.Drawing.Color.White;
            this.ButtonBackWards.HoverState.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Location = new System.Drawing.Point(12, 405);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(268, 36);
            this.ButtonBackWards.TabIndex = 17;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // StartForm
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 451);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicturePassword);
            this.Controls.Add(this.PictureLogin);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.PictureLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightBooking";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2PictureBox PictureLogo;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PicturePassword;
        private Guna.UI2.WinForms.Guna2PictureBox PictureLogin;
        private Guna.UI2.WinForms.Guna2TextBox PasswordField;
        private Guna.UI2.WinForms.Guna2TextBox LoginField;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
    }
}

