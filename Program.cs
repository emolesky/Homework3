namespace MultiByLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            int[] arr1 = { 2, 3, 1, 0 };
            int[] arr2 = { 4, 1, 1 };
            int[] arr3 = { 1, 0, 33, 7, 2, 1 };
            int[] arr4 = { 0 };

            Console.WriteLine(aCalculator.MultiByLength(arr1))`;
            Console.WriteLine($"[{string.Join(",", aCalculator.MultiByLength(arr2))}]");
            Console.WriteLine($"[{string.Join(",", aCalculator.MultiByLength(arr3))}]");
            Console.WriteLine($"[{string.Join(",", aCalculator.MultiByLength(arr4))}]");

        }
    }
}
