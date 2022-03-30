using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1.Properties;

namespace App1
{
    public partial class UserControl2 : UserControl
    {
   
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            UserControl1 a = new UserControl1();         
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.BringToFront();   
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserControl3 a = new UserControl3();
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.BringToFront();
        }
    }
}
