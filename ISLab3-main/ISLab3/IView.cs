using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLab3
{
	public class IView:Form
	{
		public double[] InputPixels { get; }
		public double[] NetOutput { get; set; }
		public event EventHandler<EventArgs> GotResult;
	}
}
