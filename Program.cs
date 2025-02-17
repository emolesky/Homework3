namespace Hunting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1, please set the Manticore distance from the city (0-100):");
            int distance = GetDistance();
            Console.Clear();

            Manticore aManticore = new Manticore(distance);
            int cityHealth = 15;
            int round = 1;

            while (cityHealth > 0 && aManticore.Health > 0)
            {
                Console.WriteLine($"Round {round}");
                Console.WriteLine($"City Health: {cityHealth} | Manticore Health: {aManticore.Health}");

                int cannonDamage = CalculateCannonDamage(round);
                Console.WriteLine($"This round, the cannon will deal {cannonDamage} danage.");

                Console.WriteLine("Player 2: Enter the cannons firing distance:");
                int playerGuess = GetDistance();

                if (playerGuess == aManticore.Distance)
                {
                    Console.WriteLine("that was a DIRECT HIT!");
                    aManticore.TakeDamage(cannonDamage);
                }
                if (playerGuess < aManticore.Distance)
                {
                    Console.WriteLine("the shot fell SHORT");
                }
                if(playerGuess > aManticore.Distance)
                {
                    Console.WriteLine(" the shot OVERSHOT the target");
                }
                if (aManticore.Health > 0)
                {
                    cityHealth--;
                }
                round++;
            }
            Console.WriteLine(cityHealth > 0
                ? "The Manticore has been destroyed and the city of Consolas has been saved!"
                : "The coty has been destroyed! the Manticore wins!");
        }
        static int GetDistance()
        {
            int distance;
            while (!int.TryParse(Console.ReadLine(), out distance) || distance < 0 || distance > 100)
            {
                Console.WriteLine("Invalid input, select a number between 0-100");
            }
            return distance;
        }
        static int CalculateCannonDamage( int round)
        {
            if (round % 3 == 0 && round % 5 == 0) return 10;
            if (round % 3 == 0 || round % 5 == 0) return 3;
            return 1;
        }
    }
}
