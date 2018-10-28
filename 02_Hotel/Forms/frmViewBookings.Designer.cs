namespace _02_Hotel
{
    partial class frmViewBookings
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
            this.dgBookings = new System.Windows.Forms.DataGridView();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnRegisterPayment = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Booker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraBedsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBookings
            // 
            this.dgBookings.AllowUserToAddRows = false;
            this.dgBookings.AllowUserToDeleteRows = false;
            this.dgBookings.AllowUserToOrderColumns = true;
            this.dgBookings.AllowUserToResizeRows = false;
            this.dgBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBookings.AutoGenerateColumns = false;
            this.dgBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsPaid,
            this.Booker,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn,
            this.dateBookedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.extraBedsCountDataGridViewTextBoxColumn});
            this.dgBookings.DataSource = this.bookingBindingSource;
            this.dgBookings.Location = new System.Drawing.Point(12, 43);
            this.dgBookings.Name = "dgBookings";
            this.dgBookings.ReadOnly = true;
            this.dgBookings.Size = new System.Drawing.Size(570, 274);
            this.dgBookings.TabIndex = 0;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(13, 13);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteBooking.TabIndex = 1;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnRegisterPayment
            // 
            this.btnRegisterPayment.Location = new System.Drawing.Point(245, 13);
            this.btnRegisterPayment.Name = "btnRegisterPayment";
            this.btnRegisterPayment.Size = new System.Drawing.Size(124, 23);
            this.btnRegisterPayment.TabIndex = 1;
            this.btnRegisterPayment.Text = "Register Payment";
            this.btnRegisterPayment.UseVisualStyleBackColor = true;
            this.btnRegisterPayment.Click += new System.EventHandler(this.btnRegisterPayment_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(129, 13);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(110, 23);
            this.btnEditBooking.TabIndex = 1;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // IsPaid
            // 
            this.IsPaid.DataPropertyName = "IsPaid";
            this.IsPaid.HeaderText = "IsPaid";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            // 
            // Booker
            // 
            this.Booker.DataPropertyName = "Booker";
            this.Booker.HeaderText = "Booker";
            this.Booker.Name = "Booker";
            this.Booker.ReadOnly = true;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Check In";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Check Out";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateBookedDataGridViewTextBoxColumn
            // 
            this.dateBookedDataGridViewTextBoxColumn.DataPropertyName = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.HeaderText = "Date Booked";
            this.dateBookedDataGridViewTextBoxColumn.Name = "dateBookedDataGridViewTextBoxColumn";
            this.dateBookedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraBedsCountDataGridViewTextBoxColumn
            // 
            this.extraBedsCountDataGridViewTextBoxColumn.DataPropertyName = "ExtraBedsCount";
            this.extraBedsCountDataGridViewTextBoxColumn.HeaderText = "Extra Beds Booked";
            this.extraBedsCountDataGridViewTextBoxColumn.Name = "extraBedsCountDataGridViewTextBoxColumn";
            this.extraBedsCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(_02_Hotel.Booking);
            // 
            // frmViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 329);
            this.Controls.Add(this.btnRegisterPayment);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.dgBookings);
            this.Name = "frmViewBookings";
            this.Text = "frmViewBookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBookings;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnRegisterPayment;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraBedsCountDataGridViewTextBoxColumn;
    }
}