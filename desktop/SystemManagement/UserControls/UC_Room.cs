using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemManagement.UserControls
{
    public partial class UC_Room : UserControl
    {
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private DataSet dataSet2 = new DataSet();
        public UC_Room()
        {
            InitializeComponent();
        }
        public static class RoomInfo
        {
            public static string TextData { get; set; }
        }
        // String connectionString=  "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5UHHJB2\SQLEXPRESS;Initial Catalog=RHMANAGEMENT;Persist Security Info=True;User ID=sa;Password=sakif");
        SqlConnection con = new SqlConnection("Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            //String query = "SELECT * FROM Room where room_type like '%" + textBox.Text.ToString() + "%'";
            // String query = "SELECT * FROM Room WHERE room_id  NOT IN(SELECT Room.room_id FROM Room INNER JOIN ROrder ON Room.room_id = ROrder.room_id where ROrder.checkin = '" + DateTime.Today.ToString("yyyy - MM - dd") + "'AND ROrder.Status = 1 ) AND room_type like '%" + textBox.Text.ToString() + "%'";
            String query = "SELECT * FROM Room WHERE room_id  NOT IN(SELECT Room.room_id FROM Room INNER JOIN ROrder ON Room.room_id = ROrder.room_id where (ROrder.checkin = '" + DateTime.Today.ToString("yyyy - MM - dd") + "'AND ROrder.Status = 1) OR ROrder.inout = 1) AND room_type like '%" + textBox.Text.ToString() + "%'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomInfo.TextData = dataGridView.CurrentRow.Cells[0].Value.ToString();
            Room f1 = new Room();
            f1.label13.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            f1.label14.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            f1.ShowDialog();

            /* con.Open();
             String query = "UPDATE Room SET Status = 'Yes' WHERE RM_ID = '" + this.dataGridView.CurrentRow.Cells[0].Value.ToString() + "';";
             SqlDataAdapter SDA = new SqlDataAdapter(query, con);
             SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
             MessageBox.Show("Update Successfully");*/
        }

        private void UC_Room_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool NoRoom(string eID)
        {
            try
            {
                //sqlConnection.Open();
                sqlCommand.CommandText = " select * from Room where room_id = '" + eID + "'";
                sqlCommand.Connection = con;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "Room");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Response.Redirect("home.aspx");
                    return false;
                }
                else
                {
                    return true;

                }
                //sqlConnection.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error");

            }

            return false;

        }
        public void reload()
        {
            UC_Room lg = new UC_Room();
            //  page2 lg = new page2();
            
            
        }
        private void ClearData()
        {
            textBox1.Clear();
           
            comboBox1.ResetText();
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
           // try
           // {
                if (NoRoom(textBox1.Text))
                {
                    MessageBox.Show("Invalid Room ID!");


                }

                else
                {
                    con.Open();

                    string x = "";
                    if (comboBox1.Text.Equals("In"))
                    {
                        x = "1";
                    }
                    else
                    {
                        x = "0";
                    }
                    string query = " update ROrder set inout ='" + x + "' where room_id = '" + textBox1.Text + "'";
                    sqlCommand2 = new SqlCommand(query, con);

                    sqlCommand2.ExecuteNonQuery();


                    MessageBox.Show("Data Updated Successfully");
                    con.Close();
                    
                

            }
                //  }


           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show("Error");
           // }

        }
    
    }
    }
//}
