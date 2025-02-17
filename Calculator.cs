//Emilynn Molesky
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNum
{
    public class Calculator
    {
        public string SmallestNum(string num1, string num2)
        {
            if (num1.Length < num2.Length)
            {
                return num1;
            }
            if (num1.Length > num2.Length)
            {
                return num2;
            }
            return (string.Compare(num1, num2) <= 0) ? num1 : num2;
        }
}
