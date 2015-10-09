using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.Business
{
    public class TriangleManager
    {
        private static List<TriangleModel> m_Triangles;

        static TriangleManager()
        {
            m_Triangles = new List<TriangleModel>();
        }

        public TriangleModel AddTriangle(Double ax, Double ay, Double bx, Double by, Double cx, Double cy)
        {
            m_Triangles.Add(new TriangleModel(ax, ay, bx, by, cx, cy));
            TriangleModel triangle = m_Triangles.FirstOrDefault(oneElem => oneElem.Ax == ax);
            if (triangle == null) throw new InvalidOperationException("triangle doesn't exist");
            return triangle;
        }

        public TriangleModel LoadTriangle(TriangleModel triangle)
        {
            if (m_Triangles.Contains(triangle))
            {
                return triangle;
            }
            return null;
        }
    }
}
