using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestandSmallest
{
    public class Calculator
    {
        public int FindMin(List<int> aList)
        {
            int min = aList[0];

            foreach (int i in aList)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public int FindMax(List<int> aList)
        {
            int max = aList[0];

            foreach (int i in aList)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public int FindAvg(List<int>aList)
        {
            int avg = 0;
            int sum = 0;

            foreach( int i in aList)
            {
                sum = sum + 1;

            }
            avg = sum / aList.Count;
            return avg;
        }
    }
}



