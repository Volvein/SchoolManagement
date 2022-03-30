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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UserControl4 a = new UserControl4();
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            this.AutoScroll = false;
            this.AutoSize = false;
            a.BringToFront();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }
    }
}
