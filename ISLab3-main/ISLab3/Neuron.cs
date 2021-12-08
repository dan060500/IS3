using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISLab3
{
	public class Neuron
	{
		public Neuron(double[] _inputs, double[] _weights, NeuronType _type)
		{
			Weights = _weights;
			Inputs = _inputs;
			type = _type;
		}
		public NeuronType type;
		public double[] Inputs { get; set; }
		public double[] Weights { get; set; } 
		public double[] LastError { get; set; }
		public double Output;
		public double Derivative { get; set; }
		private double a = 0.0001d;
		//функция активации
		public void Activator(double[] inputs, double[] weights)
		{
			double sum = 0;
			for(int i = 0; i < inputs.Length; ++i)
			{
				//линейные преобразования 
				sum += inputs[i] * weights[i+1];
			}
			switch (type)
			{
				case NeuronType.Hidden://для нейронов скрытого слоя
					Output = LeakyReLU(sum);
					Derivative = LeakyReLU_Derivativator(sum);
					break;
				case NeuronType.Output://для нейронов выходного слоя
					Output = Math.Exp(sum);
					break;
			}

		}
		private double LeakyReLU(double sum) => (sum >= 0) ? sum : a * sum;
		private double LeakyReLU_Derivativator(double sum) => (sum >= 0) ? 1 : a;
	}
}
