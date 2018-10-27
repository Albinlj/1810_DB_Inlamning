namespace _02_Hotel
{
    partial class frmCreateCustomer
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
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(97, 173);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(120, 23);
            this.btnCreateCustomer.TabIndex = 6;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(97, 16);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(201, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(97, 43);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(201, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(97, 70);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(201, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(97, 95);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(201, 20);
            this.tbCity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Postal Code";
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(97, 120);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(201, 20);
            this.tbPostalCode.TabIndex = 4;
            this.tbPostalCode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Country";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(97, 147);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(201, 20);
            this.tbCountry.TabIndex = 5;
            // 
            // frmCreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 211);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateCustomer);
            this.Name = "frmCreateCustomer";
            this.Text = "Create New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCountry;
    }
}