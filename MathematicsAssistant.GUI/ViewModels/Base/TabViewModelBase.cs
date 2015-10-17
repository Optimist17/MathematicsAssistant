using MathematicsAssistant.GUI.Events;
using MathematicsAssistant.GUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public abstract class TabViewModelBase : ViewModelBase
    {

        #region Properties
        private String m_Name;

        public String Name
        {
            get { return m_Name; }
            set
            {
                if (m_Name != value)
                {
                    m_Name = value;
                    onPropertyChanged("Name");
                }
            }
        }

        public Boolean IsClosable;
        #endregion

        #region Events

        public event EventHandler RequestClose;
        protected void onRequestClose()
        {
            if (RequestClose == null) return;
            RequestClose.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<RequestTabEventArgs> RequestTab;
        protected void onRequestTab(TabViewModelBase tabToOpen)
        {
            if (RequestTab == null) return;
            RequestTab.Invoke(this, new RequestTabEventArgs(tabToOpen));
        }

        #endregion

        #region Command

        public ICommand RequestCloseCommand { get; private set; }
        private void onRequestCloseExecuted(object parameter)
        {
            onRequestClose();
        }

        #endregion

        #region Constructor

        public TabViewModelBase()
        {
            Name = m_Name;
            RequestCloseCommand = new RelayCommand(onRequestCloseExecuted);
        }

        #endregion
    }
}
