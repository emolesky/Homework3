namespace VinFletchers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an Arrowhead type ( Steel, Wood, Obsidian):");
            string arrowheadInput = Console.ReadLine();
            ArrowheadType arrowhead = Enum.Parse<ArrowheadType>(arrowheadInput, true);

            Console.WriteLine("Choose an Fletching type ( Plastic, TurkeyFeathers, GooseFeathers)");
            string fletchingInput = Console.ReadLine();
            FletchingType fletching = Enum.Parse<FletchingType>(fletchingInput, true);

            Console.WriteLine("Enter shaft length (60-100 cm):");
            float length = float.Parse(Console.ReadLine());

            Arrow aArrow = new Arrow(arrowhead, fletching, length );
            aArrow.ShowInfo();
        }
    }
}
