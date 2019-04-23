using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemManagement.UserControls;

namespace SystemManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlPanel(uch);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if(panelLeft.Width>=PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 200)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSlidePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }
        private void AddControlPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnhome);
            UC_Home uch = new UC_Home();
AddControlPanel(uch);
        }

        private void btnrestaurant_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnmenu);
            UC_Menu mn = new UC_Menu();
            AddControlPanel(mn);
        }

      /*  private void btnorder_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnorder);
            UC_Order uo = new UC_Order();
            AddControlPanel(uo);
        }
        */

        private void btnbill_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnbill);
            UC_Sales uc = new UC_Sales();
            AddControlPanel(uc);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeltime.Text = dt.ToString("HH:MM:ss");
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnuser);
            UC_User us = new UC_User();
            AddControlPanel(us);
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnemp);
            UC_Emp em = new UC_Emp();
            AddControlPanel(em);
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            moveSlidePanel(btnroom);
            UC_Room rm = new UC_Room();
            AddControlPanel(rm);
        }
    }
}
