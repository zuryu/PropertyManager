namespace PropertyList.Property
{
    partial class Streets
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
            this.AddStreetTB = new System.Windows.Forms.TextBox();
            this.StreetTitleLbl = new System.Windows.Forms.Label();
            this.StreetAddLbl = new System.Windows.Forms.Label();
            this.AddStreetBtn = new System.Windows.Forms.Button();
            this.EditStreetBtn = new System.Windows.Forms.Button();
            this.EditStreetDLbl = new System.Windows.Forms.Label();
            this.EditStreetDD = new System.Windows.Forms.ComboBox();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyDataSet = new PropertyList.Datasets.PropertyDataSet();
            this.streetsTableAdapter = new PropertyList.Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter();
            this.DeleteStreetBtn = new System.Windows.Forms.Button();
            this.EditStreetTB = new System.Windows.Forms.TextBox();
            this.DeleteStreetDD = new System.Windows.Forms.ComboBox();
            this.DeleteStreetDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStreetTB
            // 
            this.AddStreetTB.Location = new System.Drawing.Point(59, 51);
            this.AddStreetTB.Name = "AddStreetTB";
            this.AddStreetTB.Size = new System.Drawing.Size(100, 20);
            this.AddStreetTB.TabIndex = 0;
            // 
            // StreetTitleLbl
            // 
            this.StreetTitleLbl.AutoSize = true;
            this.StreetTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.StreetTitleLbl.Name = "StreetTitleLbl";
            this.StreetTitleLbl.Size = new System.Drawing.Size(101, 31);
            this.StreetTitleLbl.TabIndex = 1;
            this.StreetTitleLbl.Text = "Streets";
            // 
            // StreetAddLbl
            // 
            this.StreetAddLbl.AutoSize = true;
            this.StreetAddLbl.Location = new System.Drawing.Point(15, 54);
            this.StreetAddLbl.Name = "StreetAddLbl";
            this.StreetAddLbl.Size = new System.Drawing.Size(38, 13);
            this.StreetAddLbl.TabIndex = 2;
            this.StreetAddLbl.Text = "Street:";
            // 
            // AddStreetBtn
            // 
            this.AddStreetBtn.Location = new System.Drawing.Point(84, 77);
            this.AddStreetBtn.Name = "AddStreetBtn";
            this.AddStreetBtn.Size = new System.Drawing.Size(75, 23);
            this.AddStreetBtn.TabIndex = 3;
            this.AddStreetBtn.Text = "Add Street";
            this.AddStreetBtn.UseVisualStyleBackColor = true;
            this.AddStreetBtn.Click += new System.EventHandler(this.AddStreetBtn_Click);
            // 
            // EditStreetBtn
            // 
            this.EditStreetBtn.Location = new System.Drawing.Point(305, 103);
            this.EditStreetBtn.Name = "EditStreetBtn";
            this.EditStreetBtn.Size = new System.Drawing.Size(87, 23);
            this.EditStreetBtn.TabIndex = 4;
            this.EditStreetBtn.Text = "Update Street";
            this.EditStreetBtn.UseVisualStyleBackColor = true;
            this.EditStreetBtn.Click += new System.EventHandler(this.EditStreetBtn_Click);
            // 
            // EditStreetDLbl
            // 
            this.EditStreetDLbl.AutoSize = true;
            this.EditStreetDLbl.Location = new System.Drawing.Point(208, 54);
            this.EditStreetDLbl.Name = "EditStreetDLbl";
            this.EditStreetDLbl.Size = new System.Drawing.Size(57, 13);
            this.EditStreetDLbl.TabIndex = 5;
            this.EditStreetDLbl.Text = "Old Street:";
            // 
            // EditStreetDD
            // 
            this.EditStreetDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EditStreetDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditStreetDD.DataSource = this.streetsBindingSource;
            this.EditStreetDD.DisplayMember = "Street";
            this.EditStreetDD.FormattingEnabled = true;
            this.EditStreetDD.Location = new System.Drawing.Point(271, 51);
            this.EditStreetDD.Name = "EditStreetDD";
            this.EditStreetDD.Size = new System.Drawing.Size(121, 21);
            this.EditStreetDD.TabIndex = 6;
            this.EditStreetDD.ValueMember = "StreetID";
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.propertyDataSet;
            // 
            // propertyDataSet
            // 
            this.propertyDataSet.DataSetName = "PropertyDataSet";
            this.propertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteStreetBtn
            // 
            this.DeleteStreetBtn.Location = new System.Drawing.Point(543, 77);
            this.DeleteStreetBtn.Name = "DeleteStreetBtn";
            this.DeleteStreetBtn.Size = new System.Drawing.Size(87, 23);
            this.DeleteStreetBtn.TabIndex = 7;
            this.DeleteStreetBtn.Text = "Delete Street";
            this.DeleteStreetBtn.UseVisualStyleBackColor = true;
            this.DeleteStreetBtn.Click += new System.EventHandler(this.DeleteStreetBtn_Click);
            // 
            // EditStreetTB
            // 
            this.EditStreetTB.Location = new System.Drawing.Point(292, 77);
            this.EditStreetTB.Name = "EditStreetTB";
            this.EditStreetTB.Size = new System.Drawing.Size(100, 20);
            this.EditStreetTB.TabIndex = 8;
            // 
            // DeleteStreetDD
            // 
            this.DeleteStreetDD.DataSource = this.streetsBindingSource;
            this.DeleteStreetDD.DisplayMember = "Street";
            this.DeleteStreetDD.FormattingEnabled = true;
            this.DeleteStreetDD.Location = new System.Drawing.Point(509, 51);
            this.DeleteStreetDD.Name = "DeleteStreetDD";
            this.DeleteStreetDD.Size = new System.Drawing.Size(121, 21);
            this.DeleteStreetDD.TabIndex = 9;
            this.DeleteStreetDD.ValueMember = "StreetID";
            // 
            // DeleteStreetDLbl
            // 
            this.DeleteStreetDLbl.AutoSize = true;
            this.DeleteStreetDLbl.Location = new System.Drawing.Point(465, 54);
            this.DeleteStreetDLbl.Name = "DeleteStreetDLbl";
            this.DeleteStreetDLbl.Size = new System.Drawing.Size(38, 13);
            this.DeleteStreetDLbl.TabIndex = 10;
            this.DeleteStreetDLbl.Text = "Street:";
            // 
            // Streets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 259);
            this.Controls.Add(this.DeleteStreetDLbl);
            this.Controls.Add(this.DeleteStreetDD);
            this.Controls.Add(this.EditStreetTB);
            this.Controls.Add(this.DeleteStreetBtn);
            this.Controls.Add(this.EditStreetDD);
            this.Controls.Add(this.EditStreetDLbl);
            this.Controls.Add(this.EditStreetBtn);
            this.Controls.Add(this.AddStreetBtn);
            this.Controls.Add(this.StreetAddLbl);
            this.Controls.Add(this.StreetTitleLbl);
            this.Controls.Add(this.AddStreetTB);
            this.Name = "Streets";
            this.Text = "Streets";
            this.Load += new System.EventHandler(this.Streets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddStreetTB;
        private System.Windows.Forms.Label StreetTitleLbl;
        private System.Windows.Forms.Label StreetAddLbl;
        private System.Windows.Forms.Button AddStreetBtn;
        private System.Windows.Forms.Button EditStreetBtn;
        private System.Windows.Forms.Label EditStreetDLbl;
        private System.Windows.Forms.ComboBox EditStreetDD;
        private Datasets.PropertyDataSet propertyDataSet;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private Datasets.PropertyDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.Button DeleteStreetBtn;
        private System.Windows.Forms.TextBox EditStreetTB;
        private System.Windows.Forms.ComboBox DeleteStreetDD;
        private System.Windows.Forms.Label DeleteStreetDLbl;
    }
}