using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MPEGBuilder1;

namespace ReversibleDataHiding
{
    public partial class Main : Form
    {
        private string _fileNameWithoutExtension;
        private string _fileExtension;
        private string _fileDirectory;
        string img1path, img2path, img3path, img4path, img5path, img6path;
        OpenFileDialog opf = new OpenFileDialog();
        Form1 f1 = new Form1();
        DataEmbed de;
       // DataExtract dee;
       // Graph g = new Graph();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button2.Enabled = false;
            button3.Enabled = false;
            Browse_dir.Enabled = true;
            //button4.Enabled = false;
            //button5.Enabled = false;
        }
        public void Cropping(string inputImgPath, int cropWidth, int cropHeight)
        {
            this._fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(inputImgPath);
            this._fileExtension = System.IO.Path.GetExtension(inputImgPath);
            this._fileDirectory = System.IO.Path.GetDirectoryName(inputImgPath);

            //Load the image divided
            Image inputImg = Image.FromFile(inputImgPath);
            int imgWidth = inputImg.Width;
            int imgHeight = inputImg.Height;

            //Divide how many small blocks
            //int widthCount = (int)Math.Ceiling((imgWidth * 1.00) / (cropWidth * 1.00));
            //int heightCount = (int)Math.Ceiling((imgHeight * 1.00) / (cropHeight * 1.00));
            int widthCount = 2;
            int heightCount = 3;
            ArrayList areaList = new ArrayList();

            int i = 0;
            for (int iHeight = 0; iHeight < heightCount; iHeight++)
            {
                for (int iWidth = 0; iWidth < widthCount; iWidth++)
                {
                    int pointX = iWidth * cropWidth;
                    int pointY = iHeight * cropHeight;
                    int areaWidth = ((pointX + cropWidth) > imgWidth) ? (imgWidth - pointX) : cropWidth;
                    int areaHeight = ((pointY + cropHeight) > imgHeight) ? (imgHeight - pointY) : cropHeight;
                    string s = string.Format("{0};{1};{2};{3}", pointX, pointY, areaWidth, areaHeight);

                    Rectangle rect = new Rectangle(pointX, pointY, areaWidth, areaHeight);
                    areaList.Add(rect);
                    i++;
                }
            }

            for (int iLoop = 0; iLoop < areaList.Count; iLoop++)
            {
                Rectangle rect = (Rectangle)areaList[iLoop];
                string fileName = this._fileDirectory + "\\" + this._fileNameWithoutExtension + "_" + iLoop.ToString() + ".bmp";
                Bitmap newBmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
                Graphics newBmpGraphics = Graphics.FromImage(newBmp);
                newBmpGraphics.DrawImage(inputImg, new Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel);
                newBmpGraphics.Save();
                switch (this._fileExtension.ToLower())
                {
                    case ".jpg":
                    case ".jpeg":
                        newBmp.Save(fileName, ImageFormat.Jpeg);
                        break;
                    case "gif":
                        newBmp.Save(fileName, ImageFormat.Gif);
                        break;
                    case ".bmp":
                        newBmp.Save(fileName, ImageFormat.Bmp);
                        break;
                }

            }
            inputImg.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Application.StartupPath + "\\main\\temp.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp.bmp");
                }
                if (File.Exists(Application.StartupPath + "\\main\\temp1.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp1.bmp");
                }
                if (File.Exists(Application.StartupPath + "\\main\\temp2.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp2.bmp");
                }
                if (File.Exists(Application.StartupPath + "\\main\\temp3.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp3.bmp");
                }
                if (File.Exists(Application.StartupPath + "\\main\\temp4.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp4.bmp");
                }
                if (File.Exists(Application.StartupPath + "\\main\\temp5.bmp"))
                {
                    File.Delete(Application.StartupPath + "\\main\\temp5.bmp");
                }

                string fpath = Path.GetDirectoryName(opf.FileName) + "\\";
                string ext = Path.GetExtension(opf.FileName);
                string fname = Path.GetFileNameWithoutExtension(opf.FileName);
                pictureBox1.Image = Image.FromFile(opf.FileName);
                Cropping(opf.FileName, pictureBox1.Image.Width / 2, pictureBox1.Image.Height / 3);
                File.Copy(fpath + fname + "_0" + ".bmp",Application.StartupPath+"\\main\\temp.bmp");
                File.Copy(fpath + fname + "_1" + ".bmp", Application.StartupPath + "\\main\\temp1.bmp");
                File.Copy(fpath + fname + "_2" + ".bmp", Application.StartupPath + "\\main\\temp2.bmp");
                File.Copy(fpath + fname + "_3" + ".bmp", Application.StartupPath + "\\main\\temp3.bmp");
                File.Copy(fpath + fname + "_4" + ".bmp", Application.StartupPath + "\\main\\temp4.bmp");
                File.Copy(fpath + fname + "_5" + ".bmp", Application.StartupPath + "\\main\\temp5.bmp");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\main\\temp.bmp");
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\main\\temp1.bmp");
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\main\\temp2.bmp");
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\main\\temp3.bmp");
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\main\\temp4.bmp");
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\main\\temp5.bmp"); 
                img1path = fpath + fname + "_0" + ".bmp";
                img2path = fpath + fname + "_1" + ".bmp";
                img3path = fpath + fname + "_2" + ".bmp";
                img4path = fpath + fname + "_3" + ".bmp";
                img5path = fpath + fname + "_4" + ".bmp";
                img6path = fpath + fname + "_5" + ".bmp";
                button5.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button3.Enabled = true;
            f1.TopLevel = false;
            f1.Parent = this;
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // button4.Enabled = true;
            de = new DataEmbed(img1path,img2path,img3path,img4path,img5path,img6path);
            f1.Hide();
            de.TopLevel = false;
            de.Parent = this;
            de.Show();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button5.Enabled = true;
            //string path1 = Path.GetDirectoryName(opf.FileName) + "\\file.bmp";
            //string path2 = Path.GetDirectoryName(opf.FileName) + "\\file1.bmp";
            //dee = new DataExtract(path1,path2);
            //f1.Hide();
            //de.Hide();
            //dee.TopLevel = false;
            //dee.Parent = this;
            //dee.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Browse_dir.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;

            histogramaDesenat1.Visible = false;
            //button4.Enabled = false;
            //button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //g.TopLevel = false;
            //g.Parent = this;
            //f1.Hide();
            //dee.Hide();
            //de.Hide();
            //g.Show();
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            long[] myValues = GetHistogram(new Bitmap(pictureBox1.Image));
            histogramaDesenat1.DrawHistogram(myValues);
            histogramaDesenat1.Visible = true;
            button2.Enabled = true;
        }
        public long[] GetHistogram(System.Drawing.Bitmap picture)
        {
            long[] myHistogram = new long[256];

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    myHistogram[Temp]++;
                }

            return myHistogram;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     
    }
}
