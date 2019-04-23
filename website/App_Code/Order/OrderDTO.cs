using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.App_Code.Order
{
    public class OrderDTO
    {
        private string Ordered_by, Room_No, Time, Date, pincode, TrxID;
        int Quantity, Total_Price;

        public OrderDTO(string Ordered_by, string Room_No,  string Date, string Time, string pincode, string TrxID)
        {
            this.Ordered_by = Ordered_by;
            this.Room_No = Room_No;
            this.pincode = pincode;

       
            this.Date = Date;
            this.Time = Time;
            this.TrxID = TrxID;
        }

        public string Ordered_By
        {
            get { return Ordered_by; }
            set { Ordered_by = value; }
        }

        public string Room_NO        {
            get { return Room_No; }
            set { Room_No = value; }
        }


        public int Total_price
        {
            get { return Total_Price; }
            set { Total_Price = value; }
        }
        public string DaTe
        {
            get { return Date; }
            set { Date = value; }
        }
        public string TiMe
        {
            get { return Time; }
            set { Time = value; }
        }
        public string PinCode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string TRXID
        {
            get { return TrxID; }
            set { TrxID = value; }
        }
    }
}