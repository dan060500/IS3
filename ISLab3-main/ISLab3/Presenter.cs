using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLab3
{
	class Presenter
	{
        private Network _net;
        private Form1 _view;

        public Presenter(Network model, Form1 view)
        {
            _net = model;
            _view = view;
            _view.GotResult += new EventHandler<EventArgs>(OnGotResult);
        }

        private void OnGotResult(object sender, EventArgs e)
        {
            _net.ForwardPass(_net, _view.InputPixels);
            UpdateView();
        }

        private void UpdateView() => _view.NetOutput = _net.fact;
    }
}
