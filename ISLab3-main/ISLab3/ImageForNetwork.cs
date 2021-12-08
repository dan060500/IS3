using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ISLab3
{
	public class ImageForNetwork
	{
		public ImageForNetwork()
		{
			massOfImages = new Bitmap[10];
		    massOfImages[0] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/ZERO.png");
			massOfImages[1] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/ONE.png");
			massOfImages[2] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/TWO.png");
			massOfImages[3] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/THREE.png");
			massOfImages[4] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/FOUR.png");
			massOfImages[5] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/FIVE.png");
			massOfImages[6] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/SIX.png");
			massOfImages[7] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/SEVEN.png");
			massOfImages[8] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/EIGHT.png");
			massOfImages[9] = new Bitmap(Directory.GetCurrentDirectory() + "/numbers/NINE.png");

		}
		private Bitmap[] massOfImages;
		public Bitmap[] GetMassForStudy(int length)
		{
			Bitmap[] massForStudying = new Bitmap[length];
			for(int i = 0; i < length; i++)
			{
				massForStudying[i] = massOfImages[random.Next(0, 9)];
			}
			return massForStudying;
		}
		public Bitmap[] GetMassForText()
		{
			return massOfImages;
		}
		static Random random = new Random();
	}
}
