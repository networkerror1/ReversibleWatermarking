using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Firewall;


namespace ReversibleDataHiding
{
    public partial class DataEmbed : Form
    {
        OpenFileDialog opf = new OpenFileDialog();
        int i = 0;
        string inputPath,inputpath1,inputpath2,inputpath3,inputpath4,inputpath5;
        string outputPath,op,op1,op2,op3,op4,op5;
        string message,f1n,f2n,f3n,f4n,f5n,f6n;
        public bool datext = false;
        public DataEmbed(string val,string val1,string val2,string val3,string val4,string val5)
        {
            InitializeComponent();
            inputPath = val;
            inputpath1 = val1;
            inputpath2 = val2;
            inputpath3 = val3;
            inputpath4 = val4;
            inputpath5 = val5;
        }

        private void DataEmbed_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath+"\\temp\\temp.bmp"))
            {
                File.Delete(Application.StartupPath+"\\temp\\temp.bmp");
            }
            if (File.Exists(Application.StartupPath + "\\temp\\temp1.bmp"))
            {
                File.Delete(Application.StartupPath + "\\temp\\temp1.bmp");
            }
            if (File.Exists(Application.StartupPath + "\\temp\\temp2.bmp"))
            {
                File.Delete(Application.StartupPath + "\\temp\\temp2.bmp");
            }
            if (File.Exists(Application.StartupPath + "\\temp\\temp3.bmp"))
            {
                File.Delete(Application.StartupPath + "\\temp\\temp3.bmp");
            }
            if (File.Exists(Application.StartupPath + "\\temp\\temp4.bmp"))
            {
                File.Delete(Application.StartupPath + "\\temp\\temp4.bmp");
            }
            if (File.Exists(Application.StartupPath + "\\temp\\temp5.bmp"))
            {
                File.Delete(Application.StartupPath + "\\temp\\temp5.bmp");
            }
            File.Copy(inputPath,Application.StartupPath+"\\temp\\temp.bmp");
            File.Copy(inputpath1, Application.StartupPath+"\\temp\\temp1.bmp");
            File.Copy(inputpath2, Application.StartupPath + "\\temp\\temp2.bmp");
            File.Copy(inputpath3, Application.StartupPath + "\\temp\\temp3.bmp");
            File.Copy(inputpath4, Application.StartupPath + "\\temp\\temp4.bmp");
            File.Copy(inputpath5, Application.StartupPath + "\\temp\\temp5.bmp");
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp.bmp");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp1.bmp");
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp2.bmp");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp3.bmp");
            pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp4.bmp");
            pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\temp\\temp5.bmp");  
            f1n = Path.GetFileName(inputPath);
            f2n = Path.GetFileName(inputpath1);
            f3n = Path.GetFileName(inputpath2);
            f4n = Path.GetFileName(inputpath3);
            f5n = Path.GetFileName(inputpath4);
            f6n = Path.GetFileName(inputpath5);
            op = Path.GetDirectoryName(inputPath)+"\\"+"file.bmp";
            op1 = Path.GetDirectoryName(inputpath1)+"\\"+"file1.bmp";
            op2 = Path.GetDirectoryName(inputpath2)+"\\"+"file2.bmp";
            op3 = Path.GetDirectoryName(inputpath3)+"\\"+"file3.bmp";
            op4 = Path.GetDirectoryName(inputpath4)+"\\"+"file4.bmp";
            op5 = Path.GetDirectoryName(inputpath5)+"\\"+"file5.bmp";
        }
        private void EncryptMessage(string OutPut)
        {
            
            try
            {
                if (i == 0)
                {
                    message = textBox1.Text;
                    Stegano newStegano = new Stegano();
                    newStegano.HideMessage(inputPath, op, textBox1.Text);
                    i++;
                }
                else if (i == 1)
                {
                    Stegano stg = new Stegano();
                    stg.HideMessage(inputpath1, op1, textBox2.Text);
                    i++;
                }
                else if (i == 2)
                {                    
                    Stegano stg = new Stegano();
                    stg.HideMessage(inputpath2, op2, textBox3.Text);
                    i++;
                }
                else if (i == 3)
                {
                    Stegano stg = new Stegano();
                    stg.HideMessage(inputpath3, op3, textBox4.Text);
                    i++;
                }
                else if (i == 4)
                {
                    Stegano stg = new Stegano();
                    stg.HideMessage(inputpath4, op4, textBox5.Text);
                    i++;
                }
                else if (i == 5)
                {
                    Stegano stg = new Stegano();
                    stg.HideMessage(inputpath5, op5, textBox6.Text);
                    i++;
                }
                datext = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured While Encrypting Message..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                if (textBox2.Text != null && textBox2.Text != "")
                {
                    if (textBox3.Text != null && textBox3.Text != "")
                    {
                        if (textBox4.Text != null && textBox4.Text != "")
                        {
                            if (textBox5.Text != null && textBox5.Text != "")
                            {
                                if (textBox6.Text != null && textBox6.Text != "")
                                {
                                    EncryptMessage(op);
                                    MessageBox.Show("Image Saved in " + op);
                                    EncryptMessage(op1);
                                    MessageBox.Show("Image Saved in " + op1);
                                    EncryptMessage(op2);
                                    MessageBox.Show("Image Saved in " + op2);
                                    EncryptMessage(op3);
                                    MessageBox.Show("Image Saved in " + op3);
                                    EncryptMessage(op4);
                                    MessageBox.Show("Image Saved in " + op4);
                                    EncryptMessage(op5);
                                    MessageBox.Show("Image Saved in " + op5);
                                }
                            }
                        }
                    }
                }
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
