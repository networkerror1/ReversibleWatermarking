using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MPEGBuilder1
{
	/// <summary>
	/// Summary description for FrameNumberDialog.
	/// </summary>
	public class FrameNumberDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private IContainer components;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		public int numberOfFrames = 10;

		public FrameNumberDialog()
		{
			InitializeComponent();

			textBox1.Text = numberOfFrames.ToString();
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(104, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Number Of Frames (Max=100)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "textBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataMember = "";
            // 
            // FrameNumberDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::ReversibleDataHiding.Properties.Resources._970993_colorful_smoke_on_white_background;
            this.ClientSize = new System.Drawing.Size(216, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrameNumberDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrameNumberDialog";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Set up error provider to test input
			// Valid input range is 1 to 100
			bool allValid = true;
			if ((Convert.ToInt16(textBox1.Text) < 1) ||
					(Convert.ToInt16(textBox1.Text) > 100))
				{
					errorProvider1.SetError(textBox1, textBox1.Tag + " Valid Input Range is 1 to 100");
					allValid = false;
				}

			if (allValid)
			{
				numberOfFrames = Convert.ToInt16(textBox1.Text);
				this.Close();
			}
			else
				MessageBox.Show("Input Range is 1 to 100", "Error");
		}
	}
}
