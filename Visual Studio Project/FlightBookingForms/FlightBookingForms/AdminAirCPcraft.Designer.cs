
namespace FlightBookingForms
{
    partial class AdminAirCPcraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAirCPcraft));
            this.ButtonCreation = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRemoving = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBackWards = new Guna.UI2.WinForms.Guna2Button();
            this.airCraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBookingDBA = new FlightBookingForms.FlightBookingDNB();
            this.AnimWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.airCraftTableAdapter = new FlightBookingForms.FlightBookingDNBTableAdapters.AirCraftTableAdapter();
            this.tableAdapterManager = new FlightBookingForms.FlightBookingDNBTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirCraftTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirCraftTable)).BeginInit();
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
            this.ButtonCreation.TabIndex = 16;
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
            this.ButtonRemoving.TabIndex = 15;
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
            this.ButtonEdit.TabIndex = 14;
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
            this.ButtonBackWards.TabIndex = 13;
            this.ButtonBackWards.Text = "Назад";
            this.ButtonBackWards.Click += new System.EventHandler(this.ButtonBackWards_Click);
            // 
            // airCraftBindingSource
            // 
            this.airCraftBindingSource.DataMember = "AirCraft";
            this.airCraftBindingSource.DataSource = this.flightBookingDBA;
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
            // airCraftTableAdapter
            // 
            this.airCraftTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftTableAdapter = this.airCraftTableAdapter;
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
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AirCraft ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID самолёта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 199;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AirPort ID";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID аэропорта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 199;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AirCraft Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 398;
            // 
            // AirCraftTable
            // 
            this.AirCraftTable.AllowUserToResizeColumns = false;
            this.AirCraftTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AirCraftTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AirCraftTable.AutoGenerateColumns = false;
            this.AirCraftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AirCraftTable.BackgroundColor = System.Drawing.Color.White;
            this.AirCraftTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AirCraftTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AirCraftTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AirCraftTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AirCraftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AirCraftTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.AirCraftTable.DataSource = this.airCraftBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AirCraftTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.AirCraftTable.EnableHeadersVisualStyles = false;
            this.AirCraftTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirCraftTable.Location = new System.Drawing.Point(12, 51);
            this.AirCraftTable.Name = "AirCraftTable";
            this.AirCraftTable.ReadOnly = true;
            this.AirCraftTable.RowHeadersVisible = false;
            this.AirCraftTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AirCraftTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AirCraftTable.Size = new System.Drawing.Size(796, 387);
            this.AirCraftTable.TabIndex = 16;
            this.AirCraftTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.AirCraftTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AirCraftTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AirCraftTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AirCraftTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AirCraftTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AirCraftTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AirCraftTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirCraftTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.AirCraftTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AirCraftTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirCraftTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AirCraftTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AirCraftTable.ThemeStyle.HeaderStyle.Height = 23;
            this.AirCraftTable.ThemeStyle.ReadOnly = true;
            this.AirCraftTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AirCraftTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AirCraftTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AirCraftTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AirCraftTable.ThemeStyle.RowsStyle.Height = 22;
            this.AirCraftTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AirCraftTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AirCraft ID";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID самолёта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AirPort ID";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID аэропорта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AirCraft Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Business Class Capacity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Мест в бизнесс классе";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Economy Class Capacity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Мест в эконом классе";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AdminAirCPcraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.AirCraftTable);
            this.Controls.Add(this.ButtonCreation);
            this.Controls.Add(this.ButtonRemoving);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonBackWards);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAirCPcraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Самолёты";
            this.Load += new System.EventHandler(this.AdminAirCPcraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirCraftTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ButtonCreation;
        private Guna.UI2.WinForms.Guna2Button ButtonRemoving;
        private Guna.UI2.WinForms.Guna2Button ButtonEdit;
        private Guna.UI2.WinForms.Guna2Button ButtonBackWards;
        private FlightBookingDNB flightBookingDBA;
        private System.Windows.Forms.BindingSource airCraftBindingSource;
        private FlightBookingDNBTableAdapters.AirCraftTableAdapter airCraftTableAdapter;
        private FlightBookingDNBTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimWindow;
        private Guna.UI2.WinForms.Guna2DataGridView AirCraftTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}