using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManagement.UserControls
{
    public partial class UC_Emp : UserControl
    {
        public UC_Emp()
        {
            InitializeComponent();
        }
        private void adminRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.adminRegister ag = new Admin.adminRegister();
            //  ag.MdiParent = this ;
            ag.StartPosition = FormStartPosition.CenterScreen;
            ag.Show();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        bool close = true;
        private void adminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;

                }
            }

        }



        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.ChangePass cp = new Admin.ChangePass();
            //  ag.MdiParent = this ;
            cp.StartPosition = FormStartPosition.CenterScreen;
            cp.Show();

        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.EmpList er = new Employee.EmpList();
            //  ag.MdiParent = this ;
            er.StartPosition = FormStartPosition.CenterScreen;
            er.Show();

        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee.EmpReg er = new Employee.EmpReg();
            //  ag.MdiParent = this ;
            er.StartPosition = FormStartPosition.CenterScreen;
            er.Show();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.EmpAtnd er = new Employee.EmpAtnd();
            //  ag.MdiParent = this ;
            er.StartPosition = FormStartPosition.CenterScreen;
            er.Show();
        }
    }
}
