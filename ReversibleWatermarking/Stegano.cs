using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anu.Header.BMP;
using System.IO;

namespace Firewall
{
    
	/// <summary>
	/// This class enables you to hide a test message inside a BMP and retrive it too.
	/// </summary>
	public class Stegano
	{
		public Stegano()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region HideMessage Function
		/// <summary>
		///  This function enabels you to hide a message insider a BMP
		/// </summary>
		/// <param name="inputPath">input BMP path</param>
		/// <param name="outputPath">output BMP path</param>
		/// <param name="message">message to hide</param>
		public void HideMessage(string inputPath,string outputPath,string message)
		{
            try
            {
			int readByte;
			int count=14;
			BMP bitmap=new BMP(inputPath);
            FileStream br;
            BinaryWriter bw;

			bitmap.BitmapFileHeader.bfOffBits+=(message.Length+1);
			bitmap.BitmapFileHeader.bfSize+=(message.Length+1);

           
            br = new FileStream(inputPath, FileMode.Open, FileAccess.ReadWrite);
            bw = new BinaryWriter(File.OpenWrite(outputPath));
           
            

			bitmap.WriteBMPFileHeader(bw);
			br.Seek(14,SeekOrigin.Begin);
			
			while(count<(bitmap.BitmapFileHeader.bfOffBits-(message.Length+1)))
			{
				bw.Write((byte)br.ReadByte());
				count++;
			}
			for(int i=0;i<message.Length;i++)
			{
				bw.Write(message[i]);
			}
			bw.Write(Convert.ToByte(message.Length));
			
			while((readByte=br.ReadByte())>=0)
			{
				bw.Write((byte)readByte);
			}
			bw.Close();
			br.Close();
            }
            catch (Exception ex)
            {

            }
            
		}
		#endregion

		#region RetriveMessage Function
		/// <summary>
		///  Retrives a hidden message from a BMP
		/// </summary>
		/// <param name="path">path of BMP</param>
		/// <returns>the hidden message</returns>
		public string RetriveMessage(string path)
		{
			int length;
			StringBuilder message=new StringBuilder();
			BinaryReader br=new BinaryReader(File.OpenRead(path));
			BMP bitmap=new BMP(path);
			br.BaseStream.Seek(bitmap.BitmapFileHeader.bfOffBits-1,SeekOrigin.Begin);
			length=(int)br.ReadByte();
			
            br.BaseStream.Seek(-(length+1),SeekOrigin.Current);
		    message.Append(br.ReadChars(length));
			br.Close();

			return message.ToString();
		}
		#endregion
	}
}
    

