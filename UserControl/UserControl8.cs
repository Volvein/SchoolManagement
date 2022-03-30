using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;



namespace App1
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
            }
            catch(Exception aa)
            {
                MessageBox.Show("Selected Commit you can delete", "DELETE", MessageBoxButtons.OK);
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(textBox1.Text.ToString());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
