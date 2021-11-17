using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private readonly List<Ingredient> Ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Ingredients = new List<Ingredient>();
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => Ingredients.Sum(alcohol => alcohol.Alcohol);

        public void Add(Ingredient ingredient)
        {
            bool isIngredient = false;
            foreach (Ingredient element in Ingredients)
            {
                if (element.Name == ingredient.Name)
                {
                    isIngredient = true;
                }
            }

            if (!isIngredient)
            {
                if (Ingredients.Count < Capacity && CurrentAlcoholLevel <= MaxAlcoholLevel)
                {
                    Ingredients.Add(ingredient);
                }
            }
        }

        public bool Remove(string name)
        {
            bool isIngredient = false;
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.Name == name)
                {
                    isIngredient = true;

                }
            }

            if (isIngredient)
            {
                Ingredients.Remove(Ingredients.FirstOrDefault(ingredient => ingredient.Name == name));
                return true;
            }
            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(n => n.Name == name);
        }

        public Ingredient GetMostAlcoholicIngredient() => Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();

        public string Report()
        {
            var result = $"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}\r\n";
            foreach (Ingredient ingredient in Ingredients)
            {
                result += $"{ingredient.ToString()}\r\n";
            }
            return result.TrimEnd();
        }
    }
}
