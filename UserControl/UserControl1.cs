using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using App1.Properties;
using System.Data.SqlClient;
using App1.StudentDataSetTableAdapters;
using System.IO;

namespace App1
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection x;
        SqlCommand y;
        //SqlDataReader z;
        public UserControl1()
        {
            InitializeComponent();
            x = new SqlConnection(@"Data Source=DESKTOP-KAE6KCQ\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
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

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            try
            {
                x.Open();
                y = new SqlCommand("insert into tbl_test values(@1)", x);
                y.Parameters.AddWithValue("@1", TextBox2.Text);
               
                y.ExecuteNonQuery();
                MessageBox.Show("sucessfully add");
                x.Close();
            }
            catch (Exception yy) { }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            guna2TextBox13.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files(*.*)|*.*|jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog1.ShowDialog();
                pictureBox1.Load(openFileDialog1.FileName);
            }
            catch (Exception aa)
            {
                throw;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files(*.*)|*.*|jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog1.ShowDialog();
                pictureBox2.Load(openFileDialog1.FileName);
            }
            catch (Exception aa)
            {
             throw;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files(*.*)|*.*|jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog1.ShowDialog();
                pictureBox3.Load(openFileDialog1.FileName);
            }
            catch (Exception aa)
            {
                throw;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files(*.*)|*.*|jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog1.ShowDialog();
                pictureBox4.Load(openFileDialog1.FileName);
            }
            catch (Exception aa)
            {
                throw;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files(*.*)|*.*|jpg (*.jpg)|*.jpg|png (*.png)|*.png";
                openFileDialog1.ShowDialog();
                pictureBox5.Load(openFileDialog1.FileName);
            }
            catch (Exception aa)
            {
                throw;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
