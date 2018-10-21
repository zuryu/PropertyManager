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
    public partial class Property_Add : Form
    {
        public Property_Add()
        {
            InitializeComponent();
        }

        private void PropertyAddBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand propertyACom = new SqlCommand("INSERT INTO Property_Details (Number_Name, StreetID, TownID, CountyID, CountryID, PostCodeID) VALUES (@Number_Name, @StreetID, @TownID, @CountyID, @CountryID, @PostCodeID)", connection)
            {
                CommandType = CommandType.Text
            };

            propertyACom.Parameters.AddWithValue("@Number_Name", NumberTB.Text);
            propertyACom.Parameters.AddWithValue("@StreetID", StreetDD.SelectedValue);
            propertyACom.Parameters.AddWithValue("@TownID", TownDD.SelectedValue);
            propertyACom.Parameters.AddWithValue("@CountyID", CountyDD.SelectedValue);
            propertyACom.Parameters.AddWithValue("@CountryID", CountryDD.SelectedValue);
            propertyACom.Parameters.AddWithValue("@PostCodeID", PostCodeDD.SelectedValue);

            try
            {
                connection.Open();
                propertyACom.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            this.Close();
        }

        private void Property_Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDataSet.Post_Codes' table. You can move, or remove it, as needed.
            this.post_CodesTableAdapter.Fill(this.propertyDataSet.Post_Codes);
            // TODO: This line of code loads data into the 'propertyDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.propertyDataSet.Countries);
            // TODO: This line of code loads data into the 'propertyDataSet.Counties' table. You can move, or remove it, as needed.
            this.countiesTableAdapter.Fill(this.propertyDataSet.Counties);
            // TODO: This line of code loads data into the 'propertyDataSet.Towns' table. You can move, or remove it, as needed.
            this.townsTableAdapter.Fill(this.propertyDataSet.Towns);
            // TODO: This line of code loads data into the 'propertyDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.propertyDataSet.Streets);

        }
    }
}
