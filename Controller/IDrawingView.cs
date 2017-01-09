using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Controller
{
    interface IDrawingView
    {
        event MouseEventHandler MouseDown;
        event MouseEventHandler MouseMove;
        event MouseEventHandler MouseUp;

        void SetViewModel(IViewModel viewModel);
        void Invalidate();
    }
}
