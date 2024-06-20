using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using BitmapImage;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace MPEGBuilder1UI
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components;

		public int mode = 16;
		public int nPictures = 1;
		private double stretchX = 1.0;
		private double stretchY = 1.0;
		private int xPos = 0;
		private int yPos = 0;
		private long outBytes = 0;
		private long inputFileLength = 0;

		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.ToolTip toolTip3;
		private System.Windows.Forms.Label label2;

		public UserControl1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Block Details";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(360, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "XBlock:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(472, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "YBlock:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(720, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(144, 13);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Pixel (R,G,B): ";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loaded Image";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zoom In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(312, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Use File->Open To Load Image");
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(720, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(931, 455);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Block details button
			PixelDisplayDialog dlg = new PixelDisplayDialog((Bitmap) pictureBox2.Image, mode);
			dlg.ShowDialog();	
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void UserControl1_Load(object sender, System.EventArgs e)
		{
			// On load, put a plain black bitmap in PictureBox2
			Bitmap img = new Bitmap(mode,mode);
			int i, j;
			for (i=0; i<mode; i++)
				for (j=0; j<mode; j++)
                    img.SetPixel(i,j,Color.Black);
			pictureBox2.Image = img;

			// On load, put a light gray bitmap in PictureBox2
			Bitmap img1 = new Bitmap(352,352);
			for (i=0; i<352; i++)
				for (j=0; j<352; j++)
					img1.SetPixel(i,j,Color.LightGray);
			pictureBox1.Image = img1;
		}

		public void LoadPictureBox1(string fileName)
		{
			Bitmap img = new Bitmap(fileName);
			ImageFunctions imgF = new ImageFunctions();
			imgF.setImage(img);

			toolTip1.SetToolTip(pictureBox1, "Click on a block to zoom in");
			toolTip2.SetToolTip(pictureBox2, "Display RGB values for pixel at cursor postion");
			toolTip3.SetToolTip(button1, "Display details of Zoom In image");

			FileInfo info = new FileInfo(fileName);
			inputFileLength = info.Length;

			//	In this section the loaded image is resized so that the height
			//	and width are multiples of 16.  That needs to be done because
			//	MPEG macroblocks are 16x16 pixels.
			Size imgSize = imgF.getBMPSize();
			int xFill = 0;
			int yFill = 0;
			int xRem, yRem;

			xRem = imgSize.Width%16;
			yRem = imgSize.Height%16;

			if (xRem != 0)
				xFill = 16-xRem;

			if (yRem != 0)
				yFill = 16-yRem;

			//	This is fills in the bitmap to an MPEG regulation size
			Bitmap img1 = new Bitmap(imgSize.Width+xFill, imgSize.Height+yFill);

			if ((xFill != 0) && (yFill == 0))
				imgF.padWidth(img1);
			else if ((xFill == 0) && (yFill != 0))
				imgF.padHeight(img1);
			else if ((xFill != 0) && (yFill != 0))
			{
				Bitmap img2 = new Bitmap(imgSize.Width+xFill, imgSize.Height);
				imgF.padWidth(img2);
				imgF.setImage(img2);
				imgF.padHeight(img1);
			}
			else
				img1 = img;

			//	Load the image into the picture box and if it's smaller than
			//	352x352 leave it alone.  If it is bigger than 352x352
			//	shrink it to fit the box.
			if (img1.Width <= 352 && img1.Height <= 352)
			{
				pictureBox1.Width = img1.Width;
				pictureBox1.Height = img1.Height;
				stretchX = stretchY = 1.0;
				pictureBox1.Image = img1;
			}
			else
			{
				pictureBox1.Width = 352;
				pictureBox1.Height = 352;
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				stretchX = 352.0/img1.Width;
				stretchY = 352.0/img1.Height;
				pictureBox1.Image = img1;
			}
		}

		private void UserControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Arrow;		
		}

		private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Hand;

			string s2, s3;

			xPos = ((int)(e.X / stretchX))/mode;
			s2 = "XBlock: " + xPos.ToString();
			textBox1.Text = s2;

			yPos = ((int)(e.Y / stretchY))/mode;
			s3 = "YBlock: " + yPos.ToString();
			textBox2.Text = s3;
		}

		private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int i, j;
			int dimX = mode;
			int dimY = mode;
			int xInit, yInit;

			xInit = xPos * mode;
			yInit = yPos * mode;
			Bitmap img = new Bitmap(dimX,dimY);
			Color clr = new Color();
			Bitmap pbImg = new Bitmap(pictureBox1.Image);

			for (i=0; i<dimY; i++)
				for (j=0; j<dimX; j++)
				{
					clr = pbImg.GetPixel((xPos*dimX)+j,(yPos*dimY)+i);
					img.SetPixel(j, i, clr);
				}

			pictureBox2.Image = img;
			if (mode == 8)
                label2.Text = "Zoom In Size: 8x8 pixels";
			else
				label2.Text = "Zoom In Size: 16x16 pixels";
		}

		private void pictureBox2_Click(object sender, System.EventArgs e)
		{}

		private void pictureBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{}

		private void pictureBox2_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Cross;
			
			int xPixel, yPixel;
			byte pixelR, pixelG, pixelB;
			string s2;

			Bitmap img = new Bitmap(pictureBox2.Image);

			xPixel = (e.X * mode) / 128;
			yPixel = (e.Y * mode) / 128;
			pixelR = img.GetPixel(xPixel, yPixel).R;
			pixelG = img.GetPixel(xPixel, yPixel).G;
			pixelB = img.GetPixel(xPixel, yPixel).B;

			s2 = "Pixel (R,G,B): (" + pixelR.ToString() + "," + 
					pixelG.ToString() + "," + pixelB.ToString() + ")";
			textBox3.Text = s2;
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{}

		// Function that converts the image in pictureBox1 to an
		// MPEG format image.  The number of frames to write to the
		// output file is specified by nPictures.
		public void WriteMPEGSequence()
		{
			int i;
			int j, k1, k2;
			long j2;
			byte tempByte;

			int ACSIZE = 1764;
			byte[] leftoverBits = new byte[10];
			byte[] DCbits = new byte[24];
			byte[] ACbits = new byte[ACSIZE];

			int DCY, DCCR, DCCB, lastDCY, lastDCCR, lastDCCB;
			int hblock, vblock;
			byte[,] Y = new byte[16,16];
			byte[,] CR = new byte[8,8];
			byte[,] CB = new byte[8,8];
			byte[,] block = new byte[8,8];
			double[,] S = new double[8,8];
			int[,] Q = new int[8,8];
			int[] ZZ = new int[64];
			long imageBytes = 0;
			long compressedBytes = 0;
			double compressPercent = 0.0;
			string mBox = null;
			long bitRate;

			MPEGFunctions MPEG = new MPEGFunctions();

			// Retrieve image from pictureBox1
			Bitmap img = new Bitmap(pictureBox1.Image);
			string fileName;
			imageBytes = img.Height * img.Width * 3;

			// Use SaveFile dialog to specify output file name
			SaveFileDialog dlg = new SaveFileDialog();
			if (dlg.ShowDialog() != DialogResult.OK)
				return;
			fileName = dlg.FileName;

            // Create output file and Memory Stream to write encoded image to
			BinaryWriter bw = new BinaryWriter(File.Create(fileName));
			MemoryStream ms = new MemoryStream();
			FileInfo info = new FileInfo(fileName);

			this.Cursor = Cursors.WaitCursor;

			//	Set up variables to encode image into MPEG frame
			lastDCY = 128;
			lastDCCR = lastDCCB = 128;
			for (i=0; i<10; i++)
				leftoverBits[i] = 255;
			for (i=0; i<24; i++)
				ACbits[i] = 255;
			for (i=0; i<24; i++)
				DCbits[i] = 255;

			outBytes = 20;

			// Write MPEG picture and slice headers to MemoryStream
			for (i=0; i<10; i++)
				MPEG.picHeaderBits[i+32] = (byte) ((0 & (int) Math.Pow (2,9-i)) >> (9-i));
			MPEG.writeToMS(leftoverBits, MPEG.picHeaderBits, ACbits, ref outBytes);
			MPEG.writeToMS(leftoverBits, MPEG.sliceHeaderBits, ACbits, ref outBytes);

			// Do this for each 16x16 pixel block in the bitmap file
			for (vblock=0; vblock<img.Height/16; vblock++)
				for (hblock=0; hblock<img.Width/16; hblock++)
				{
					//	Write 2 bits for Macroblock header to leftoverbits
					//	leftoverbits = '1', '1';
					MPEG.writeMbHeader(leftoverBits);

					//	Fill the Y[] array with a 16x16 block of RGB values
					Y = MPEG.getYMatrix(img, vblock, hblock);
					//	Fill the CR and CB arrays with 8x8 blocks by subsampling 
					//	the RGB array
					CR = MPEG.getCRMatrix(img, vblock, hblock);
					CB = MPEG.getCBMatrix(img, vblock, hblock);

					// First calculate DCTs for the 4 Y blocks
					for (k1=0; k1<2; k1++)
						for (k2=0; k2<2; k2++)
						{
							//	Put 8x8 Y blocks into the block[] array and
							//	then calculate the DCT and quantize the result
							for (i=0; i<8; i++)
								for (j=0; j<8; j++)
									block[i,j] = Y[(k1*8 + i),(k2*8 + j)];
							S = MPEG.calculateDCT(block);
							Q = MPEG.Quantize(S);

							//	Section to differentially Huffman encode DC values
							//	DC is the diffential value for the DC coefficient
							//	lastDC is the running total of the full magnitude
							//	Then send the DC value to DCHuffmanEncode
							for (i=0; i<24; i++)
								DCbits[i] = 255;
							DCY = Q[0,0] - lastDCY;
							lastDCY += DCY;
							DCbits = MPEG.DCHuffmanEncode(DCY, MPEG.DCLumCode, MPEG.DCLumSize);

							//	Section to encode AC Huffman values
							//	Put the AC coefficients into the ACarray[]
							//	in zigzag order, then Huffman encode the
							//	resulting array.
							for (i=0; i<ACSIZE; i++)
								ACbits[i] = 255;
							ZZ = MPEG.Zigzag(Q);
							ACbits = MPEG.ACHuffmanEncode(ZZ);

							//	Write the encoded bits to the MemoryStream
							MPEG.writeToMS(leftoverBits, DCbits, ACbits, ref outBytes);
						}

					// Now calculate the DCT for the CB array and quantize
					S = MPEG.calculateDCT(CB);
					Q = MPEG.Quantize(S);

					//	Encode DC value
					for (i=0; i<24; i++)
						DCbits[i] = 255;
					DCCB = Q[0,0] - lastDCCB;
					lastDCCB += DCCB;
					DCbits = MPEG.DCHuffmanEncode(DCCB, MPEG.DCChromCode, MPEG.DCChromSize);

					//	Encode AC values
					for (i=0; i<ACSIZE; i++)
						ACbits[i] = 255;
					ZZ = MPEG.Zigzag(Q);
					ACbits = MPEG.ACHuffmanEncode(ZZ);

					//	Write the encoded bits to the MemoryStream
					MPEG.writeToMS(leftoverBits, DCbits, ACbits, ref outBytes);

					// Now calculate the DCT for the CR array and quantize
					S = MPEG.calculateDCT(CR);
					Q = MPEG.Quantize(S);
					
					// Encode DC value
					for (i=0; i<24; i++)
						DCbits[i] = 255;
					DCCR = Q[0,0] - lastDCCR;
					lastDCCR += DCCR;
					DCbits = MPEG.DCHuffmanEncode(DCCR, MPEG.DCChromCode, MPEG.DCChromSize);

					//	Encode AC values
					for (i=0; i<ACSIZE; i++)
						ACbits[i] = 255;
					ZZ = MPEG.Zigzag(Q);
					ACbits = MPEG.ACHuffmanEncode(ZZ);

					//	Write the encoded bits to the MemoryStream
					MPEG.writeToMS(leftoverBits, DCbits, ACbits, ref outBytes);
				}

			// Write EOP bits to the MemoryStream
			MPEG.writeEOP(leftoverBits, MPEG.EOPBits);				
			outBytes++;

            //	Put memory stream (which contains the encoded image) into buffer
			ms = MPEG.getMS();
			byte[] buffer = new Byte[ms.Length];
			buffer = ms.ToArray();

			//	Set MPEG Sequence Header bits to correct image size
			j = 2048;
			for (i=0; i<12; i++)
			{
				MPEG.seqHeaderBits[i+32] = (byte) ((j&img.Width) >> (11-i));
				MPEG.seqHeaderBits[i+44] = (byte) ((j&img.Height) >> (11-i));
				j >>= 1;
			}

			//	Set MPEG Sequence Header bits to bitRate value
			bitRate = ms.Length * 30 * 8 / 400;
			j2 = 131072;
			for (i=0; i<18; i++)
			{
				MPEG.seqHeaderBits[i+64] = (byte) ((j2&bitRate) >> (17-i));
				j2 >>= 1;
			}

			//	Write MPEG Sequence header to file
			for (i=0; i<12; i++)
			{
				tempByte = 0;
				for (j=0; j<8; j++)
					tempByte = (byte) (tempByte*2 + MPEG.seqHeaderBits[i*8 + j]);
				bw.Write(tempByte);
			}
	
			//	Write MPEG GOP header to file
			for (i=0; i<8; i++)
			{
				tempByte = 0;
				for (j=0; j<8; j++)
					tempByte = (byte) (tempByte*2 + MPEG.GOPHeaderBits[i*8 + j]);
				bw.Write(tempByte);
			}

			//	Fix the picture header for each MPEG frame and write 
			//	the buffer to the file
			for (i=0; i<nPictures; i++)
			{
				for (j=0; j<10; j++)
					MPEG.picHeaderBits[j+32] = (byte) ((i & (int) Math.Pow (2,9-j)) >> (9-j));
				for (j=0; j<4; j++)
				{
					tempByte = 0;
					for (k1=0; k1<8; k1++)
						tempByte = (byte) (2*tempByte + MPEG.picHeaderBits[j*8 + k1]);
					buffer[j] = tempByte;
				}
				bw.Write(buffer);
			}

			// Write the End Of Sequence header
			bw.Write((byte) 0x00);
			bw.Write((byte) 0x00);
			bw.Write((byte) 0x01);
			bw.Write((byte) 0xb7);
			bw.Close();

			this.Cursor = Cursors.Arrow;

			// Calculate some output statistics
			outBytes += 4;
			compressedBytes = outBytes - 20 - 8 - 4;
			compressPercent = 100.0 - (double) (compressedBytes * 100.0 / imageBytes);

			if (nPictures == 1)
			{
				mBox = "Original image bytes (24 color bitmap): " + imageBytes.ToString() + "\n";
				mBox += "Compressed image bytes: " + compressedBytes.ToString() + "\n";
				mBox += "Compression Percentage: " + compressPercent.ToString();
			}
			else
			{
				mBox += "Input File Size: " + inputFileLength.ToString() + "\n";
				mBox += "Output File Size: " + info.Length.ToString() + "\n";
			}

			MessageBox.Show(mBox, "Compression Statistics");
		}

		public void WriteJPEG()
		{
			// Save Loaded Image as JPEG
			Bitmap img = new Bitmap(pictureBox1.Image);
			string fileName;

			SaveFileDialog dlg = new SaveFileDialog();
			if (dlg.ShowDialog() != DialogResult.OK)
				return;
			fileName = dlg.FileName;

			img.Save(fileName, ImageFormat.Jpeg);
		}
	}
}
