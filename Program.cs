namespace SmallerNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            Console.WriteLine(aCalculator.SmallestNum("21", "44"));
            Console.WriteLine(aCalculator.SmallestNum("1500", "1"));
            Console.WriteLine(aCalculator.SmallestNum("5", "5"));
            Console.WriteLine(aCalculator.SmallestNum("123", "456"));
            Console.WriteLine(aCalculator.SmallestNum("100", "99"));
        }
    }
}
