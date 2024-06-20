using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using BitmapImage;

namespace MPEGBuilder1UI
{
	/// <summary>
	/// Summary description for DCEncodeDialog.
	/// </summary>
	public class DCEncodeDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		MPEGFunctions MPEG = new MPEGFunctions();
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private byte[] DCbits = new byte[24];

		public DCEncodeDialog()
		{
			InitializeComponent();
		}

		public DCEncodeDialog(int DC)
		{
			//	On initialize, calculate DC Luminance for (DC-128)
			InitializeComponent();
			textBox2.Text = DC.ToString();
			textBox1.Text = "128";
			radioButton1.Checked = true;

			DCbits = MPEG.DCHuffmanEncode((DC-128), MPEG.DCLumCode, MPEG.DCLumSize);
			FillListBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Previous DC Value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current DC Value";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "minus";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "equals";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(16, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "DC Luminance";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(16, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "DC Chrominance";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Component Select";
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(336, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 134);
            this.listBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Encoded Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Recalculate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Bits";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Percent Compression";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(400, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "textBox4";
            // 
            // DCEncodeDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::MPEGBuilder1UI.Properties.Resources.purple_beautiful_violet_background;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DCEncodeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCEncodeDialog";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void FillListBox()
		{
			// Write DC bits array in byte form and put in list box
			int i, j;
			int tempint;
			int nbytes, nremainder;
			int nbits;
			double compress;

			listBox1.Items.Clear();

			i=0;
			while (DCbits[i] != 255)
				i++;

			nbytes = i/8;
			nremainder = i%8;
			nbits = i;

			if (nbytes > 0)
				listBox1.Items.Add("Bytes:");
			for (i=0; i<nbytes; i++)
			{
				tempint = 0;
				for (j=0; j<8; j++)
				{
					tempint = tempint*2 + DCbits[i*8 + j];
				}
				listBox1.Items.Add("0x" + tempint.ToString("X2"));
			}
			
			if (nremainder>0)
				listBox1.Items.Add("Leftover Bits:");
			for (i=nbytes*8; i<(nbytes*8)+nremainder; i++)
				listBox1.Items.Add(DCbits[i].ToString());

			textBox3.Text = nbits.ToString();
			compress = 100.0 - (double) nbits / 9.0 * 100.0;
			textBox4.Text = compress.ToString("f");
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			//	Calculate DC Luminance
			int DC, prevDC;

			DC = Convert.ToInt16(textBox2.Text.ToString());
			prevDC = Convert.ToInt16(textBox1.Text.ToString());
			DCbits = MPEG.DCHuffmanEncode((DC-prevDC), MPEG.DCLumCode, MPEG.DCLumSize);
			FillListBox();
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			//	Calculate DC Chrominance
			int DC, prevDC;

			DC = Convert.ToInt16(textBox2.Text.ToString());
			prevDC = Convert.ToInt16(textBox1.Text.ToString());
			DCbits = MPEG.DCHuffmanEncode((DC-prevDC), MPEG.DCChromCode, MPEG.DCChromSize);
			FillListBox();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//	Recalculate Function
			int DC, prevDC;

			DC = Convert.ToInt16(textBox2.Text.ToString());
			prevDC = Convert.ToInt16(textBox1.Text.ToString());
			if (radioButton1.Checked == true)
                DCbits = MPEG.DCHuffmanEncode((DC-prevDC), MPEG.DCLumCode, MPEG.DCLumSize);
			else
				DCbits = MPEG.DCHuffmanEncode((DC-prevDC), MPEG.DCChromCode, MPEG.DCChromSize);

			FillListBox();
		}
	}
}
