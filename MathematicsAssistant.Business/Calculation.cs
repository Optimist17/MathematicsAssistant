using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.Business
{
    public class Calculation
    {
        public String Task { get; private set; }
        public String Solution { get; private set; }

        public List<String> PartsOfTask = new List<String>();

        public void SplitTask()
        {
            Int32 position = 0;
            Int32 start = 0;
            do
            {
                position = Task.IndexOfAny(new char[] { '+', '-', '*', '/', ' '}, start);
                if (position >= 0)
                {
                    PartsOfTask.Add(Task.Substring(start, position - start));
                    if (position < Task.Length - 1)
                    {
                        PartsOfTask.Add(Task.Substring(position, 1));
                    }
                }
                start = position + 1;
            } while (position > 0);
        }

        #region Constructor
        public Calculation(String task)
        {
            Task = task + " ";
            SplitTask();
        }
        #endregion
    }
}
