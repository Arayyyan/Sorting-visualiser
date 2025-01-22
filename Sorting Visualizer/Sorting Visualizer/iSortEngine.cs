using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Sorting_Visualizer
{
    interface iSortEngine
    {
        void NextStep();
        bool isSorted();
        void ReDraw();

    }
}
