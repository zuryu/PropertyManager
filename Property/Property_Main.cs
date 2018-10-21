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
    public partial class Property_Main : Form
    {
        public Property_Main()
        {
            InitializeComponent();
        }

        private void Property_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDataSet1.Property_Details1' table. You can move, or remove it, as needed.
            this.property_Details1TableAdapter.Fill(this.propertyDataSet1.Property_Details1);
            // TODO: This line of code loads data into the 'propertyDataSet.Property_Details' table. You can move, or remove it, as needed.
            this.property_DetailsTableAdapter.Fill(this.propertyDataSet.Property_Details);

        }

        private void PropertyGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int propertyID = Convert.ToInt32(PropertyGV.Rows[e.RowIndex].Cells[0].Value);
            Property_Edit editForm = new Property_Edit();
            Control idLbl = editForm.Controls.Find("PropertyIDLbl", true)[0];
            idLbl.Text = propertyID.ToString();
            editForm.Show();
        }

        private void PropertyAddBtn_Click(object sender, EventArgs e)
        {
            new Property_Add().Show();
        }

        private void PropertyGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridView grid = (DataGridView)sender;
            if (grid.CurrentCell.ColumnIndex == 8){
                string connectionString = ConfigurationManager.ConnectionStrings["PropertyCS"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand propertyDCom = new SqlCommand("DELETE FROM Property_Details WHERE PropertyID = @PropertyID", connection);
                propertyDCom.CommandType = CommandType.Text;
           
                propertyDCom.Parameters.AddWithValue("@PropertyID", grid.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    connection.Open();
                    propertyDCom.ExecuteNonQuery();
                    connection.Close();
                } catch (Exception ex)
                {

                }

            }
        }

        private void StreetAddBtn_Click(object sender, EventArgs e)
        {
            new Streets().Show();
        }
    }
}
