
namespace FlightBookingForms
{
    partial class AdminFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFlight));
            this.ButtonCreation = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemoving = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.FlightTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_SchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flight_SchedulesTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.ButtonPrice = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlightTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            this.SuspendLayout();
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
            // FlightTable
            // 
            this.FlightTable.AllowUserToResizeColumns = false;
            this.FlightTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.FlightTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FlightTable.AutoGenerateColumns = false;
            this.FlightTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlightTable.BackgroundColor = System.Drawing.Color.White;
            this.FlightTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FlightTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FlightTable.ColumnHeadersHeight = 40;
            this.FlightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FlightTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.FlightTable.DataSource = this.flight_SchedulesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FlightTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.FlightTable.EnableHeadersVisualStyles = false;
            this.FlightTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightTable.Location = new System.Drawing.Point(12, 51);
            this.FlightTable.Name = "FlightTable";
            this.FlightTable.ReadOnly = true;
            this.FlightTable.RowHeadersVisible = false;
            this.FlightTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FlightTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightTable.Size = new System.Drawing.Size(796, 387);
            this.FlightTable.TabIndex = 13;
            this.FlightTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.FlightTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FlightTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FlightTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FlightTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FlightTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FlightTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.FlightTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FlightTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FlightTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FlightTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FlightTable.ThemeStyle.HeaderStyle.Height = 40;
            this.FlightTable.ThemeStyle.ReadOnly = true;
            this.FlightTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FlightTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FlightTable.ThemeStyle.RowsStyle.Height = 22;
            this.FlightTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Flight ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID рейса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AirPort ID";
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID аэропорта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AirCraft ID";
            this.dataGridViewTextBoxColumn3.FillWeight = 20F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID самолёта";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Origin City ID";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID города отправления";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Destination City ID";
            this.dataGridViewTextBoxColumn5.FillWeight = 20F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID города прибытия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Departure Date Time";
            this.dataGridViewTextBoxColumn6.FillWeight = 26.24365F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Время отправления";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Arrival Date Time";
            this.dataGridViewTextBoxColumn7.FillWeight = 26.24365F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Время прибытия";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // flight_SchedulesBindingSource
            // 
            this.flight_SchedulesBindingSource.DataMember = "Flight Schedules";
            this.flight_SchedulesBindingSource.DataSource = this.flightBookingDBA;
            // 
            // flightBookingDBA
            // 
            this.flightBookingDBA.DataSetName = "FlightBookingDBA";
            this.flightBookingDBA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
            // 
            // flight_SchedulesTableAdapter
            // 
            this.flight_SchedulesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Flight_SchedulesTableAdapter = this.flight_SchedulesTableAdapter;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RateTableAdapter = null;
            this.tableAdapterManager.Reservation_PaymentsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Seat_NumberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ButtonPrice
            // 
            this.ButtonPrice.Animated = true;
            this.ButtonPrice.CheckedState.Parent = this.ButtonPrice;
            this.ButtonPrice.CustomImages.Parent = this.ButtonPrice;
            this.ButtonPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonPrice.ForeColor = System.Drawing.Color.White;
            this.ButtonPrice.HoverState.Parent = this.ButtonPrice;
            this.ButtonPrice.Location = new System.Drawing.Point(170, 12);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.ShadowDecoration.Parent = this.ButtonPrice;
            this.ButtonPrice.Size = new System.Drawing.Size(95, 33);
            this.ButtonPrice.TabIndex = 14;
            this.ButtonPrice.Text = "Цены";
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // AdminFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.ButtonPrice);
            this.Controls.Add(this.FlightTable);
            this.Controls.Add(this.ButtonCreation);
            this.Controls.Add(this.ButtonRemoving);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.AdminFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_SchedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonCreation;
        private Guna.UI2.WinForms.Guna2Button ButtonRemoving;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private FlightBookingDNB flightBookingDBA;
        private System.Windows.Forms.BindingSource flight_SchedulesBindingSource;
        private FlightBookingDNBTableAdapters.Flight_SchedulesTableAdapter flight_SchedulesTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2DataGridView FlightTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2Button ButtonPrice;
    }
}