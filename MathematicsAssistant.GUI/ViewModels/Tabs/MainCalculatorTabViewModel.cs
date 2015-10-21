using MathematicsAssistant.GUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public class MainCalculatorTabViewModel : TabViewModelBase
    {

        #region Properties

        private String m_Task;
        public String Task
        {
            get { return m_Task; }
            set
            {
                if (m_Task != value)
                {
                    m_Task = value;
                    onPropertyChanged("Task");
                }
            }
        }

        #endregion

        #region Commands

        public ICommand InputCommand { get; private set; }
        private void onInputCommandExecuted(Object parameter)
        {
            String Input = (String)parameter;
            Task = m_Task + Input;
        }

        #endregion

        #region Constructor
        public MainCalculatorTabViewModel()
        {
            base.Name = "Main Calculator";
            InputCommand = new RelayCommand(onInputCommandExecuted);
        }
        #endregion
    }
}
