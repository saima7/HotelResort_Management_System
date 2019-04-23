using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.Forms;

namespace SystemManagement.UserControls
{
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void Addtocart(string text)
        {
            
           
        }

        private void Addtocart(String name,String qty,String amount)
        {
            
        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Form_total tt = new Form_total())
            {
                tt.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_Bl bil = new Form_Bl())
            {
                bil.ShowDialog();
            }
        }
    }
}
