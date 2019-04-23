using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.AdminLogin;

namespace SystemManagement
{
    public partial class Login : Form
    {
       
            AdminLogDAO AdminLogDao = new AdminLogDAO();

        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
        }
        public static class ControlID
        {
            public static string TextData { get; set; }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string adminID = textBox1.Text;

            string adminPassword = textBox2.Text;

            // Session["passuser"] = usernametxt.Text;

            // LogDao.LogUser(new LogDTO(userName,  password));
            /* cmd.CommandText = "select * from Users where userName='"+ usernametxt.Text + "' and password='" + passwordtxt.Text + "'";
             cmd.Connection = con;
             sda.SelectCommand = cmd;
             sda.Fill(ds, "Users");
             if(ds.Tables[0].Rows.Count > 0)
             {
                 Response.Redirect("home.aspx");
             }
             else
             {
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
             } */
            if (AdminLogDao.LogAdmin(new AdminLogDTO(adminID, adminPassword)) == true)
            {
                MessageBox.Show("Successfull");
                //textBox1.Text = "";
                //textBox2.Text = "";


                this.Hide();
                ControlID.TextData = textBox1.Text;
           /*     using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
                */
                //  Form_Dashboard lg = new adminMenu();
                Forms.Form_Dashboard lg = new Forms.Form_Dashboard();
              
                lg.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Error!");
                // textBox1.Text = "";
                //  textBox2.Text = "";
                this.Hide();
                Login lg = new Login();
                //  page2 lg = new page2();
                lg.ShowDialog();
                this.Close();
            }

        }
    }
    }

