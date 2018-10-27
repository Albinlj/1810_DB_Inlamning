namespace _01_Recept
{
    partial class frmRecipes
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
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIngredients = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Location = new System.Drawing.Point(12, 26);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(137, 20);
            this.tbSearchTitle.TabIndex = 0;
            this.tbSearchTitle.TextChanged += new System.EventHandler(this.tbSearchTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by Category";
            // 
            // lstItems
            // 
            this.lstItems.DisplayMember = "Title";
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 68);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(264, 290);
            this.lstItems.Sorted = true;
            this.lstItems.TabIndex = 4;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(155, 26);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cbSearchCategory.TabIndex = 5;
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(_01_Recept.Category);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(364, 69);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(180, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(364, 124);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(180, 112);
            this.tbDescription.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "Name";
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Location = new System.Drawing.Point(364, 95);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(180, 21);
            this.cbCategory.TabIndex = 10;
            this.cbCategory.ValueMember = "CategoryID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingredients";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Location = new System.Drawing.Point(364, 242);
            this.tbIngredients.Multiline = true;
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIngredients.Size = new System.Drawing.Size(180, 112);
            this.tbIngredients.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(102, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 399);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIngredients);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.cbSearchCategory);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchTitle);
            this.Name = "frmRecipes";
            this.Text = "frmRecipes";
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIngredients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}

