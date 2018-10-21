using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PropertyList.Property
{
    public partial class Property_Edit : Form
    {
        public Property_Edit()
        {
            InitializeComponent();
        }

        private void Property_Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDataSet.Post_Codes' table. You can move, or remove it, as needed.
            this.post_CodesTableAdapter.Fill(this.propertyDataSet.Post_Codes);
            // TODO: This line of code loads data into the 'propertyDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.propertyDataSet.Countries);
            // TODO: This line of code loads data into the 'propertyDataSet.Counties' table. You can move, or remove it, as needed.
            this.countiesTableAdapter.Fill(this.propertyDataSet.Counties);
            // TODO: This line of code loads data into the 'propertyDataSet2.Towns' table. You can move, or remove it, as needed.
            this.townsTableAdapter.Fill(this.propertyDataSet2.Towns);
            // TODO: This line of code loads data into the 'propertyDataSet1.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.propertyDataSet1.Streets);
            // TODO: This line of code loads data into the 'propertyDataSet.Property_Details' table. You can move, or remove it, as needed.
            this.property_DetailsTableAdapter.Fill(this.propertyDataSet.Property_Details);
            property_Details_IDTableAdapter.Fill(propertyDataSet1.Property_Details_ID, Convert.ToInt32(PropertyIDLbl.Text));
        }

        private void PropertyUpdateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand propertyUCom = new SqlCommand("UPDATE Property_Details SET Number_Name = @Number_Name, StreetID = @StreetID, TownID = @TownID, CountyID = @CountyID, CountryID = @CountryID, PostCodeID = @PostCodeID WHERE PropertyID = @PropertyID", connection)
            {
                CommandType = CommandType.Text
            };
            propertyUCom.Parameters.AddWithValue("@Number_Name", NumberTB.Text);
            propertyUCom.Parameters.AddWithValue("@PropertyID", PropertyIDLbl.Text);
            propertyUCom.Parameters.AddWithValue("@StreetID", StreetDD.SelectedValue);
            propertyUCom.Parameters.AddWithValue("@TownID", TownDD.SelectedValue);
            propertyUCom.Parameters.AddWithValue("@CountyID", CountyDD.SelectedValue);
            propertyUCom.Parameters.AddWithValue("@CountryID", CountryDD.SelectedValue);
            propertyUCom.Parameters.AddWithValue("@PostCodeID", PostCodeDD.SelectedValue);

            try
            {
                connection.Open();
                propertyUCom.ExecuteNonQuery();
                connection.Close();
            } catch (Exception ex)
            {

            }

            this.Close();
        }
    }
}
