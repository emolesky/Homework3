

namespace BiggestandSmallest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> aList = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Calculator aCalculator = new Calculator();

            int minimum = aCalculator.FindMin(aList);
            int maximum = aCalculator.FindMax(aList);

            Console.WriteLine( minimum);
            Console.WriteLine(maximum);
        }
        
            
        
    }

}









