using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using BitmapImage;

namespace MPEGBuilder1UI
{
	/// <summary>
	/// Summary description for DCTCalculationDialog.
	/// </summary>
	public class DCTCalculationDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button button2;

		public double[,] B = new double[8,8];
		public int[,] S1 = new int[8,8];
		public int[] zz = new int[64];

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;

		MPEGFunctions MPEG = new MPEGFunctions();

		public DCTCalculationDialog()
		{
			InitializeComponent();

			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
	
		public DCTCalculationDialog(byte[,] valueMatrix)
		{
			// Write valueMatrix[] into ListView and initialize buttons
			InitializeComponent();

			FillPixelLV(valueMatrix);
			B = MPEG.calculateDCT(valueMatrix);
			FillDCTLV(B);

			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
		}

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
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(16, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 152);
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
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(16, 232);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(520, 168);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "S(i,j)";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "i0";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "i1";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "i2";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "i3";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "i4";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "i5";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "i6";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "i7";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 221);
            this.label1.TabIndex = 4;
            this.label1.Text = "PIXELS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 221);
            this.label2.TabIndex = 5;
            this.label2.Text = "FREQUENCY COMPONENTS";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quantize Default";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(128, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Zigzag Order";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(232, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "DC Encode";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(336, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "AC Encode";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DCTCalculationDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::MPEGBuilder1UI.Properties.Resources.blue_white_abstract_background_thumb_medium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 469);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DCTCalculationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCTCalculationDialog";
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void FillPixelLV(byte[,] values)
		{
			// Write pixel values[] into ListView1
			int i, j;
			string[] rowRGB = new string[9];
			byte pixelColor;

			listView1.Items.Clear();
			for (i=0; i<8; i++)
			{
				rowRGB[0] = "y" + i.ToString();
				for (j=0; j<8; j++)
				{
					pixelColor = values[i,j];
					rowRGB[j+1] = pixelColor.ToString();
				}
				listView1.Items.Add(new ListViewItem(rowRGB));
			}
		}

		private void FillDCTLV(double[,] values)
		{
			// Write calculated DCT values into ListView2
			int i, j;
			string[] rowRGB = new string[9];
			double DCTresult;

			listView2.Items.Clear();
			for (i=0; i<8; i++)
			{
				rowRGB[0] = "y" + i.ToString();
				for (j=0; j<8; j++)
				{
					DCTresult = values[i,j];
					rowRGB[j+1] = DCTresult.ToString("f3");
				}
				listView2.Items.Add(new ListViewItem(rowRGB));
			}
		}

		private void FillDCTLV1(int[,] values)
		{
			// Write quantized DCT values[] into ListView2
			int i, j;
			string[] rowRGB = new string[9];
			int Qresult;

			listView2.Items.Clear();
			for (i=0; i<8; i++)
			{
				rowRGB[0] = "y" + i.ToString();
				for (j=0; j<8; j++)
				{
					Qresult = values[i,j];
					rowRGB[j+1] = Qresult.ToString();
				}
				listView2.Items.Add(new ListViewItem(rowRGB));
			}
		}

		private void FillDCTLV2(int[] values)
		{
			// Write reordered quantized DCT values[] into ListView2
			int i, j;
			string[] rowRGB = new string[9];
			int ZZresult;

			listView2.Items.Clear();
			for (i=0; i<8; i++)
			{
				rowRGB[0] = "y" + i.ToString();
				for (j=0; j<8; j++)
				{
					ZZresult = values[i*8 + j];
					rowRGB[j+1] = ZZresult.ToString();
				}
				listView2.Items.Add(new ListViewItem(rowRGB));
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// Quantize DCT coefficients
			S1 = MPEG.Quantize(B);
			FillDCTLV1(S1);		
			button3.Enabled = true;
			button4.Enabled = false;
			button5.Enabled = false;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			// Put in zigzag order
			zz = MPEG.Zigzag(S1);
			FillDCTLV2(zz);		
			button4.Enabled = true;
			button5.Enabled = true;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			// Display DC coefficient
			DCEncodeDialog dlg = new DCEncodeDialog(zz[0]);
			dlg.ShowDialog();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			// Display AC coefficient
			byte[] ACbits = new byte[2048];
			int i = 0;

			ACbits = MPEG.ACHuffmanEncode(zz);
			
			while (ACbits[i] != 255)
				i++;

			ByteListDialog dlg = new ByteListDialog(ACbits, i);
			dlg.ShowDialog();
		}
	}
}
