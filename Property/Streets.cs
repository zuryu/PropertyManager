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
    public partial class Streets : Form
    {
        public Streets()
        {
            InitializeComponent();
        }

        private void Streets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.propertyDataSet.Streets);

        }

        private void AddStreetBtn_Click(object sender, EventArgs e)
        {
            string connnectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connnectionString);

            SqlCommand streetACom = new SqlCommand("INSERT INTO Streets (Street) VALUES (@Street)", connection)
            {
                CommandType = CommandType.Text
            };

            streetACom.Parameters.AddWithValue("@Street", AddStreetTB.Text);

            try
            {
                connection.Open();
                streetACom.ExecuteNonQuery();
                connection.Close();
            } catch (Exception ex)
            {

            }
        }

        private void EditStreetBtn_Click(object sender, EventArgs e)
        {
            string connnectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connnectionString);

            SqlCommand streetUCom = new SqlCommand("UPDATE Streets SET Street = @Street WHERE StreetID = @StreetID", connection)
            {
                CommandType = CommandType.Text
            };

            streetUCom.Parameters.AddWithValue("@Street", EditStreetTB.Text);
            streetUCom.Parameters.AddWithValue("@StreetID", EditStreetDD.SelectedValue);

            try
            {
                connection.Open();
                streetUCom.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteStreetBtn_Click(object sender, EventArgs e)
        {
            string connnectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connnectionString);

            SqlCommand streetDCom = new SqlCommand("DELETE FROM Streets WHERE StreetID = @StreetID", connection);
            streetDCom.CommandType = CommandType.Text;

            streetDCom.Parameters.AddWithValue("@StreetID", DeleteStreetDD.SelectedValue);

            try
            {
                connection.Open();
                streetDCom.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            streetsBindingSource.ResetBindings(false);
        }
    }
}
