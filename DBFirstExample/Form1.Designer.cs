namespace DBFirstExample
{
    partial class Form1
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblshopping = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.trainingDBDataSet = new DBFirstExample.TrainingDBDataSet();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new DBFirstExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 429);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 51);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(683, 429);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 51);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbID
            // 
            this.cbID.DataSource = this.registerShoppingBindingSource;
            this.cbID.DisplayMember = "Name";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(233, 14);
            this.cbID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(199, 28);
            this.cbID.TabIndex = 35;
            this.cbID.ValueMember = "Id";
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 20;
            this.lbselect.Location = new System.Drawing.Point(641, -7);
            this.lbselect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(452, 264);
            this.lbselect.TabIndex = 34;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(683, 344);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 62);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(683, 271);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 63);
            this.btnRegister.TabIndex = 32;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(258, 545);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(164, 26);
            this.txtpassword.TabIndex = 31;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(292, 429);
            this.cbcod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(76, 24);
            this.cbcod.TabIndex = 30;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Apparels",
            "Cosmetics",
            "Shoes",
            "Mobiles",
            "Laptops",
            "Electronic Gadgets",
            "Kitchen Items"});
            this.clbshop.Location = new System.Drawing.Point(292, 255);
            this.clbshop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(339, 151);
            this.clbshop.TabIndex = 29;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(313, 200);
            this.rbpaid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(62, 24);
            this.rbpaid.TabIndex = 28;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(228, 200);
            this.rbfree.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(64, 24);
            this.rbfree.TabIndex = 27;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(233, 118);
            this.cbgender.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(199, 28);
            this.cbgender.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(228, 53);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(277, 26);
            this.txtname.TabIndex = 25;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(90, 551);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(135, 20);
            this.lblpassword.TabIndex = 24;
            this.lblpassword.Text = "Enter Password";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(53, 429);
            this.lblcod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(111, 20);
            this.lblcod.TabIndex = 23;
            this.lblcod.Text = "Prefer COD?";
            // 
            // lblshopping
            // 
            this.lblshopping.AutoSize = true;
            this.lblshopping.Location = new System.Drawing.Point(42, 262);
            this.lblshopping.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblshopping.Name = "lblshopping";
            this.lblshopping.Size = new System.Drawing.Size(234, 20);
            this.lblshopping.TabIndex = 22;
            this.lblshopping.Text = "Select Shopping Preference";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(53, 200);
            this.lblmembership.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(162, 20);
            this.lblmembership.TabIndex = 21;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(90, 126);
            this.lblgender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(125, 20);
            this.lblgender.TabIndex = 20;
            this.lblgender.Text = "Select Gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(98, 56);
            this.lblname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(104, 20);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Enter Name";
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(478, 525);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(143, 46);
            this.btnSP.TabIndex = 38;
            this.btnSP.Text = "Call SP";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(959, 733);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblshopping);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblshopping;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnSP;
    }
}