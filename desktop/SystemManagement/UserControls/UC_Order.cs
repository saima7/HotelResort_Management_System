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
    public partial class UC_Order : UserControl
    {
        public UC_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_Order odr = new Form_Order())
            {
                odr.ShowDialog();
            }
        }
    }
}
