using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShowing
{
    public partial class Form1 : Form
    {
        int currentImageIndex = 0; 
        public Form1()
        {
            InitializeComponent();
            
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            but_open.BackColor = but_close.BackColor = but_Forword.BackColor = but_back.BackColor =
                but_SlidesShow.BackColor = but_SlideStop.BackColor = Color.Red;

            but_open.ForeColor = but_close.ForeColor = but_Forword.ForeColor = but_back.ForeColor =
                but_SlidesShow.ForeColor = but_SlideStop.ForeColor = Color.White;

            panelBox.BackColor = Color.MistyRose;
            panelBox.Enabled = false;

            picbx.SizeMode = PictureBoxSizeMode.StretchImage;

        }

      

        private void bou_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_open_Click(object sender, EventArgs e)
        {
            panelBox.Enabled = true;
            picbx.Image = imageList.Images[currentImageIndex];
        }

        private void but_Forword_Click(object sender, EventArgs e)
        {
            if (imageList.Images.Count > 0)
            {
                currentImageIndex++;

                
                if (currentImageIndex >= imageList.Images.Count)
                {
                    currentImageIndex = 0;
                }

                picbx.Image = imageList.Images[currentImageIndex];
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            if (imageList.Images.Count > 0)
            {
                currentImageIndex--;

                if (currentImageIndex < 0)
                {
                    currentImageIndex = imageList.Images.Count - 1;
                }
                picbx.Image = imageList.Images[currentImageIndex];
            }
        }

        private void but_SlidesShow_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            but_Forword_Click(sender, e);
        }

        private void but_SlideStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
