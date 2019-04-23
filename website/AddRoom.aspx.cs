using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;
using System.IO;

namespace WebApplication3
{
    public partial class AddRoom : System.Web.UI.Page
    {
        String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {


                //Insert and upload Images
                if (fuImg01.HasFile)
                {
                    string SavePath = Server.MapPath("~/pic/Room/");
                    if (!Directory.Exists(SavePath))
                    {
                        Directory.CreateDirectory(SavePath);
                    }
                    string Extention = Path.GetExtension(fuImg01.PostedFile.FileName);
                    fuImg01.SaveAs(SavePath + "\\" + txtRoomType.Text.ToString().Trim() + Extention);

                    SqlCommand cmd = new SqlCommand("ProcRoomAdd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@room_type", txtRoomType.Text);
                    cmd.Parameters.AddWithValue("@rent_fee", txtRentFee.Text);
                    cmd.Parameters.AddWithValue("@room_category ", txtRoomCategory.Text);

                    cmd.Parameters.AddWithValue("@room_image", txtRoomType.Text.ToString().Trim());
                    cmd.Parameters.AddWithValue("@image_extension", Extention);
                    cmd.Parameters.AddWithValue("@Descrip", Extention);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    //Int64 FID1 = Convert.ToInt64(cmd.ExecuteScalar());

                    //if (FID1 != null)
                    //{
                    //  test.Text = FID1.ToString();
                    //}


                }

                txtRoomType.Text = string.Empty;
                txtRoomCategory.Text = string.Empty;
                txtRentFee.Text = string.Empty;
            



            }

        }
    }
}