
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebApplication3.App_Code.Reg
{
    public class RegDTO
    {
        private string userName, fullName,mobile, email, password;

        public RegDTO(string userName, string fullName, string mobile, string email, string password)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.mobile = mobile;
            this.email = email;
            this.password = password;
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}