namespace ArrayOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            int[] arr1 = { 2, -1, 4, 8, 10 };
            int[] arr2 = { -3, -4, -10, -2, -3 };
            int[] arr3 = { 2, 4, 6, 8, 10 };
            int[] arr4 = { -1 };

            Console.WriteLine(aCalculator.GetAbsSum(arr1));
            Console.WriteLine(aCalculator.GetAbsSum(arr2));
            Console.WriteLine(aCalculator.GetAbsSum(arr3));
            Console.WriteLine(aCalculator.GetAbsSum(arr4));
        }
    }
}
