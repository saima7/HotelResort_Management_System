using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemManagement
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;");
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        string a = "1";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "INSERT INTO ROrder (room_ID,user_name,price,checkin,checkout,status,Name,CustomerMbl,CustomerEmail) VALUES('" + Int32.Parse(label13.Text) + "', '" + textBox3.Text + "', '" + Int32.Parse(label14.Text) + "',   '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "','" + Int32.Parse(a) + "' ,'" + textBox6.Text + "','" + textBox5.Text + "','" + textBox8.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();

                insert2();
                insert3();
                con.Close();


                MessageBox.Show("Inserted Successfully");
            }
            catch(Exception ex)
            {

            }
            
        }
        private void LoadData()

        {
            string x = UserControls.UC_Room.RoomInfo.TextData;
            con.Open();
            // sqlConnection.Open();
            String str = "SELECT checkin, checkout FROM ROrder where room_id = '" + x + "' and status = 1";
            sqlCommand1 = new SqlCommand(str, con);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCommand1;

            DataSet ds = new DataSet();
            da.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        public void insert2()
        {
            string s = "Onsite Booking";
            string Time = DateTime.Now.ToString("hh:mm:ss tt");
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            string query = " insert into Order2(user_name,Name, type,price,paymentMethod,paymentID,date,time) values ('" + textBox3.Text.Trim() + "','" + textBox6.Text.Trim() + "','"
                                                            + s + "','"
                                                            + label14.Text.Trim() + "','"
                                                            + comboBox1.Text.Trim() + "','"
                                                            + textBox7.Text.Trim() + "','"
                                                            + Date + "','"
                                                            + Time + "')";
            sqlCommand1 = new SqlCommand(query, con);
            sqlCommand1.ExecuteNonQuery();
        }
        public void insert3()
        {
            try
            {
                string x = "1";
                string query = " update ROrder set inout ='" + x + "' where room_id = '" + label13.Text + "'";
                sqlCommand2 = new SqlCommand(query, con);

                sqlCommand2.ExecuteNonQuery();


                MessageBox.Show("Data Updated Successfully");
            }
            catch(Exception e)
            {

            }
        }


        private void show_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT ROID,room_id,user_name,price,checkin,checkout,Name,CustomerMbl,CustomerEmail from ROrder where status = 1";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
