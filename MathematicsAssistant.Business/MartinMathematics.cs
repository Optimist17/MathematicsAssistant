using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.Business
{
    #region Triangle

    public class TriangleModel
    {
        public Double Ax { get; private set; }
        public Double Ay { get; private set; }
        public Double Bx { get; private set; }
        public Double By { get; private set; }
        public Double Cx { get; private set; }
        public Double Cy { get; private set; }

        public Double SideA { get; private set; }
        public Double SideB { get; private set; }
        public Double SideC { get; private set; }

        public Double Range { get; private set; }

        public Double Alpha { get; private set; }
        public Double Betha { get; private set; }
        public Double Gamma { get; private set; }

        public TriangleModel(Double ax, Double ay, Double bx, Double by, Double cx, Double cy)
        {
            Ax = ax;
            Ay = ay;
            Bx = bx;
            By = by;
            Cx = cx;
            Cy = cy;

            Double a1xA;
            if (bx >= cx)
            {
                a1xA = bx - cx;
            }
            else
            {
                a1xA = cx - bx;
            }

            Double a2yA;
            if (by >= cy)
            {
                a2yA = by - cy;
            }
            else
            {
                a2yA = cy - by;
            }

            Double b1xA;
            if (ax >= cx)
            {
                b1xA = ax - cx;
            }
            else
            {
                b1xA = cx - ax;
            }

            Double b2yA;
            if (ay >= cy)
            {
                b2yA = ay - cy;
            }
            else
            {
                b2yA = cy - ay;
            }

            Double c1xA;
            if (ax >= bx)
            {
                c1xA = ax - bx;
            }
            else
            {
                c1xA = bx - ax;
            }

            Double c2yA;
            if (ay >= by)
            {
                c2yA = ay - by;
            }
            else
            {
                c2yA = by - ay;
            }


            Double a1xAPow = a1xA * a1xA;
            Double a2yAPow = a2yA * a2yA;
            Double a1a2Sum = a1xAPow + a2yAPow;
            SideA = Math.Sqrt(a1a2Sum);

            Double b1xAPow = b1xA * b1xA;
            Double b2yAPow = b2yA * b2yA;
            Double b1b2Sum = b1xAPow + b2yAPow;
            SideB = Math.Sqrt(b1b2Sum);

            Double c1xAPow = c1xA * c1xA;
            Double c2yAPow = c2yA * c2yA;
            Double c1c2Sum = c1xAPow + c2yAPow;
            SideC = Math.Sqrt(c1c2Sum);

            Range = SideA + SideB + SideC;

            Double Alpha1 = (SideA * SideA - SideB * SideB - SideC * SideC) / (-2 * SideB * SideC);
            Double Alpha2 = Math.Acos(Alpha1);
            Alpha = Math.Round((360 * Alpha2) / (2 * Math.PI), 2);

            Double Betha1 = (SideB * SideB - SideA * SideA - SideC * SideC) / (-2 * SideA * SideC);
            Double Betha2 = Math.Acos(Betha1);
            Betha = Math.Round((360 * Betha2) / (2 * Math.PI),2);

            Double Gamma1 = (SideC * SideC - SideA * SideA - SideB * SideB) / (-2 * SideA * SideB);
            Double Gamma2 = Math.Acos(Gamma1);
            Gamma = Math.Round((360 * Gamma2) / (2 * Math.PI), 2);
        }       
    }

    #endregion
}
