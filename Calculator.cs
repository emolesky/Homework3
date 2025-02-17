//Emilynn Molesky
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMany
{
    public class Calculator
    {
        public int CountDs(string sentence)
        {
            return sentence.Count(c => char.ToLower(c) == 'd');
        }
}
