//Written by Emilynn Molesky
//2/11/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasSoup
{
    enum SoupType {  Soup, Stew, Gumbo}
    enum MainIngredient {  Mushrooms, Chicken, Carrots, Potatoes}
    enum Seasoning { Hot, Salty, Sweet}

    public class Recipes
    {
        public static (SoupType, MainIngredient, Seasoning) CreateSoup()
        {
           
            {
                Console.WriteLine("\nPick a type of dish:");
                SoupType type = GetEnumChoice<SoupType>();

                Console.WriteLine("\nPick a main ingredient:");
                MainIngredient ingredient = GetEnumChoice<MainIngredient>();

                Console.WriteLine("\nPick a seasoning:");
                Seasoning seasoning = GetEnumChoice<Seasoning>();

                return (type, ingredient, seasoning);
            }
        }

        private static T GetEnumChoice<T>() where T : struct, Enum
        {
            while (true)
            {
                Console.WriteLine("Options: Soup Type: Soup, Stew, Gumbo. Main Ingredients: Mushrooms, Chicken, Carrots, Potatoes. Seasoning: Hot, Salty, Sweet");
                Console.WriteLine("Enter your choice:");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out T chioce))
                    return chioce;
            }
        }
    }
}
