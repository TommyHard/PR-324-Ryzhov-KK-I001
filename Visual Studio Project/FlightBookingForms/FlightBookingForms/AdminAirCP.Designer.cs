
namespace FlightBookingForms
{
    partial class AdminAirCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAirCP));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ButtonCreation = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemoving = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.airPortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPortsTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.AirPortsTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.AirPortsTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAirCraft = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPortsTable)).BeginInit();
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
            // airPortsBindingSource
            // 
            this.airPortsBindingSource.DataMember = "AirPorts";
            this.airPortsBindingSource.DataSource = this.flightBookingDBA;
            // 
            // airPortsTableAdapter
            // 
            this.airPortsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftTableAdapter = null;
            this.tableAdapterManager.AirPortsTableAdapter = this.airPortsTableAdapter;
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
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // AirPortsTable
            // 
            this.AirPortsTable.AllowUserToResizeColumns = false;
            this.AirPortsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AirPortsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AirPortsTable.AutoGenerateColumns = false;
            this.AirPortsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AirPortsTable.BackgroundColor = System.Drawing.Color.White;
            this.AirPortsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AirPortsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AirPortsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AirPortsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AirPortsTable.ColumnHeadersHeight = 28;
            this.AirPortsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.AirPortsTable.DataSource = this.airPortsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AirPortsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.AirPortsTable.EnableHeadersVisualStyles = false;
            this.AirPortsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirPortsTable.Location = new System.Drawing.Point(12, 51);
            this.AirPortsTable.Name = "AirPortsTable";
            this.AirPortsTable.ReadOnly = true;
            this.AirPortsTable.RowHeadersVisible = false;
            this.AirPortsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AirPortsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AirPortsTable.Size = new System.Drawing.Size(796, 387);
            this.AirPortsTable.TabIndex = 13;
            this.AirPortsTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.AirPortsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AirPortsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AirPortsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AirPortsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AirPortsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AirPortsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AirPortsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirPortsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.AirPortsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AirPortsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirPortsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AirPortsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AirPortsTable.ThemeStyle.HeaderStyle.Height = 28;
            this.AirPortsTable.ThemeStyle.ReadOnly = true;
            this.AirPortsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AirPortsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AirPortsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirPortsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AirPortsTable.ThemeStyle.RowsStyle.Height = 22;
            this.AirPortsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirPortsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Airport ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID аэропорта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Airport Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Airport Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Расположение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ButtonAirCraft
            // 
            this.ButtonAirCraft.Animated = true;
            this.ButtonAirCraft.CheckedState.Parent = this.ButtonAirCraft;
            this.ButtonAirCraft.CustomImages.Parent = this.ButtonAirCraft;
            this.ButtonAirCraft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.ButtonAirCraft.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonAirCraft.ForeColor = System.Drawing.Color.White;
            this.ButtonAirCraft.HoverState.Parent = this.ButtonAirCraft;
            this.ButtonAirCraft.Location = new System.Drawing.Point(146, 12);
            this.ButtonAirCraft.Name = "ButtonAirCraft";
            this.ButtonAirCraft.ShadowDecoration.Parent = this.ButtonAirCraft;
            this.ButtonAirCraft.Size = new System.Drawing.Size(119, 33);
            this.ButtonAirCraft.TabIndex = 14;
            this.ButtonAirCraft.Text = "Самолёты";
            this.ButtonAirCraft.Click += new System.EventHandler(this.ButtonAirCraft_Click);
            // 
            // AdminAirCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.ButtonAirCraft);
            this.Controls.Add(this.AirPortsTable);
            this.Controls.Add(this.ButtonCreation);
            this.Controls.Add(this.ButtonRemoving);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAirCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аэропорты";
            this.Load += new System.EventHandler(this.AdminAirPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPortsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button ButtonCreation;
        private Guna.UI2.WinForms.Guna2Button ButtonRemoving;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private System.Windows.Forms.BindingSource airPortsBindingSource;
        private FlightBookingDNB flightBookingDBA;
        private FlightBookingDNBTableAdapters.AirPortsTableAdapter airPortsTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2DataGridView AirPortsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Guna.UI2.WinForms.Guna2Button ButtonAirCraft;
    }
}