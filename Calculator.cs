//Written by Emilynn Molesky
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfIntegers
{
    public class Calculator
    {
        public int GetAbsSum(int[] numbers)
            {
                int sum = 0;
                foreach (int i in numbers)
                {
                    sum += Math.Abs(i);
                }
                return sum;
            }
        
    }
}
