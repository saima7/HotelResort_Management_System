using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3.App_Code.Order
{
    public class OrderDAO
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public OrderDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void AddOrder(OrderDTO OrderDto)
        {

            string query = " insert into Room_Booking( Ordered_by, Room_No ,  Date , Time , PinCode, TrxID) values ('" + OrderDto.Ordered_By + "','"
                                                            + OrderDto.Room_NO + "','"
                                                            + OrderDto.DaTe + "','"
                                                            + OrderDto.TiMe + "','"
                                                            + OrderDto.PinCode + "','"
                                                            + OrderDto.TRXID + "')";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


        }
    }
}