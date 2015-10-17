using MathematicsAssistant.GUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public enum DialogResults
    {
        NotSet,
        Yes,
        No,
        Maybe,
        Cancel,
        Okay,
        Other,
    }

    public class DialogViewModelBase : ViewModelBase
    {

        #region Properties


        private String m_Title;
        public String Title
        {
            get { return m_Title; }
            set
            {
                if (m_Title != value)
                {
                    m_Title = value;
                    onPropertyChanged("Title");
                }
            }
        }


        private DialogResults m_Result;
        public DialogResults Result
        {
            get { return m_Result; }
            set
            {
                if (m_Result != value)
                {
                    m_Result = value;
                    onPropertyChanged("Result");
                    onRequestClose();
                }
            }
        }

        #endregion

        #region Commands

        public ICommand SetResultCommand { get; private set; }
        private void onSetResultExecuted(Object parameter)
        {
            DialogResults result = (DialogResults)parameter;
            Result = result;
        }
        protected virtual Boolean onSetResultCanExecute(object parameter)
        {
            return true;
        }

        #endregion

        #region Events

        public event EventHandler RequestClose;

        protected void onRequestClose()
        {
            if (RequestClose == null) return;
            RequestClose.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Constructor

        public DialogViewModelBase(String title)
        {

            Title = title;
            SetResultCommand = new RelayCommand(onSetResultExecuted, onSetResultCanExecute);
            m_Result = DialogResults.NotSet;

        }

        #endregion

    }
}
