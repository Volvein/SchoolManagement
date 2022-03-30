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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserControl7 a = new UserControl7();
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserControl9 a = new UserControl9();
            Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.BringToFront();
        }
    }
}
