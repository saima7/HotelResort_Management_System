
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebApplication3.App_Code.Reg
{
    public class RegDAO
    {
        //private string connectionString = "TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;"
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        //private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        // private DataSet dataSet = new DataSet();

        public RegDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public void RegUser(RegDTO RegDto)
        {
            string query = " insert into users(userName,fullName,mobile,email,password,usertype) values ('" + RegDto.UserName + "','"
                                                            + RegDto.FullName + "','"
                                                            + RegDto.Mobile + "','"
                                                            + RegDto.EMAIL + "','"
                                                            + RegDto.PassWord + "','u')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        /*    public Boolean ChkUser(RegDTO RegDto)
            {
                sqlConnection.Open();
                sqlCommand.CommandText = " select * from Users where userName = '" + RegDto.UserName + "'";
                sqlCommand.Connection = sqlConnection;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "Users");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Response.Redirect("home.aspx");
                    return true;
                }
                else
                {
                    return false;
                    // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
                }
            }
            */
    }
}