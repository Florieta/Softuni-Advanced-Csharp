using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            SortedDictionary<string, int> data = new SortedDictionary<string, int>(); Dictionary<string, int> menu = new Dictionary<string, int>
            {
                {"Chocolate cake", 0},
                {"Dipping sauce", 0},
                {"Green salad", 0},
                {"Lobster", 0}
            };
           
            string cake = "Chocolate cake";
            string sauce = "Dipping sauce";
            string salad = "Green salad";
            string lobster = "Lobster";



            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int currentIngredient = ingredients.Peek();
                int currentFreshness = freshness.Peek();
                bool success = false;

                if (currentIngredient <= 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int cooking = currentIngredient * currentFreshness;

                if (cooking.Equals(150))
                {
                    success = true;
                    menu[sauce]++;
                }
                else if (cooking.Equals(250))
                {
                    success = true;
                    menu[salad]++;
                }
                else if (cooking.Equals(300))
                {
                    success = true;
                    menu[cake]++;
                }
                else if (cooking.Equals(400))
                {
                    success = true;
                    menu[lobster]++;
                }
                else
                {
                    freshness.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }

                if (success)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                }

            }
            menu = menu
                .Where(x => x.Value != 0)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine(menu.Keys.Count == 4
                ? "Applause! The judges are fascinated by your dishes!"
                : "You were voted off. Better luck next year.");

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }
            foreach (var meal in menu.Where(x => x.Value > 0))
            {
                Console.WriteLine(string.Join(Environment.NewLine, $" # {meal.Key} --> {meal.Value}"));
            }
            
        }
    }
}
