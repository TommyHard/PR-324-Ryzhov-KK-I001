
namespace FlightBookingForms
{
    partial class AdminRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRate));
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flightBookingDNB = new FlightBookingForms.FlightBookingDNB();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rateTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.RateTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.RateTables = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTables)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimWindow
            // 
            this.AnimWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimWindow.Interval = 300;
            this.AnimWindow.TargetForm = this;
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
            // RateTables
            // 
            this.RateTables.AllowUserToResizeColumns = false;
            this.RateTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RateTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RateTables.AutoGenerateColumns = false;
            this.RateTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RateTables.BackgroundColor = System.Drawing.Color.White;
            this.RateTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RateTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RateTables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RateTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RateTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RateTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.RateTables.DataSource = this.rateBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RateTables.DefaultCellStyle = dataGridViewCellStyle3;
            this.RateTables.EnableHeadersVisualStyles = false;
            this.RateTables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RateTables.Location = new System.Drawing.Point(12, 51);
            this.RateTables.Name = "RateTables";
            this.RateTables.ReadOnly = true;
            this.RateTables.RowHeadersVisible = false;
            this.RateTables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RateTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RateTables.Size = new System.Drawing.Size(796, 136);
            this.RateTables.TabIndex = 1;
            this.RateTables.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RateTables.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RateTables.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RateTables.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RateTables.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RateTables.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RateTables.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RateTables.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RateTables.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.RateTables.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RateTables.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateTables.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RateTables.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RateTables.ThemeStyle.HeaderStyle.Height = 23;
            this.RateTables.ThemeStyle.ReadOnly = true;
            this.RateTables.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RateTables.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RateTables.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RateTables.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RateTables.ThemeStyle.RowsStyle.Height = 22;
            this.RateTables.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RateTables.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rate ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID тарифа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hand luggage";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ручная кладь";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Baggage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Багаж";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена (Р)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.ButtonEdit.TabIndex = 9;
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
            this.ButtonBackWards.TabIndex = 8;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // AdminRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 199);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBackWards);
            this.Controls.Add(this.RateTables);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.AdminRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private FlightBookingDNB flightBookingDNB;
        private FlightBookingDNBTableAdapters.RateTableAdapter rateTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2DataGridView RateTables;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}