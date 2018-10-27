namespace _02_Hotel
{
    partial class frmBooking
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
            this.dtpBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingTo = new System.Windows.Forms.DateTimePicker();
            this.dgBookingRooms = new System.Windows.Forms.DataGridView();
            this.cbBookingPeople = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookingBook = new System.Windows.Forms.Button();
            this.btnBookingCancel = new System.Windows.Forms.Button();
            this.dgBookings = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extrabedBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxExtraBedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBookingFrom
            // 
            this.dtpBookingFrom.Location = new System.Drawing.Point(12, 201);
            this.dtpBookingFrom.MinDate = new System.DateTime(2018, 10, 27, 0, 0, 0, 0);
            this.dtpBookingFrom.Name = "dtpBookingFrom";
            this.dtpBookingFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingFrom.TabIndex = 0;
            this.dtpBookingFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpBookingTo
            // 
            this.dtpBookingTo.Location = new System.Drawing.Point(12, 277);
            this.dtpBookingTo.Name = "dtpBookingTo";
            this.dtpBookingTo.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingTo.TabIndex = 0;
            this.dtpBookingTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dgBookingRooms
            // 
            this.dgBookingRooms.AutoGenerateColumns = false;
            this.dgBookingRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookingRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bedsDataGridViewTextBoxColumn,
            this.maxExtraBedsDataGridViewTextBoxColumn,
            this.bookingsDataGridViewTextBoxColumn});
            this.dgBookingRooms.DataSource = this.roomBindingSource;
            this.dgBookingRooms.Location = new System.Drawing.Point(242, 38);
            this.dgBookingRooms.Name = "dgBookingRooms";
            this.dgBookingRooms.Size = new System.Drawing.Size(565, 435);
            this.dgBookingRooms.TabIndex = 1;
            // 
            // cbBookingPeople
            // 
            this.cbBookingPeople.FormattingEnabled = true;
            this.cbBookingPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbBookingPeople.Location = new System.Drawing.Point(15, 124);
            this.cbBookingPeople.Name = "cbBookingPeople";
            this.cbBookingPeople.Size = new System.Drawing.Size(111, 21);
            this.cbBookingPeople.TabIndex = 2;
            this.cbBookingPeople.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "People";
            // 
            // btnBookingBook
            // 
            this.btnBookingBook.Location = new System.Drawing.Point(15, 359);
            this.btnBookingBook.Name = "btnBookingBook";
            this.btnBookingBook.Size = new System.Drawing.Size(75, 23);
            this.btnBookingBook.TabIndex = 4;
            this.btnBookingBook.Text = "Book Room";
            this.btnBookingBook.UseVisualStyleBackColor = true;
            this.btnBookingBook.Click += new System.EventHandler(this.btnBookingBook_Click);
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.Location = new System.Drawing.Point(121, 359);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookingCancel.TabIndex = 5;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            this.btnBookingCancel.Click += new System.EventHandler(this.btnBookingCancel_Click);
            // 
            // dgBookings
            // 
            this.dgBookings.AutoGenerateColumns = false;
            this.dgBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn,
            this.dateBookedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.paymentsDataGridViewTextBoxColumn,
            this.customersDataGridViewTextBoxColumn,
            this.extrabedBookingDataGridViewTextBoxColumn});
            this.dgBookings.DataSource = this.bookingBindingSource;
            this.dgBookings.Location = new System.Drawing.Point(242, 492);
            this.dgBookings.Name = "dgBookings";
            this.dgBookings.Size = new System.Drawing.Size(565, 208);
            this.dgBookings.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "DateTo";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            // 
            // dateBookedDataGridViewTextBoxColumn
            // 
            this.dateBookedDataGridViewTextBoxColumn.DataPropertyName = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.HeaderText = "DateBooked";
            this.dateBookedDataGridViewTextBoxColumn.Name = "dateBookedDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // paymentsDataGridViewTextBoxColumn
            // 
            this.paymentsDataGridViewTextBoxColumn.DataPropertyName = "Payments";
            this.paymentsDataGridViewTextBoxColumn.HeaderText = "Payments";
            this.paymentsDataGridViewTextBoxColumn.Name = "paymentsDataGridViewTextBoxColumn";
            // 
            // customersDataGridViewTextBoxColumn
            // 
            this.customersDataGridViewTextBoxColumn.DataPropertyName = "Customers";
            this.customersDataGridViewTextBoxColumn.HeaderText = "Customers";
            this.customersDataGridViewTextBoxColumn.Name = "customersDataGridViewTextBoxColumn";
            // 
            // extrabedBookingDataGridViewTextBoxColumn
            // 
            this.extrabedBookingDataGridViewTextBoxColumn.DataPropertyName = "ExtrabedBooking";
            this.extrabedBookingDataGridViewTextBoxColumn.HeaderText = "ExtrabedBooking";
            this.extrabedBookingDataGridViewTextBoxColumn.Name = "extrabedBookingDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(_02_Hotel.Booking);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bedsDataGridViewTextBoxColumn
            // 
            this.bedsDataGridViewTextBoxColumn.DataPropertyName = "Beds";
            this.bedsDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bedsDataGridViewTextBoxColumn.Name = "bedsDataGridViewTextBoxColumn";
            // 
            // maxExtraBedsDataGridViewTextBoxColumn
            // 
            this.maxExtraBedsDataGridViewTextBoxColumn.DataPropertyName = "MaxExtraBeds";
            this.maxExtraBedsDataGridViewTextBoxColumn.HeaderText = "MaxExtraBeds";
            this.maxExtraBedsDataGridViewTextBoxColumn.Name = "maxExtraBedsDataGridViewTextBoxColumn";
            // 
            // bookingsDataGridViewTextBoxColumn
            // 
            this.bookingsDataGridViewTextBoxColumn.DataPropertyName = "Bookings";
            this.bookingsDataGridViewTextBoxColumn.HeaderText = "Bookings";
            this.bookingsDataGridViewTextBoxColumn.Name = "bookingsDataGridViewTextBoxColumn";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(_02_Hotel.Room);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 712);
            this.Controls.Add(this.dgBookings);
            this.Controls.Add(this.btnBookingCancel);
            this.Controls.Add(this.btnBookingBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBookingPeople);
            this.Controls.Add(this.dgBookingRooms);
            this.Controls.Add(this.dtpBookingTo);
            this.Controls.Add(this.dtpBookingFrom);
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBookingFrom;
        private System.Windows.Forms.DateTimePicker dtpBookingTo;
        private System.Windows.Forms.DataGridView dgBookingRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxExtraBedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ComboBox cbBookingPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookingBook;
        private System.Windows.Forms.Button btnBookingCancel;
        private System.Windows.Forms.DataGridView dgBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extrabedBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingBindingSource;
    }
}