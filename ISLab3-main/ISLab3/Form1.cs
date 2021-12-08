using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ISLab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < InputPixels.Length; i++) InputPixels[i] = 0d;
		}
		public double[] NetOutput 
		{
			set => MessageBox.Show(value.ToList().IndexOf(value.Max()).ToString()); 
		}

		public event EventHandler<EventArgs> GotResult;

		public double[] InputPixels = new double[35];
		private void ChangeColor(PictureBox pictureBox, int index)
		{
			if(pictureBox.BackColor == Color.Black)
			{
				pictureBox.BackColor = Color.White;
				InputPixels[index] = 0d;
			}
			else
			{
				pictureBox.BackColor = Color.Black;
				InputPixels[index] = 1d;
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox1, 0);
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox2, 1);
		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox3, 2);
		}
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox4, 3);
		}
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox5, 4);
		}
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox6, 5);
		}
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox7, 6);
		}
		private void pictureBox8_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox8, 7);
		}
		private void pictureBox9_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox9, 8);
		}
		private void pictureBox10_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox10, 9);
		}
		private void pictureBox11_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox11, 10);
		}
		private void pictureBox12_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox12, 11);
		}
		private void pictureBox13_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox13, 12);
		}
		private void pictureBox14_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox14, 13);
		}
		private void pictureBox15_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox15, 14);
		}
		private void pictureBox16_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox16, 15);
		}
		private void pictureBox17_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox17, 16);
		}
		private void pictureBox18_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox18, 17);
		}
		private void pictureBox19_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox19, 18);
		}
		private void pictureBox20_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox20, 19);
		}
		private void pictureBox21_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox21, 20);
		}
		private void pictureBox22_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox22, 21);
		}
		private void pictureBox23_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox23, 22);
		}
		private void pictureBox24_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox24, 23);
		}
		private void pictureBox25_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox25, 24);
		}
		private void pictureBox26_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox26, 25);
		}
		private void pictureBox27_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox27, 26);
		}
		private void pictureBox28_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox28, 27);
		}
		private void pictureBox29_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox29, 28);
		}
		private void pictureBox30_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox30, 29);
		}
		private void pictureBox31_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox31, 30);
		}
		private void pictureBox32_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox32, 31);
		}
		private void pictureBox33_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox33, 32);
		}
		private void pictureBox34_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox34, 33);
		}
		private void pictureBox35_Click(object sender, EventArgs e)
		{
			ChangeColor(pictureBox35, 34);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Network network = new Network(NetworkMode.Train);
			Presenter presenter = new Presenter(network, this);
			network.Train(network);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Network network = new Network(NetworkMode.Test);
			//Presenter presenter = new Presenter(network, this);
			//GotResult?.Invoke(this, EventArgs.Empty);
			trueAns();
		}
		
		private void trueAns()
		{
			NetworkAnswer ans = new NetworkAnswer(InputPixels);
			MessageBox.Show(ans.GotAnswer(InputPixels).ToString());
		}
		
	}
}
