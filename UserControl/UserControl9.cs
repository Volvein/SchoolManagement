using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class UserControl9 : UserControl
    {
        public UserControl9()
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
    }
}
