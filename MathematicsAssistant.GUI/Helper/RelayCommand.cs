using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.Helper
{
    public class RelayCommand : ICommand
    {
        private Action<Object> m_executeHandler;
        private Func<Object, Boolean> m_canExecuteHandler;

        #region Constructor

        public RelayCommand(Action<Object> executeHandler, Func<Object, Boolean> canExecuteHandler)
        {
            m_executeHandler = executeHandler;
            m_canExecuteHandler = canExecuteHandler; 
        }

        public RelayCommand(Action<Object> executeHandler) : this(executeHandler, null)
        {

        }

        #endregion

        public bool CanExecute(object parameter)
        {
            if (m_canExecuteHandler == null)
            {
                return true;
            }
            return m_canExecuteHandler.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            m_executeHandler.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
