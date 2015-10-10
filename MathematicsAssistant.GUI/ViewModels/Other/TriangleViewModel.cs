using MathematicsAssistant.Business;
using MathematicsAssistant.GUI.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public class TriangleViewModel : ViewModelBase
    {

        private Double m_ax;
        public Double Ax
        {
            get { return m_ax; }
            set
            {
                if (m_ax != value)
                {
                    m_ax = value;
                    onPropertyChanged("Ax");
                }
            }
        }


        private Double m_ay;
        public Double Ay
        {
            get { return m_ay; }
            set
            {
                if (m_ay != value)
                {
                    m_ay = value;
                    onPropertyChanged("Ay");
                }
            }
        }


        private Double m_bx;
        public Double Bx
        {
            get { return m_bx; }
            set
            {
                if (m_bx != value)
                {
                    m_bx = value;
                    onPropertyChanged("Bx");
                }
            }
        }


        private Double m_by;
        public Double By
        {
            get { return m_by; }
            set
            {
                if (m_by != value)
                {
                    m_by = value;
                    onPropertyChanged("By");
                }
            }
        }


        private Double m_cx;
        public Double Cx
        {
            get { return m_cx; }
            set
            {
                if (m_cx != value)
                {
                    m_cx = value;
                    onPropertyChanged("Cx");
                }
            }
        }


        private Double m_cy;
        public Double Cy
        {
            get { return m_cy; }
            set
            {
                if (m_cy != value)
                {
                    m_cy = value;
                    onPropertyChanged("Cy");
                }
            }
        }


        private Double m_sideA;
        public Double SideA
        {
            get { return m_sideA; }
            set
            {
                if (m_sideA != value)
                {
                    m_sideA = value;
                    onPropertyChanged("SideA");
                }
            }
        }


        private Double m_sideB;
        public Double SideB
        {
            get { return m_sideB; }
            set
            {
                if (m_sideB != value)
                {
                    m_sideB = value;
                    onPropertyChanged("SideB");
                }
            }
        }


        private Double m_sideC;
        public Double SideC
        {
            get { return m_sideC; }
            set
            {
                if (m_sideC != value)
                {
                    m_sideC = value;
                    onPropertyChanged("SideC");
                }
            }
        }


        private Double m_range;
        public Double Range
        {
            get { return m_range; }
            set
            {
                if (m_range != value)
                {
                    m_range = value;
                    onPropertyChanged("Range");
                }
            }
        }


        private Double m_alpha;
        public Double Alpha
        {
            get { return m_alpha; }
            set
            {
                if (m_alpha != value)
                {
                    m_alpha = value;
                    onPropertyChanged("Alpha");
                }
            }
        }


        private Double m_betha;
        public Double Betha
        {
            get { return m_betha; }
            set
            {
                if (m_betha != value)
                {
                    m_betha = value;
                    onPropertyChanged("Betha");
                }
            }
        }


        private Double m_gamma;
        public Double Gamma
        {
            get { return m_gamma; }
            set
            {
                if (m_gamma != value)
                {
                    m_gamma = value;
                    onPropertyChanged("Gamma");
                }
            }
        }

        

        public TriangleModel GetModel()
        {
            TriangleModel triangle = new TriangleModel(m_ax, m_ay, m_bx, m_by, m_cx, m_cy);
            return triangle;
        }
    }
}
