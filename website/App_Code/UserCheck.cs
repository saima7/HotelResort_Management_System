﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication3.App_Code
{
    public class UserCheck
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();



        public UserCheck()
        {
            sqlConnection = new SqlConnection(connectionString);
        }





        public Boolean ChkUser(String user)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = " select * from users where userName = '" + user + "'";
            sqlCommand.Connection = sqlConnection;
            //    //string query = " select * from Users where userName = '" + LogDto.UserName + "' and password = '" + LogDto.PassWord + "'" ;
            // string query = " select * from Users where userName = 'sakif' and password =  '123' ";
            // sqlCommand = new SqlCommand(query, sqlConnection);
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

    }
}