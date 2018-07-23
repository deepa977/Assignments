namespace DisconnectedExample
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.dgSelect = new System.Windows.Forms.DataGridView();
            this.lbXML = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCallSP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDBDataSet = new DisconnectedExample.TrainingDBDataSet();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new DisconnectedExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingPreferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(91, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 44);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(423, 38);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(155, 45);
            this.btnXML.TabIndex = 2;
            this.btnXML.Text = "ShowXML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // dgSelect
            // 
            this.dgSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelect.Location = new System.Drawing.Point(111, 119);
            this.dgSelect.Name = "dgSelect";
            this.dgSelect.Size = new System.Drawing.Size(487, 274);
            this.dgSelect.TabIndex = 3;
            // 
            // lbXML
            // 
            this.lbXML.FormattingEnabled = true;
            this.lbXML.ItemHeight = 24;
            this.lbXML.Location = new System.Drawing.Point(667, 119);
            this.lbXML.Name = "lbXML";
            this.lbXML.Size = new System.Drawing.Size(212, 316);
            this.lbXML.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(756, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 29);
            this.txtID.TabIndex = 6;
            // 
            // btnCallSP
            // 
            this.btnCallSP.Location = new System.Drawing.Point(882, 59);
            this.btnCallSP.Name = "btnCallSP";
            this.btnCallSP.Size = new System.Drawing.Size(89, 29);
            this.btnCallSP.TabIndex = 7;
            this.btnCallSP.Text = "Call SP";
            this.btnCallSP.UseVisualStyleBackColor = true;
            this.btnCallSP.Click += new System.EventHandler(this.btnCallSP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.membershipDataGridViewTextBoxColumn,
            this.shoppingPreferenceDataGridViewTextBoxColumn,
            this.cODDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registerShoppingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 232);
            this.dataGridView1.TabIndex = 8;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // membershipDataGridViewTextBoxColumn
            // 
            this.membershipDataGridViewTextBoxColumn.DataPropertyName = "Membership";
            this.membershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.membershipDataGridViewTextBoxColumn.Name = "membershipDataGridViewTextBoxColumn";
            // 
            // shoppingPreferenceDataGridViewTextBoxColumn
            // 
            this.shoppingPreferenceDataGridViewTextBoxColumn.DataPropertyName = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.HeaderText = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.Name = "shoppingPreferenceDataGridViewTextBoxColumn";
            // 
            // cODDataGridViewTextBoxColumn
            // 
            this.cODDataGridViewTextBoxColumn.DataPropertyName = "COD";
            this.cODDataGridViewTextBoxColumn.HeaderText = "COD";
            this.cODDataGridViewTextBoxColumn.Name = "cODDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCallSP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbXML);
            this.Controls.Add(this.dgSelect);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView dgSelect;
        private System.Windows.Forms.ListBox lbXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCallSP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingPreferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}

