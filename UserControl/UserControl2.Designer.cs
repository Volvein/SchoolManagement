namespace App1
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BorderRadius = 2;
            this.Button2.CheckedState.Parent = this.Button2;
            this.Button2.CustomImages.Parent = this.Button2;
            this.Button2.FillColor = System.Drawing.Color.Thistle;
            this.Button2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.Button2.HoverState.Parent = this.Button2;
            this.Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button2.Location = new System.Drawing.Point(60, 248);
            this.Button2.Name = "Button2";
            this.Button2.PressedDepth = 10;
            this.Button2.ShadowDecoration.Parent = this.Button2;
            this.Button2.Size = new System.Drawing.Size(114, 25);
            this.Button2.TabIndex = 170;
            this.Button2.Text = "Staff./Teacher";
            this.Button2.TextOffset = new System.Drawing.Point(0, 2);
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BorderRadius = 2;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.Thistle;
            this.Button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button1.Location = new System.Drawing.Point(60, 206);
            this.Button1.Name = "Button1";
            this.Button1.PressedDepth = 10;
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(114, 25);
            this.Button1.TabIndex = 169;
            this.Button1.Text = "Student";
            this.Button1.TextOffset = new System.Drawing.Point(0, 2);
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button3
            // 
            this.Button3.BorderRadius = 2;
            this.Button3.CheckedState.Parent = this.Button3;
            this.Button3.CustomImages.Parent = this.Button3;
            this.Button3.FillColor = System.Drawing.Color.Thistle;
            this.Button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.Button3.HoverState.Parent = this.Button3;
            this.Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button3.Location = new System.Drawing.Point(60, 291);
            this.Button3.Name = "Button3";
            this.Button3.PressedDepth = 10;
            this.Button3.ShadowDecoration.Parent = this.Button3;
            this.Button3.Size = new System.Drawing.Size(114, 25);
            this.Button3.TabIndex = 171;
            this.Button3.Text = "Appointment";
            this.Button3.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.DoubleBuffered = true;
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(853, 521);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button2;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button Button3;
    }
}
