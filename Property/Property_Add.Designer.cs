namespace PropertyList.Property
{
    partial class Property_Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.PropertyAddBtn = new System.Windows.Forms.Button();
            this.NumberDLbl = new System.Windows.Forms.Label();
            this.CountryDLbl = new System.Windows.Forms.Label();
            this.PostCodeDLbl = new System.Windows.Forms.Label();
            this.CountyDLbl = new System.Windows.Forms.Label();
            this.TownDLbl = new System.Windows.Forms.Label();
            this.StreetDLbl = new System.Windows.Forms.Label();
            this.PostCodeDD = new System.Windows.Forms.ComboBox();
            this.CountryDD = new System.Windows.Forms.ComboBox();
            this.CountyDD = new System.Windows.Forms.ComboBox();
            this.TownDD = new System.Windows.Forms.ComboBox();
            this.StreetDD = new System.Windows.Forms.ComboBox();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.propertyDataSet = new PropertyList.Datasets.PropertyDataSet();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter();
            this.townsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.townsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.TownsTableAdapter();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countiesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.CountiesTableAdapter();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.CountriesTableAdapter();
            this.postCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.post_CodesTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.Post_CodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Property";
            // 
            // PropertyAddBtn
            // 
            this.PropertyAddBtn.Location = new System.Drawing.Point(107, 235);
            this.PropertyAddBtn.Name = "PropertyAddBtn";
            this.PropertyAddBtn.Size = new System.Drawing.Size(98, 23);
            this.PropertyAddBtn.TabIndex = 1;
            this.PropertyAddBtn.Text = "Add Property";
            this.PropertyAddBtn.UseVisualStyleBackColor = true;
            this.PropertyAddBtn.Click += new System.EventHandler(this.PropertyAddBtn_Click);
            // 
            // NumberDLbl
            // 
            this.NumberDLbl.AutoSize = true;
            this.NumberDLbl.Location = new System.Drawing.Point(19, 52);
            this.NumberDLbl.Name = "NumberDLbl";
            this.NumberDLbl.Size = new System.Drawing.Size(47, 13);
            this.NumberDLbl.TabIndex = 2;
            this.NumberDLbl.Text = "Number:";
            // 
            // CountryDLbl
            // 
            this.CountryDLbl.AutoSize = true;
            this.CountryDLbl.Location = new System.Drawing.Point(19, 163);
            this.CountryDLbl.Name = "CountryDLbl";
            this.CountryDLbl.Size = new System.Drawing.Size(46, 13);
            this.CountryDLbl.TabIndex = 3;
            this.CountryDLbl.Text = "Country:";
            // 
            // PostCodeDLbl
            // 
            this.PostCodeDLbl.AutoSize = true;
            this.PostCodeDLbl.Location = new System.Drawing.Point(19, 194);
            this.PostCodeDLbl.Name = "PostCodeDLbl";
            this.PostCodeDLbl.Size = new System.Drawing.Size(59, 13);
            this.PostCodeDLbl.TabIndex = 4;
            this.PostCodeDLbl.Text = "Post Code:";
            // 
            // CountyDLbl
            // 
            this.CountyDLbl.AutoSize = true;
            this.CountyDLbl.Location = new System.Drawing.Point(19, 136);
            this.CountyDLbl.Name = "CountyDLbl";
            this.CountyDLbl.Size = new System.Drawing.Size(43, 13);
            this.CountyDLbl.TabIndex = 5;
            this.CountyDLbl.Text = "County:";
            // 
            // TownDLbl
            // 
            this.TownDLbl.AutoSize = true;
            this.TownDLbl.Location = new System.Drawing.Point(19, 108);
            this.TownDLbl.Name = "TownDLbl";
            this.TownDLbl.Size = new System.Drawing.Size(37, 13);
            this.TownDLbl.TabIndex = 6;
            this.TownDLbl.Text = "Town:";
            // 
            // StreetDLbl
            // 
            this.StreetDLbl.AutoSize = true;
            this.StreetDLbl.Location = new System.Drawing.Point(19, 78);
            this.StreetDLbl.Name = "StreetDLbl";
            this.StreetDLbl.Size = new System.Drawing.Size(38, 13);
            this.StreetDLbl.TabIndex = 7;
            this.StreetDLbl.Text = "Street:";
            // 
            // PostCodeDD
            // 
            this.PostCodeDD.DataSource = this.postCodesBindingSource;
            this.PostCodeDD.DisplayMember = "Post_Code";
            this.PostCodeDD.FormattingEnabled = true;
            this.PostCodeDD.Location = new System.Drawing.Point(84, 191);
            this.PostCodeDD.Name = "PostCodeDD";
            this.PostCodeDD.Size = new System.Drawing.Size(121, 21);
            this.PostCodeDD.TabIndex = 8;
            this.PostCodeDD.ValueMember = "PostCodeID";
            // 
            // CountryDD
            // 
            this.CountryDD.DataSource = this.countriesBindingSource;
            this.CountryDD.DisplayMember = "Country";
            this.CountryDD.FormattingEnabled = true;
            this.CountryDD.Location = new System.Drawing.Point(84, 160);
            this.CountryDD.Name = "CountryDD";
            this.CountryDD.Size = new System.Drawing.Size(121, 21);
            this.CountryDD.TabIndex = 9;
            this.CountryDD.ValueMember = "CountryID";
            // 
            // CountyDD
            // 
            this.CountyDD.DataSource = this.countiesBindingSource;
            this.CountyDD.DisplayMember = "County";
            this.CountyDD.FormattingEnabled = true;
            this.CountyDD.Location = new System.Drawing.Point(84, 133);
            this.CountyDD.Name = "CountyDD";
            this.CountyDD.Size = new System.Drawing.Size(121, 21);
            this.CountyDD.TabIndex = 10;
            this.CountyDD.ValueMember = "CountyID";
            // 
            // TownDD
            // 
            this.TownDD.DataSource = this.townsBindingSource;
            this.TownDD.DisplayMember = "Town";
            this.TownDD.FormattingEnabled = true;
            this.TownDD.Location = new System.Drawing.Point(84, 105);
            this.TownDD.Name = "TownDD";
            this.TownDD.Size = new System.Drawing.Size(121, 21);
            this.TownDD.TabIndex = 11;
            this.TownDD.ValueMember = "TownID";
            // 
            // StreetDD
            // 
            this.StreetDD.DataSource = this.streetsBindingSource;
            this.StreetDD.DisplayMember = "Street";
            this.StreetDD.FormattingEnabled = true;
            this.StreetDD.Location = new System.Drawing.Point(84, 75);
            this.StreetDD.Name = "StreetDD";
            this.StreetDD.Size = new System.Drawing.Size(121, 21);
            this.StreetDD.TabIndex = 12;
            this.StreetDD.ValueMember = "StreetID";
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(85, 49);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(120, 20);
            this.NumberTB.TabIndex = 13;
            // 
            // propertyDataSet
            // 
            this.propertyDataSet.DataSetName = "PropertyDataSet";
            this.propertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.propertyDataSet;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // townsBindingSource
            // 
            this.townsBindingSource.DataMember = "Towns";
            this.townsBindingSource.DataSource = this.propertyDataSet;
            // 
            // townsTableAdapter
            // 
            this.townsTableAdapter.ClearBeforeFill = true;
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
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.propertyDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
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
            // Property_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 273);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.StreetDD);
            this.Controls.Add(this.TownDD);
            this.Controls.Add(this.CountyDD);
            this.Controls.Add(this.CountryDD);
            this.Controls.Add(this.PostCodeDD);
            this.Controls.Add(this.StreetDLbl);
            this.Controls.Add(this.TownDLbl);
            this.Controls.Add(this.CountyDLbl);
            this.Controls.Add(this.PostCodeDLbl);
            this.Controls.Add(this.CountryDLbl);
            this.Controls.Add(this.NumberDLbl);
            this.Controls.Add(this.PropertyAddBtn);
            this.Controls.Add(this.label1);
            this.Name = "Property_Add";
            this.Text = "Add Property";
            this.Load += new System.EventHandler(this.Property_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postCodesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PropertyAddBtn;
        private System.Windows.Forms.Label NumberDLbl;
        private System.Windows.Forms.Label CountryDLbl;
        private System.Windows.Forms.Label PostCodeDLbl;
        private System.Windows.Forms.Label CountyDLbl;
        private System.Windows.Forms.Label TownDLbl;
        private System.Windows.Forms.Label StreetDLbl;
        private System.Windows.Forms.ComboBox PostCodeDD;
        private System.Windows.Forms.ComboBox CountryDD;
        private System.Windows.Forms.ComboBox CountyDD;
        private System.Windows.Forms.ComboBox TownDD;
        private System.Windows.Forms.ComboBox StreetDD;
        private System.Windows.Forms.TextBox NumberTB;
        private Datasets.PropertyDataSet propertyDataSet;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.BindingSource townsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.TownsTableAdapter townsTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource postCodesBindingSource;
        private Datasets.PropertyDataSetTableAdapters.Post_CodesTableAdapter post_CodesTableAdapter;
    }
}