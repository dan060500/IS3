using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISLab3
{
	public class NetworkAnswer
	{
		public NetworkAnswer(double[] matrix)
		{
			mass = matrix;
		}
		private double[] mass;

		public int GotAnswer(double[] massive)
		{
			if (One()) return 1;
			if (Two()) return 2;
			if (Three()) return 3;
			if (Four()) return 4;
			if (Five()) return 5;
			if (Six()) return 6;
			if (Seven()) return 7;
			if (Eight()) return 8;
			if (Nine()) return 9;
			if (Zero()) return 0;
			return new int();
		}
		private bool One()
		{
			if (mass[2] == 1 &&
			    mass[6] == 1 &&
				mass[7] == 1 &&
				mass[12] == 1 &&
				mass[17] == 1 &&
				mass[22] == 1 &&
				mass[27] == 1 &&
				mass[31] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1) { return true; } 
					else return false;
		}
		private bool Two()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[14] == 1 &&
				mass[18] == 1 &&
				mass[22] == 1 &&
				mass[21] == 1 &&
				mass[25] == 1 &&
				mass[30] == 1 &&
				mass[31] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1 &&
				mass[34] == 1) { return true; }
			else return false;
		}
		private bool Three()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[14] == 1 &&
				mass[17] == 1 &&
				mass[18] == 1 &&
				mass[24] == 1 &&
				mass[29] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1 &&
				mass[31] == 1 &&
				mass[25] == 1 &&
				mass[16] != 1) { return true; }
			else return false;
		}
		private bool Four()
		{
			if (mass[2] == 1 &&
				mass[3] == 1 &&
				mass[6] == 1 &&
				mass[8] == 1 &&
				mass[10] == 1 &&
				mass[13] == 1 &&
				mass[15] == 1 &&
				mass[18] == 1 &&
				mass[20] == 1 &&
				mass[23] == 1 &&
				mass[21] == 1 &&
				mass[22] == 1 &&
				mass[24] == 1 &&
				mass[28] == 1 &&
				mass[33] == 1) { return true; }
			else return false;
		}
		private bool Five()
		{
			if (mass[0] == 1 &&
				mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[4] == 1 &&
				mass[5] == 1 &&
				mass[10] == 1 &&
				mass[11] == 1 &&
				mass[12] == 1 &&
				mass[13] == 1 &&
				mass[19] == 1 &&
				mass[24] == 1 &&
				mass[29] == 1 &&
				mass[33] == 1 &&
				mass[32] == 1 &&
				mass[31] == 1 &&
				mass[25] == 1) { return true; }
			else return false;
		}
		private bool Six()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[10] == 1 &&
				mass[15] == 1 &&
				mass[16] == 1 &&
				mass[17] == 1 &&
				mass[18] == 1 &&
				mass[20] == 1 &&
				mass[24] == 1 &&
				mass[25] == 1 &&
				mass[29] == 1 &&
				mass[31] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1) { return true; }
			else return false;
		}
		private bool Seven()
		{
			if (mass[0] == 1 &&
				mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[4] == 1 &&
				mass[9] == 1 &&
				mass[13] == 1 &&
				mass[17] == 1 &&
				mass[21] == 1 &&
				mass[26] == 1 &&
				mass[31] == 1) { return true; }
			else return false;
		}
		private bool Eight()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[10] == 1 &&
				mass[14] == 1 &&
				mass[16] == 1 &&
				mass[17] == 1 &&
				mass[18] == 1 &&
				mass[20] == 1 &&
				mass[25] == 1 &&
				mass[24] == 1 &&
				mass[29] == 1 &&
				mass[31] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1) { return true; }
			else return false;
		}
		private bool Nine()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[10] == 1 &&
				mass[14] == 1 &&
				mass[16] == 1 &&
				mass[17] == 1 &&
				mass[18] == 1 &&
				mass[19] == 1 &&
				mass[24] == 1 &&
				mass[29] == 1 &&
				mass[33] == 1 &&
				mass[32] == 1 &&
				mass[31] == 1 &&
				mass[25] == 1 ) { return true; }
			else return false;
		}
		private bool Zero()
		{
			if (mass[1] == 1 &&
				mass[2] == 1 &&
				mass[3] == 1 &&
				mass[5] == 1 &&
				mass[9] == 1 &&
				mass[10] == 1 &&
				mass[15] == 1 &&
				mass[20] == 1 &&
				mass[25] == 1 &&
				mass[14] == 1 &&
				mass[19] == 1 &&
				mass[24] == 1 &&
				mass[29] == 1 &&
				mass[31] == 1 &&
				mass[32] == 1 &&
				mass[33] == 1) { return true; }
			else return false;
		}
	}
}
