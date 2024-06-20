using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MPEGBuilder1UI
{
	/// <summary>
	/// Summary description for YUVDisplayDialog.
	/// </summary>
	public class YUVDisplayDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label1;

		private byte[,] valueMatrix = new byte[8,8];
		private int quadX = 0;
		private int quadY = 0;
		private System.Windows.Forms.Label label2;
		private int buttonNumber = 1;

		public YUVDisplayDialog()
		{
			InitializeComponent();
		}

		public YUVDisplayDialog(Bitmap img)
		{
			// Load image section into picture box
			InitializeComponent();
			pictureBox1.Image = img;

			radioButton1.Checked = true;

			quadX = 0;
			quadY = 0;
			buttonNumber = 1;
			fillLV();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(192, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 168);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pixel";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "x0";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "x1";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "x2";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "x3";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "x4";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "x5";
            this.columnHeader7.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "x6";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "x7";
            this.columnHeader9.Width = 40;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Calculate DCT";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(415, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Close";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(16, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 224);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Component Select";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color Component";
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(16, 192);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(64, 24);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.Text = "Pb";
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged_1);
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(16, 152);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 24);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.Text = "Pr";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Y Quadrant";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(16, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "Upper Left";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(16, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 24);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "Lower Left";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(72, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 24);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.Text = "Lower Right";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(72, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Upper Right";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // YUVDisplayDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::MPEGBuilder1UI.Properties.Resources.blue_and_white_t2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YUVDisplayDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUVDisplayDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			// Calculate DCT and display in new dialog
			DCTCalculationDialog dlg = new DCTCalculationDialog(valueMatrix);
			dlg.ShowDialog();
		}

		private void radioButton1_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Upper left Brightness quadrant of image section
			quadX = 0;
			quadY = 0;
			buttonNumber = 1;
			fillLV();
		}

		private void radioButton2_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Upper right Brightness quadrant of image section
			quadX = 8;
			quadY = 0;
			buttonNumber = 2;
			fillLV();
		}

		private void radioButton3_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Lower left Brightness quadrant of image section
			quadX = 0;
			quadY = 8;
			buttonNumber = 3;
			fillLV();
		}

		private void radioButton4_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Lower right Brightness quadrant of image section
			quadX = 8;
			quadY = 8;
			buttonNumber = 4;
			fillLV();
		}

		private void radioButton5_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Pr color component of image section
			quadX = 0;
			quadY = 0;
			buttonNumber = 5;
			fillLV();
		}

		private void radioButton6_CheckedChanged_1(object sender, System.EventArgs e)
		{
			// Pb color component of image section
			quadX = 0;
			quadY = 0;
			buttonNumber = 6;
			fillLV();
		}

		private void fillLV()
		{
			// Write selected quadrant of component values into ListView
			int i, j;
			string[] rowRGB = new string[9];
			byte pixelColor;
			double Y, Pr, Pb;
			double pixelR, pixelG, pixelB;

			Bitmap img = new Bitmap(pictureBox1.Image);

			listView1.Items.Clear();

			for (i=quadY; i<quadY+8; i++)
			{
				rowRGB[0] = "y" + i.ToString();
				for (j=quadX; j<quadX+8; j++)
				{
					if (buttonNumber < 5)
					{
						pixelR = img.GetPixel(j,i).R;
						pixelG = img.GetPixel(j,i).G;
						pixelB = img.GetPixel(j,i).B;
						Y = (219.0*(0.59*pixelR + 0.30*pixelG + 0.11*pixelB) / 255.0) + 16.0;
						pixelColor = (byte) Y;
						listView1.ForeColor = Color.Black;
					}
					else if (buttonNumber == 5)
					{
						pixelR = img.GetPixel(j*2,i*2).R;
						pixelG = img.GetPixel(j*2,i*2).G;
						pixelB = img.GetPixel(j*2,i*2).B;
						Pr = (224.0*(0.50*pixelR - 0.42*pixelG - 0.08*pixelB) / 255.0) + 128.0;
						pixelColor = (byte) Pr;
						listView1.ForeColor = Color.Red;
					}
					else
					{
						pixelR = img.GetPixel(j*2,i*2).R;
						pixelG = img.GetPixel(j*2,i*2).G;
						pixelB = img.GetPixel(j*2,i*2).B;
						Pb = (224.0*(-0.17*pixelR - 0.33*pixelG + 0.50*pixelB) / 255.0) + 128.0;
						pixelColor = (byte) Pb;
						listView1.ForeColor = Color.Blue;
					}

					rowRGB[j-quadX+1] = pixelColor.ToString();

					valueMatrix[i-quadY,j-quadX] = pixelColor;
				}
				listView1.Items.Add(new ListViewItem(rowRGB));
			}
		}
	}
}
