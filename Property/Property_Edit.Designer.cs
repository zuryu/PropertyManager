namespace PropertyList.Property
{
    partial class Property_Edit
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
            this.PropertyIDLbl = new System.Windows.Forms.Label();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.propertyDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet = new PropertyList.Datasets.PropertyDataSet();
            this.property_DetailsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Property_DetailsTableAdapter();
            this.PropertyUpdateBtn = new System.Windows.Forms.Button();
            this.PropertyIDDLbl = new System.Windows.Forms.Label();
            this.NumberDLbl = new System.Windows.Forms.Label();
            this.StreetDLbl = new System.Windows.Forms.Label();
            this.StreetDD = new System.Windows.Forms.ComboBox();
            this.propertyDetailsIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet1 = new PropertyList.Datasets.PropertyDataSet();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleDLbl = new System.Windows.Forms.Label();
            this.streetsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter();
            this.property_Details_IDTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Property_Details_IDTableAdapter();
            this.TownDLbl = new System.Windows.Forms.Label();
            this.TownDD = new System.Windows.Forms.ComboBox();
            this.townsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet2 = new PropertyList.Datasets.PropertyDataSet();
            this.townsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.TownsTableAdapter();
            this.CountyDLbl = new System.Windows.Forms.Label();
            this.CountyDD = new System.Windows.Forms.ComboBox();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countiesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.CountiesTableAdapter();
            this.CountryDLbl = new System.Windows.Forms.Label();
            this.CountryDD = new System.Windows.Forms.ComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.CountriesTableAdapter();
            this.PostCodeDD = new System.Windows.Forms.ComboBox();
            this.PostCodeDLbl = new System.Windows.Forms.Label();
            this.postCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.post_CodesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Post_CodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertyIDLbl
            // 
            this.PropertyIDLbl.AutoSize = true;
            this.PropertyIDLbl.Location = new System.Drawing.Point(95, 56);
            this.PropertyIDLbl.Name = "PropertyIDLbl";
            this.PropertyIDLbl.Size = new System.Drawing.Size(57, 13);
            this.PropertyIDLbl.TabIndex = 0;
            this.PropertyIDLbl.Text = "PropertyID";
            // 
            // NumberTB
            // 
            this.NumberTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyDetailsIDBindingSource, "Number_Name", true));
            this.NumberTB.Location = new System.Drawing.Point(98, 80);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(121, 20);
            this.NumberTB.TabIndex = 1;
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
            // property_DetailsTableAdapter
            // 
            this.property_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // PropertyUpdateBtn
            // 
            this.PropertyUpdateBtn.Location = new System.Drawing.Point(105, 267);
            this.PropertyUpdateBtn.Name = "PropertyUpdateBtn";
            this.PropertyUpdateBtn.Size = new System.Drawing.Size(114, 23);
            this.PropertyUpdateBtn.TabIndex = 2;
            this.PropertyUpdateBtn.Text = "Update Property";
            this.PropertyUpdateBtn.UseVisualStyleBackColor = true;
            this.PropertyUpdateBtn.Click += new System.EventHandler(this.PropertyUpdateBtn_Click);
            // 
            // PropertyIDDLbl
            // 
            this.PropertyIDDLbl.AutoSize = true;
            this.PropertyIDDLbl.Location = new System.Drawing.Point(12, 56);
            this.PropertyIDDLbl.Name = "PropertyIDDLbl";
            this.PropertyIDDLbl.Size = new System.Drawing.Size(63, 13);
            this.PropertyIDDLbl.TabIndex = 3;
            this.PropertyIDDLbl.Text = "Property ID:";
            // 
            // NumberDLbl
            // 
            this.NumberDLbl.AutoSize = true;
            this.NumberDLbl.Location = new System.Drawing.Point(12, 83);
            this.NumberDLbl.Name = "NumberDLbl";
            this.NumberDLbl.Size = new System.Drawing.Size(80, 13);
            this.NumberDLbl.TabIndex = 4;
            this.NumberDLbl.Text = "Number/Name:";
            // 
            // StreetDLbl
            // 
            this.StreetDLbl.AutoSize = true;
            this.StreetDLbl.Location = new System.Drawing.Point(12, 109);
            this.StreetDLbl.Name = "StreetDLbl";
            this.StreetDLbl.Size = new System.Drawing.Size(38, 13);
            this.StreetDLbl.TabIndex = 5;
            this.StreetDLbl.Text = "Street:";
            // 
            // StreetDD
            // 
            this.StreetDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StreetDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StreetDD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertyDetailsIDBindingSource, "StreetID", true));
            this.StreetDD.DataSource = this.streetsBindingSource;
            this.StreetDD.DisplayMember = "Street";
            this.StreetDD.FormattingEnabled = true;
            this.StreetDD.Location = new System.Drawing.Point(98, 107);
            this.StreetDD.Name = "StreetDD";
            this.StreetDD.Size = new System.Drawing.Size(121, 21);
            this.StreetDD.TabIndex = 6;
            this.StreetDD.ValueMember = "StreetID";
            // 
            // propertyDetailsIDBindingSource
            // 
            this.propertyDetailsIDBindingSource.DataMember = "Property_Details_ID";
            this.propertyDetailsIDBindingSource.DataSource = this.propertyDataSet1;
            // 
            // propertyDataSet1
            // 
            this.propertyDataSet1.DataSetName = "PropertyDataSet";
            this.propertyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.propertyDataSet1;
            // 
            // TitleDLbl
            // 
            this.TitleDLbl.AutoSize = true;
            this.TitleDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDLbl.Location = new System.Drawing.Point(9, 9);
            this.TitleDLbl.Name = "TitleDLbl";
            this.TitleDLbl.Size = new System.Drawing.Size(171, 31);
            this.TitleDLbl.TabIndex = 7;
            this.TitleDLbl.Text = "Edit Property";
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // property_Details_IDTableAdapter
            // 
            this.property_Details_IDTableAdapter.ClearBeforeFill = true;
            // 
            // TownDLbl
            // 
            this.TownDLbl.AutoSize = true;
            this.TownDLbl.Location = new System.Drawing.Point(12, 141);
            this.TownDLbl.Name = "TownDLbl";
            this.TownDLbl.Size = new System.Drawing.Size(37, 13);
            this.TownDLbl.TabIndex = 8;
            this.TownDLbl.Text = "Town:";
            // 
            // TownDD
            // 
            this.TownDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TownDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TownDD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertyDetailsIDBindingSource, "TownID", true));
            this.TownDD.DataSource = this.townsBindingSource;
            this.TownDD.DisplayMember = "Town";
            this.TownDD.FormattingEnabled = true;
            this.TownDD.Location = new System.Drawing.Point(98, 138);
            this.TownDD.Name = "TownDD";
            this.TownDD.Size = new System.Drawing.Size(121, 21);
            this.TownDD.TabIndex = 9;
            this.TownDD.ValueMember = "TownID";
            // 
            // townsBindingSource
            // 
            this.townsBindingSource.DataMember = "Towns";
            this.townsBindingSource.DataSource = this.propertyDataSet2;
            // 
            // propertyDataSet2
            // 
            this.propertyDataSet2.DataSetName = "PropertyDataSet";
            this.propertyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // townsTableAdapter
            // 
            this.townsTableAdapter.ClearBeforeFill = true;
            // 
            // CountyDLbl
            // 
            this.CountyDLbl.AutoSize = true;
            this.CountyDLbl.Location = new System.Drawing.Point(12, 170);
            this.CountyDLbl.Name = "CountyDLbl";
            this.CountyDLbl.Size = new System.Drawing.Size(43, 13);
            this.CountyDLbl.TabIndex = 10;
            this.CountyDLbl.Text = "County:";
            // 
            // CountyDD
            // 
            this.CountyDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CountyDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CountyDD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertyDetailsIDBindingSource, "CountyID", true));
            this.CountyDD.DataSource = this.countiesBindingSource;
            this.CountyDD.DisplayMember = "County";
            this.CountyDD.FormattingEnabled = true;
            this.CountyDD.Location = new System.Drawing.Point(98, 167);
            this.CountyDD.Name = "CountyDD";
            this.CountyDD.Size = new System.Drawing.Size(121, 21);
            this.CountyDD.TabIndex = 11;
            this.CountyDD.ValueMember = "CountyID";
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.propertyDataSet;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // CountryDLbl
            // 
            this.CountryDLbl.AutoSize = true;
            this.CountryDLbl.Location = new System.Drawing.Point(12, 200);
            this.CountryDLbl.Name = "CountryDLbl";
            this.CountryDLbl.Size = new System.Drawing.Size(46, 13);
            this.CountryDLbl.TabIndex = 12;
            this.CountryDLbl.Text = "Country:";
            // 
            // CountryDD
            // 
            this.CountryDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CountryDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CountryDD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertyDetailsIDBindingSource, "CountryID", true));
            this.CountryDD.DataSource = this.countriesBindingSource;
            this.CountryDD.DisplayMember = "Country";
            this.CountryDD.FormattingEnabled = true;
            this.CountryDD.Location = new System.Drawing.Point(98, 197);
            this.CountryDD.Name = "CountryDD";
            this.CountryDD.Size = new System.Drawing.Size(121, 21);
            this.CountryDD.TabIndex = 13;
            this.CountryDD.ValueMember = "CountryID";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.propertyDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // PostCodeDD
            // 
            this.PostCodeDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PostCodeDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PostCodeDD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.propertyDetailsIDBindingSource, "PostCodeID", true));
            this.PostCodeDD.DataSource = this.postCodesBindingSource;
            this.PostCodeDD.DisplayMember = "Post_Code";
            this.PostCodeDD.FormattingEnabled = true;
            this.PostCodeDD.Location = new System.Drawing.Point(98, 225);
            this.PostCodeDD.Name = "PostCodeDD";
            this.PostCodeDD.Size = new System.Drawing.Size(121, 21);
            this.PostCodeDD.TabIndex = 14;
            this.PostCodeDD.ValueMember = "PostCodeID";
            // 
            // PostCodeDLbl
            // 
            this.PostCodeDLbl.AutoSize = true;
            this.PostCodeDLbl.Location = new System.Drawing.Point(12, 228);
            this.PostCodeDLbl.Name = "PostCodeDLbl";
            this.PostCodeDLbl.Size = new System.Drawing.Size(59, 13);
            this.PostCodeDLbl.TabIndex = 15;
            this.PostCodeDLbl.Text = "Post Code:";
            // 
            // postCodesBindingSource
            // 
            this.postCodesBindingSource.DataMember = "Post_Codes";
            this.postCodesBindingSource.DataSource = this.propertyDataSet;
            // 
            // post_CodesTableAdapter
            // 
            this.post_CodesTableAdapter.ClearBeforeFill = true;
            // 
            // Property_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 311);
            this.Controls.Add(this.PostCodeDLbl);
            this.Controls.Add(this.PostCodeDD);
            this.Controls.Add(this.CountryDD);
            this.Controls.Add(this.CountryDLbl);
            this.Controls.Add(this.CountyDD);
            this.Controls.Add(this.CountyDLbl);
            this.Controls.Add(this.TownDD);
            this.Controls.Add(this.TownDLbl);
            this.Controls.Add(this.TitleDLbl);
            this.Controls.Add(this.StreetDD);
            this.Controls.Add(this.StreetDLbl);
            this.Controls.Add(this.NumberDLbl);
            this.Controls.Add(this.PropertyIDDLbl);
            this.Controls.Add(this.PropertyUpdateBtn);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.PropertyIDLbl);
            this.Name = "Property_Edit";
            this.Text = "Edit Property";
            this.Load += new System.EventHandler(this.Property_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDetailsIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PropertyIDLbl;
        private System.Windows.Forms.TextBox NumberTB;
        private Datasets.PropertyDataSet propertyDataSet;
        private System.Windows.Forms.BindingSource propertyDetailsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Property_DetailsTableAdapter property_DetailsTableAdapter;
        private System.Windows.Forms.Button PropertyUpdateBtn;
        private System.Windows.Forms.Label PropertyIDDLbl;
        private System.Windows.Forms.Label NumberDLbl;
        private System.Windows.Forms.Label StreetDLbl;
        private System.Windows.Forms.ComboBox StreetDD;
        private System.Windows.Forms.Label TitleDLbl;
        private Datasets.PropertyDataSet propertyDataSet1;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.BindingSource propertyDetailsIDBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Property_Details_IDTableAdapter property_Details_IDTableAdapter;
        private System.Windows.Forms.Label TownDLbl;
        private System.Windows.Forms.ComboBox TownDD;
        private Datasets.PropertyDataSet propertyDataSet2;
        private System.Windows.Forms.BindingSource townsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.TownsTableAdapter townsTableAdapter;
        private System.Windows.Forms.Label CountyDLbl;
        private System.Windows.Forms.ComboBox CountyDD;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.Label CountryDLbl;
        private System.Windows.Forms.ComboBox CountryDD;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.ComboBox PostCodeDD;
        private System.Windows.Forms.Label PostCodeDLbl;
        private System.Windows.Forms.BindingSource postCodesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Post_CodesTableAdapter post_CodesTableAdapter;
    }
}