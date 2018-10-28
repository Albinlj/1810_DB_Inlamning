namespace _02_Hotel
{
    partial class frmNewBooking
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
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxExtraBedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbBookingPeople = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookingBook = new System.Windows.Forms.Button();
            this.btnBookingCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extrabedBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrabedBookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBookingFrom
            // 
            this.dtpBookingFrom.Location = new System.Drawing.Point(12, 116);
            this.dtpBookingFrom.MinDate = new System.DateTime(2018, 10, 27, 0, 0, 0, 0);
            this.dtpBookingFrom.Name = "dtpBookingFrom";
            this.dtpBookingFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingFrom.TabIndex = 0;
            this.dtpBookingFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpBookingTo
            // 
            this.dtpBookingTo.Location = new System.Drawing.Point(12, 156);
            this.dtpBookingTo.Name = "dtpBookingTo";
            this.dtpBookingTo.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingTo.TabIndex = 0;
            this.dtpBookingTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dgBookingRooms
            // 
            this.dgBookingRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBookingRooms.AutoGenerateColumns = false;
            this.dgBookingRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookingRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookingRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.bedsDataGridViewTextBoxColumn,
            this.maxExtraBedsDataGridViewTextBoxColumn});
            this.dgBookingRooms.DataSource = this.roomBindingSource;
            this.dgBookingRooms.Location = new System.Drawing.Point(242, 34);
            this.dgBookingRooms.Name = "dgBookingRooms";
            this.dgBookingRooms.Size = new System.Drawing.Size(540, 199);
            this.dgBookingRooms.TabIndex = 1;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
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
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(_02_Hotel.Room);
            // 
            // cbBookingPeople
            // 
            this.cbBookingPeople.FormattingEnabled = true;
            this.cbBookingPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbBookingPeople.Location = new System.Drawing.Point(12, 74);
            this.cbBookingPeople.Name = "cbBookingPeople";
            this.cbBookingPeople.Size = new System.Drawing.Size(200, 21);
            this.cbBookingPeople.TabIndex = 2;
            this.cbBookingPeople.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guest Amount";
            // 
            // btnBookingBook
            // 
            this.btnBookingBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBookingBook.Location = new System.Drawing.Point(12, 210);
            this.btnBookingBook.Name = "btnBookingBook";
            this.btnBookingBook.Size = new System.Drawing.Size(75, 23);
            this.btnBookingBook.TabIndex = 4;
            this.btnBookingBook.Text = "Book Room";
            this.btnBookingBook.UseVisualStyleBackColor = true;
            this.btnBookingBook.Click += new System.EventHandler(this.btnBookingBook_Click);
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBookingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookingCancel.Location = new System.Drawing.Point(93, 210);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookingCancel.TabIndex = 5;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            this.btnBookingCancel.Click += new System.EventHandler(this.btnBookingCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Available Rooms";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(_02_Hotel.Booking);
            // 
            // extrabedBookingBindingSource
            // 
            this.extrabedBookingBindingSource.DataSource = typeof(_02_Hotel.ExtrabedBooking);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Booking Customer";
            // 
            // cbCustomers
            // 
            this.cbCustomers.DisplayMember = "FullName";
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(12, 34);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(200, 21);
            this.cbCustomers.TabIndex = 8;
            // 
            // frmNewBooking
            // 
            this.AcceptButton = this.btnBookingBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBookingCancel;
            this.ClientSize = new System.Drawing.Size(794, 245);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookingCancel);
            this.Controls.Add(this.btnBookingBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBookingPeople);
            this.Controls.Add(this.dgBookingRooms);
            this.Controls.Add(this.dtpBookingTo);
            this.Controls.Add(this.dtpBookingFrom);
            this.Name = "frmNewBooking";
            this.Text = "Strut";
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrabedBookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBookingFrom;
        private System.Windows.Forms.DateTimePicker dtpBookingTo;
        private System.Windows.Forms.DataGridView dgBookingRooms;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ComboBox cbBookingPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookingBook;
        private System.Windows.Forms.Button btnBookingCancel;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource extrabedBookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxExtraBedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCustomers;
    }
}