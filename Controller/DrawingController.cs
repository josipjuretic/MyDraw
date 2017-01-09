using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Controller
{
    class DrawingController
    {
        public class ViewModel : IViewModel
        {
            public ViewModel(Drawing drawing)
            {
                Drawing = drawing;
                Selection = new Selection();
            }

            public Drawing Drawing
            {
                get; private set;
            }

            public Selection Selection
            {
                get; private set;
            }
        }

        public DrawingController(IDrawingView view, Model.Drawing drawing)
        {
            this.view = view;
            viewModel = new ViewModel(drawing);
            DelegateViewEvents();
        }

        public void SetViewMode(ViewMode mode)
        {
            this.mode = mode;
        }

        private void DelegateViewEvents()
        {
            view.MouseDown += OnMouseDown;
            view.MouseMove += OnMouseMove;
            view.MouseUp += OnMouseUp;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            IShape shape = new Model.Rectangle(e.Location);
            viewModel.Drawing.AddShape(shape);
            viewModel.Selection.AddShape(shape);
            view.Invalidate();
        }

        private IDrawingView view;
        private ViewMode mode = ViewMode.Insert;
        public readonly ViewModel viewModel;
    }
}
