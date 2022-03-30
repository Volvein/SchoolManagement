using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI.Animation;
using Guna.UI2.AnimatorNS;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, System.EventArgs e)
        {
            UserControl2 a = new UserControl2();
            if (!gunaPanel1.Controls.Contains(a))
            {
                gunaPanel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }

     

        private void guna2Button7_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UserControl5 a = new UserControl5();
            if (!gunaPanel1.Controls.Contains(a))
            {
                gunaPanel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UserControl8 a = new UserControl8();
            if (!gunaPanel1.Controls.Contains(a))
            {
                gunaPanel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserControl4 a = new UserControl4();
            if (!gunaPanel1.Controls.Contains(a))
            {
                gunaPanel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UserControl6 a = new UserControl6();
            if (!gunaPanel1.Controls.Contains(a))
            {
                gunaPanel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }
    }
}
