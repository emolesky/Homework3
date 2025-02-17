namespace HowMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            Console.WriteLine(aCalculator.CountDs(" My friend Dylan got distracted in school"));
            Console.WriteLine(aCalculator.CountDs("Debris was scattered all over the yard"));
            Console.WriteLine(aCalculator.CountDs("The rodents hibernated in their den"));
        }
    }
}
