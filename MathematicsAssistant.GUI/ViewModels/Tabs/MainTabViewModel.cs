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

        public ICommand CalculateTriangleCommand { get; private set; }
        private void onCalculateTriangleExecuted(Object parameter)
        {
            onRequestTab(new TriangleCalculationTabViewModel());
        }

        public MainTabViewModel()
        {
            base.Name = "MainTab";
            CalculateTriangleCommand = new RelayCommand(onCalculateTriangleExecuted);
        }

    }
}
