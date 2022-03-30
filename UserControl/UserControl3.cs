using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
  
     

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UserControl2 a = new UserControl2();
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            this.AutoScroll = false;
            this.AutoSize = false;
            a.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
