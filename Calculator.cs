//Written By Emilynn Molesky
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiByLength
{
    public class Calculator
    {
        public int[] MultiByLength(int[] numbers)
        {
            int length = numbers.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[i] * length;

            }
            return result;
        }
}
