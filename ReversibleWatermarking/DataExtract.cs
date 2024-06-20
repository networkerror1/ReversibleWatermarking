using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Firewall;

namespace ReversibleDataHiding
{
    public partial class DataExtract : Form
    {
        string message;
        string pbf1, pbf2;
        int i = 0;
        string p1, p2;
        public DataExtract(string val,string val1)
        {
            InitializeComponent();
            p1 = val;
            p2 = val1;
        }
        OpenFileDialog opf = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pbf1 = opf.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
                pbf2 = opf.FileName;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            i = 0;
            DecryptMessage(p1);
            button4.Enabled = true;
        }
        private void DecryptMessage(string DecryptedImagePath)
        {
            try
            {
                if (i == 0)
                {
                    Stegano newStegano = new Stegano();
                    message = newStegano.RetriveMessage(DecryptedImagePath);
                    textBox1.Text = message;
                    i = 1;
                }
                else if (i == 1)
                {
                    Stegano steg = new Stegano();
                    message = steg.RetriveMessage(DecryptedImagePath);
                    textBox2.Text = message;
                    i = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured While Decrypting Image..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 1;
            DecryptMessage(p2);
            button5.Enabled = true;
        }

        private void DataExtract_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(p1);
            pictureBox2.Image = Image.FromFile(p2);
            button5.Enabled = false;
            button4.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.Image = (Image)MergeTwoImages(pictureBox1.Image,pictureBox2.Image);
        }
        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width > secondImage.Width ? firstImage.Width : secondImage.Width;

            int outputImageHeight = firstImage.Height + secondImage.Height + 1;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(0, firstImage.Height), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }
            return outputImage;
        }

    }
}
