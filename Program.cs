namespace SimulasSoup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Simulas Soup Maker!");

            var soup = Recipes.CreateSoup();

            Console.WriteLine($"\n You made a {soup.Item3} {soup.Item2} {soup.Item1}.");
        }
    }
}
