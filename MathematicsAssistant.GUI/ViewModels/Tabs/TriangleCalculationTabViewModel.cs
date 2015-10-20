using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MathematicsAssistant.Business;
using MathematicsAssistant.GUI.Helper;

namespace MathematicsAssistant.GUI.ViewModels
{
    public class TriangleCalculationTabViewModel : TabViewModelBase
    {

        public TriangleViewModel Triangle { get; private set; }

        #region Commands
        public ICommand CalculateCommand { get; private set; }
        private void onCalculateExecuted(Object parameter)
        {
            TriangleManager manager = new TriangleManager();
            TriangleModel triangle = manager.AddTriangle(Triangle.Ax, Triangle.Ay, Triangle.Bx, Triangle.By, Triangle.Cx, Triangle.Cy);
            Triangle.Ax = triangle.Ax;
            Triangle.Ay = triangle.Ay;
            Triangle.Alpha = triangle.Alpha;
            Triangle.Betha = triangle.Betha;
            Triangle.Bx = triangle.Bx;
            Triangle.By = triangle.By;
            Triangle.Cx = triangle.Cx;
            Triangle.Cy = triangle.Cy;
            Triangle.Gamma = triangle.Gamma;
            Triangle.Range = triangle.Range;
            Triangle.SideA = triangle.SideA;
            Triangle.SideB = triangle.SideB;
            Triangle.SideC = triangle.SideC;
        }
        #endregion

        #region Constructor
        public TriangleCalculationTabViewModel()
        {
            Triangle = new TriangleViewModel();
            base.Name = "TriangleCalculation";
            CalculateCommand = new RelayCommand(onCalculateExecuted);
        }
        #endregion
    }
}
