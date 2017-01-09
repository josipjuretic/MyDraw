using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public interface IViewModel
    {
        Model.Drawing Drawing { get; }
        Selection Selection { get; }
    }
}
