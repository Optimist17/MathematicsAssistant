using MathematicsAssistant.GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.GUI.Events
{
    public class RequestTabEventArgs : EventArgs
    {
        public TabViewModelBase TabToOpen { get; private set; }

        public RequestTabEventArgs(TabViewModelBase tab)
        {
            TabToOpen = tab;
        }
    }
}
