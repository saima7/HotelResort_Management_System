using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication3
{
    public partial class HallBook : System.Web.UI.Page
    { 
                SqlConnection sqlConnection = new SqlConnection();
               // SqlCommand sqlCommand = new SqlCommand();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(" select * from event ");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sqlConnection;
            string temp = "";
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                temp += reader["HallName"].ToString();
                temp += reader["Purpose"].ToString();
                temp += reader["Capacity"].ToString();
                temp += reader["Description"].ToString();
                temp +="<br/>";

            }
            lbl_test.Text = temp;
        }

    }
}