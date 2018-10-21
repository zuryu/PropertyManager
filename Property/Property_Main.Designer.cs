namespace PropertyList.Property
{
    partial class Property_Main
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
            this.PropertyTtl = new System.Windows.Forms.Label();
            this.PropertyGV = new System.Windows.Forms.DataGridView();
            this.propertyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.propertyDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet = new PropertyList.Datasets.PropertyDataSet();
            this.propertyDetails1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet1 = new PropertyList.Datasets.PropertyDataSet();
            this.propertyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.property_DetailsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Property_DetailsTableAdapter();
            this.PropertyAddBtn = new System.Windows.Forms.Button();
            this.StreetAddBtn = new System.Windows.Forms.Button();
            this.propertyDetailsIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.property_Details_IDTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Property_Details_IDTableAdapter();
            this.property_Details1TableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Property_Details1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetails1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertyTtl
            // 
            this.PropertyTtl.AutoSize = true;
            this.PropertyTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTtl.Location = new System.Drawing.Point(28, 18);
            this.PropertyTtl.Name = "PropertyTtl";
            this.PropertyTtl.Size = new System.Drawing.Size(117, 31);
            this.PropertyTtl.TabIndex = 0;
            this.PropertyTtl.Text = "Property";
            // 
            // PropertyGV
            // 
            this.PropertyGV.AllowUserToAddRows = false;
            this.PropertyGV.AutoGenerateColumns = false;
            this.PropertyGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyIDDataGridViewTextBoxColumn,
            this.numberNameDataGridViewTextBoxColumn,
            this.Street,
            this.Town,
            this.County,
            this.Country,
            this.Post_Code,
            this.Owned,
            this.Delete});
            this.PropertyGV.DataSource = this.propertyDetailsBindingSource;
            this.PropertyGV.Location = new System.Drawing.Point(34, 67);
            this.PropertyGV.Name = "PropertyGV";
            this.PropertyGV.ReadOnly = true;
            this.PropertyGV.Size = new System.Drawing.Size(944, 316);
            this.PropertyGV.TabIndex = 1;
            this.PropertyGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertyGV_CellContentClick);
            this.PropertyGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PropertyGV_CellMouseDoubleClick);
            // 
            // propertyIDDataGridViewTextBoxColumn
            // 
            this.propertyIDDataGridViewTextBoxColumn.DataPropertyName = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.HeaderText = "PropertyID";
            this.propertyIDDataGridViewTextBoxColumn.Name = "propertyIDDataGridViewTextBoxColumn";
            this.propertyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberNameDataGridViewTextBoxColumn
            // 
            this.numberNameDataGridViewTextBoxColumn.DataPropertyName = "Number_Name";
            this.numberNameDataGridViewTextBoxColumn.HeaderText = "Number_Name";
            this.numberNameDataGridViewTextBoxColumn.Name = "numberNameDataGridViewTextBoxColumn";
            this.numberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // Town
            // 
            this.Town.DataPropertyName = "Town";
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            this.Town.ReadOnly = true;
            // 
            // County
            // 
            this.County.DataPropertyName = "County";
            this.County.HeaderText = "County";
            this.County.Name = "County";
            this.County.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Post_Code
            // 
            this.Post_Code.DataPropertyName = "Post_Code";
            this.Post_Code.HeaderText = "Post_Code";
            this.Post_Code.Name = "Post_Code";
            this.Post_Code.ReadOnly = true;
            // 
            // Owned
            // 
            this.Owned.DataPropertyName = "Owned";
            this.Owned.HeaderText = "Owned";
            this.Owned.Name = "Owned";
            this.Owned.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // propertyDetailsBindingSource
            // 
            this.propertyDetailsBindingSource.DataMember = "Property_Details";
            this.propertyDetailsBindingSource.DataSource = this.propertyDataSet;
            // 
            // propertyDataSet
            // 
            this.propertyDataSet.DataSetName = "PropertyDataSet";
            this.propertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyDetails1BindingSource
            // 
            this.propertyDetails1BindingSource.DataMember = "Property_Details1";
            this.propertyDetails1BindingSource.DataSource = this.propertyDataSet1;
            // 
            // propertyDataSet1
            // 
            this.propertyDataSet1.DataSetName = "PropertyDataSet";
            this.propertyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyDataSetBindingSource
            // 
            this.propertyDataSetBindingSource.DataSource = this.propertyDataSet;
            this.propertyDataSetBindingSource.Position = 0;
            // 
            // property_DetailsTableAdapter
            // 
            this.property_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // PropertyAddBtn
            // 
            this.PropertyAddBtn.Location = new System.Drawing.Point(34, 389);
            this.PropertyAddBtn.Name = "PropertyAddBtn";
            this.PropertyAddBtn.Size = new System.Drawing.Size(98, 23);
            this.PropertyAddBtn.TabIndex = 2;
            this.PropertyAddBtn.Text = "Add Property";
            this.PropertyAddBtn.UseVisualStyleBackColor = true;
            this.PropertyAddBtn.Click += new System.EventHandler(this.PropertyAddBtn_Click);
            // 
            // StreetAddBtn
            // 
            this.StreetAddBtn.Location = new System.Drawing.Point(363, 429);
            this.StreetAddBtn.Name = "StreetAddBtn";
            this.StreetAddBtn.Size = new System.Drawing.Size(75, 23);
            this.StreetAddBtn.TabIndex = 3;
            this.StreetAddBtn.Text = "Add Street";
            this.StreetAddBtn.UseVisualStyleBackColor = true;
            this.StreetAddBtn.Click += new System.EventHandler(this.StreetAddBtn_Click);
            // 
            // propertyDetailsIDBindingSource
            // 
            this.propertyDetailsIDBindingSource.DataMember = "Property_Details_ID";
            this.propertyDetailsIDBindingSource.DataSource = this.propertyDataSetBindingSource;
            // 
            // property_Details_IDTableAdapter
            // 
            this.property_Details_IDTableAdapter.ClearBeforeFill = true;
            // 
            // property_Details1TableAdapter
            // 
            this.property_Details1TableAdapter.ClearBeforeFill = true;
            // 
            // Property_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 515);
            this.Controls.Add(this.StreetAddBtn);
            this.Controls.Add(this.PropertyAddBtn);
            this.Controls.Add(this.PropertyGV);
            this.Controls.Add(this.PropertyTtl);
            this.Name = "Property_Main";
            this.Text = "Property_Main";
            this.Load += new System.EventHandler(this.Property_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PropertyTtl;
        private System.Windows.Forms.DataGridView PropertyGV;
        private System.Windows.Forms.BindingSource propertyDataSetBindingSource;
        private Datasets.PropertyDataSet propertyDataSet;
        private System.Windows.Forms.BindingSource propertyDetailsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Property_DetailsTableAdapter property_DetailsTableAdapter;
        private System.Windows.Forms.Button PropertyAddBtn;
        private System.Windows.Forms.Button StreetAddBtn;
        private System.Windows.Forms.BindingSource propertyDetailsIDBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Property_Details_IDTableAdapter property_Details_IDTableAdapter;
        private Datasets.PropertyDataSet propertyDataSet1;
        private System.Windows.Forms.BindingSource propertyDetails1BindingSource;
        private Datasets.PropertyDataSetTableAdapters.Property_Details1TableAdapter property_Details1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_Code;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Owned;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}