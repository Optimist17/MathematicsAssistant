using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.GUI.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged(String property)
        {
            if (PropertyChanged == null) return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }       
    }
}
