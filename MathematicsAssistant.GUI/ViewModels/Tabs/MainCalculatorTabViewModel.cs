using MathematicsAssistant.Business;
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

        private String m_Solution;
        public String Solution
        {
            get { return m_Solution; }
            set
            {
                if (m_Solution != value)
                {
                    m_Solution = value;
                    onPropertyChanged("Solution");
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

        public ICommand SolutionCommand { get; private set; }
        private void onSolutionCommandExecuted(Object parameter)
        {
            Calculation TaskCalculation = new Calculation(Task);
            Solution = TaskCalculation.Solution;
        }


        #endregion

        #region Constructor
        public MainCalculatorTabViewModel()
        {
            base.Name = "Main Calculator";
            InputCommand = new RelayCommand(onInputCommandExecuted);
            SolutionCommand = new RelayCommand(onSolutionCommandExecuted);
        }
        #endregion
    }
}
