using MathematicsAssistant.GUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public class MainTabViewModel : TabViewModelBase
    {
        #region Commands
        public ICommand CalculateTriangleCommand { get; private set; }
        private void onCalculateTriangleExecuted(Object parameter)
        {
            onRequestTab(new TriangleCalculationTabViewModel());
        }

        public ICommand MainCalcCommand { get; private set; }
        private void onMainCalcExecuted(Object parameter)
        {
            onRequestTab(new MainCalculatorTabViewModel());
        }
        #endregion

        #region Constructor
        public MainTabViewModel()
        {
            base.Name = "MainTab";
            CalculateTriangleCommand = new RelayCommand(onCalculateTriangleExecuted);
            MainCalcCommand = new RelayCommand(onMainCalcExecuted);
        }
        #endregion
    }
}
