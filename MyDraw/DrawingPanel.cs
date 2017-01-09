using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace MyDraw
{
    public partial class DrawingPanel : Panel, Controller.IDrawingView
    {
        public DrawingPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (viewModel == null)
                return;
            base.OnPaint(pe);
        }

        public void SetViewModel(IViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        IViewModel viewModel;
    }
}
