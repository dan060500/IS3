using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ISLab3
{
	abstract public class Layer
    {//type используется для связи с одноимённым полю слоя файлом памяти
        protected Layer(int non, int nopn, NeuronType nt, string type)
        {//увидите это в WeightInitialize
            numofneurons = non;
            numofprevneurons = nopn;
            Neurons = new Neuron[non];
            double[,] Weights = WeightInitialize(MemoryMode.GET, type);
            lastdeltaweights = Weights;
            for (int i = 0; i < non; ++i)
            {
                double[] temp_weights = new double[nopn + 1];
                for (int j = 0; j < nopn + 1; ++j)
                    temp_weights[j] = Weights[i, j];
                Neurons[i] = new Neuron(null, temp_weights, nt);//про подачу null на входы ниже
            }
        }
        protected int numofneurons;//число нейронов текущего слоя
        protected int numofprevneurons;//число нейронов предыдущего слоя
        protected const double learningrate = 0.005d;//скорость обучения
        protected const double momentum = 0.03d;//момент инерции
        protected double[,] lastdeltaweights;//веса предыдущей итерации обучения
        Neuron[] _neurons;//массив нейронов текущего слоя
        public Neuron[] Neurons { get => _neurons; set => _neurons = value; }
        public double[] Data//я подал null на входы нейронов, так как
        {//сначала нужно будет преобразовать информацию
            set//(видео, изображения, etc.)
            {//а загружать input'ы нейронов слоя надо не сразу,
                for (int i = 0; i < Neurons.Length; ++i)
                {
                    Neurons[i].Inputs = value;
                    Neurons[i].Activator(Neurons[i].Inputs, Neurons[i].Weights);
                }
            }//а только после вычисления выходов предыдущего слоя
        }
        public double[,] WeightInitialize(MemoryMode mm, string type)
        {
            double[,] _weights = new double[numofneurons, numofprevneurons + 1];
            XmlDocument memory_doc = new XmlDocument();
            memory_doc.Load(Directory.GetCurrentDirectory() + $"/{type}_memory.xml");
            XmlElement memory_el = memory_doc.DocumentElement;
            string str = memory_el.Name;
            switch (mm)
            {
                case MemoryMode.GET:
                    for (int l = 0; l < _weights.GetLength(0); ++l)
                        for (int k = 0; k < _weights.GetLength(1); ++k)
                            _weights[l, k] = double.Parse(memory_el.ChildNodes.Item(k + _weights.GetLength(1)).InnerText.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);//parsing stuff
                    break;
                case MemoryMode.SET:
                    for (int l = 0; l < numofneurons; ++l)
                        for (int k = 0; k < numofprevneurons + 1; ++k)
						{
                            
                            memory_el.ChildNodes.Item(k + (numofprevneurons + 1) * l).InnerText = Neurons[l].Weights[k].ToString();

                        }
                    break;
            }
            memory_doc.Save(System.IO.Path.Combine(Directory.GetCurrentDirectory() + $"{type}_memory.xml"));
            return _weights;
        }
        abstract public void Recognize(Network net, Layer nextLayer);//для прямых проходов
        abstract public double[] BackwardPass(double[] stuff);//и обратных
    }
}

