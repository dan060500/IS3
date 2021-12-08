using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ISLab3
{
	class InputLayer
	{
        public InputLayer(NetworkMode nm)
        {
            System.Drawing.Bitmap[] massOfBitmap = new Bitmap[100];
            switch (nm)
            {
                case NetworkMode.Train:
                    ImageForNetwork images = new ImageForNetwork();
                    massOfBitmap = images.GetMassForStudy(100);
                    for(int i = 0; i < massOfBitmap.Length; i++)
					{
                        _trainset[i] = new double[35];
					}
                    for(int k = 0; k < massOfBitmap.Length; k++)
					{
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if(massOfBitmap[k].GetPixel(i,j) == Color.White)
								{
                                    _trainset[k][ i * 5 + j] = 0d;
								}
								else
								{
                                    _trainset[k][ i * 5 + j] = 1d;

                                }
                            }
                        }
                    }
                    break;
                case NetworkMode.Test:
                    ImageForNetwork imagess = new ImageForNetwork();
                    massOfBitmap = imagess.GetMassForStudy(10);
                    for (int i = 0; i < massOfBitmap.Length; i++)
                    {
                        _testset[i] = new double[35];
                    }
                    for (int k = 0; k < massOfBitmap.Length; k++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (massOfBitmap[k].GetPixel(i, j) == Color.White)
                                {
                                    _testset[k][ i * 5 + j] = 0d;
                                }
                                else
                                {
                                    _testset[k][ i * 5 + j] = 1d;

                                }
                            }
                        }
                    }
                    break;
            }
        }

        private System.Random random = new System.Random();

        private double[][] _trainset = new double[100][];//100 изображений в обучающей выборке
        public double[][]Trainset { get => _trainset;  }

        public double[][] _testset = new double[10][];//10 изображений в тестовой выборке
        public double[][] Testset { get => _testset; }
    }
}
