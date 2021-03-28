
namespace FlightBookingForms
{
    partial class AdminCaC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCaC));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonCreation = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemoving = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.countryTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.CountryTableAdapter();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountryTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonCities = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 300;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // ButtonCreation
            // 
            this.ButtonCreation.Animated = true;
            this.ButtonCreation.CheckedState.Parent = this.ButtonCreation;
            this.ButtonCreation.CustomImages.Parent = this.ButtonCreation;
            this.ButtonCreation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonCreation.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonCreation.ForeColor = System.Drawing.Color.White;
            this.ButtonCreation.HoverState.Parent = this.ButtonCreation;
            this.ButtonCreation.Location = new System.Drawing.Point(271, 12);
            this.ButtonCreation.Name = "ButtonCreation";
            this.ButtonCreation.ShadowDecoration.Parent = this.ButtonCreation;
            this.ButtonCreation.Size = new System.Drawing.Size(175, 33);
            this.ButtonCreation.TabIndex = 12;
            this.ButtonCreation.Text = "Создание";
            this.ButtonCreation.Click += new System.EventHandler(this.ButtonCreation_Click);
            // 
            // ButtonRemoving
            // 
            this.ButtonRemoving.Animated = true;
            this.ButtonRemoving.CheckedState.Parent = this.ButtonRemoving;
            this.ButtonRemoving.CustomImages.Parent = this.ButtonRemoving;
            this.ButtonRemoving.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonRemoving.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonRemoving.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoving.HoverState.Parent = this.ButtonRemoving;
            this.ButtonRemoving.Location = new System.Drawing.Point(452, 12);
            this.ButtonRemoving.Name = "ButtonRemoving";
            this.ButtonRemoving.ShadowDecoration.Parent = this.ButtonRemoving;
            this.ButtonRemoving.Size = new System.Drawing.Size(175, 33);
            this.ButtonRemoving.TabIndex = 11;
            this.ButtonRemoving.Text = "Удаление";
            this.ButtonRemoving.Click += new System.EventHandler(this.ButtonRemoving_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Animated = true;
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Location = new System.Drawing.Point(633, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(175, 33);
            this.ButtonEdit.TabIndex = 10;
            this.ButtonEdit.Text = "Редактирование";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            this.ButtonBackWards.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackWards.Name = "ButtonBackWards";
            this.ButtonBackWards.ShadowDecoration.Parent = this.ButtonBackWards;
            this.ButtonBackWards.Size = new System.Drawing.Size(87, 33);
            this.ButtonBackWards.TabIndex = 9;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
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
            this.tableAdapterManager.CountryTableAdapter = this.countryTableAdapter;
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
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.flightBookingDBA;
            // 
            // CountryTable
            // 
            this.CountryTable.AllowUserToResizeColumns = false;
            this.CountryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CountryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CountryTable.AutoGenerateColumns = false;
            this.CountryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CountryTable.BackgroundColor = System.Drawing.Color.White;
            this.CountryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CountryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CountryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CountryTable.ColumnHeadersHeight = 21;
            this.CountryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CountryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.CountryTable.DataSource = this.countryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CountryTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.CountryTable.EnableHeadersVisualStyles = false;
            this.CountryTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CountryTable.Location = new System.Drawing.Point(12, 51);
            this.CountryTable.Name = "CountryTable";
            this.CountryTable.ReadOnly = true;
            this.CountryTable.RowHeadersVisible = false;
            this.CountryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CountryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CountryTable.Size = new System.Drawing.Size(796, 387);
            this.CountryTable.TabIndex = 6;
            this.CountryTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CountryTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CountryTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CountryTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CountryTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CountryTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CountryTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CountryTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CountryTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.CountryTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CountryTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CountryTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CountryTable.ThemeStyle.HeaderStyle.Height = 21;
            this.CountryTable.ThemeStyle.ReadOnly = true;
            this.CountryTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CountryTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CountryTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CountryTable.ThemeStyle.RowsStyle.Height = 22;
            this.CountryTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CountryTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Country ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID страны";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ButtonCities
            // 
            this.ButtonCities.Animated = true;
            this.ButtonCities.CheckedState.Parent = this.ButtonCities;
            this.ButtonCities.CustomImages.Parent = this.ButtonCities;
            this.ButtonCities.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonCities.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonCities.ForeColor = System.Drawing.Color.White;
            this.ButtonCities.HoverState.Parent = this.ButtonCities;
            this.ButtonCities.Location = new System.Drawing.Point(170, 12);
            this.ButtonCities.Name = "ButtonCities";
            this.ButtonCities.ShadowDecoration.Parent = this.ButtonCities;
            this.ButtonCities.Size = new System.Drawing.Size(95, 33);
            this.ButtonCities.TabIndex = 13;
            this.ButtonCities.Text = "Города";
            this.ButtonCities.Click += new System.EventHandler(this.ButtonCities_Click);
            // 
            // AdminCaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.ButtonCities);
            this.Controls.Add(this.CountryTable);
            this.Controls.Add(this.ButtonCreation);
            this.Controls.Add(this.ButtonRemoving);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminCaC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.AdminCaC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button ButtonCreation;
        private Guna.UI2.WinForms.Guna2Button ButtonRemoving;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private FlightBookingDNBTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView CountryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2Button ButtonCities;
    }
}