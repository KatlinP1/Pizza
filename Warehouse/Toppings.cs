using System;
using System.Collections.Generic;

enum Toppings
{
}

namespace Warehouse
{
    public static class Toppings
    {
        public static List<Ingredient> ToppingsList { get; set; }

        static Toppings()
        {
            ToppingsList = new List<Ingredient>();
            Ingredient cheese = new Ingredient("cheese", 1, 0.50, ToppingEnum.CHEESE);
            ToppingsList.Add(cheese);
            Ingredient bacon = new Ingredient("bacon", 2, 0.55, ToppingEnum.BACON);
            ToppingsList.Add(bacon);
            Ingredient tunaFish = new Ingredient("tuna fish", 3, 0.55, ToppingEnum.TUNA_FISH);
            ToppingsList.Add(tunaFish);
            Ingredient pineapple = new Ingredient("pineapple", 4, 0.45, ToppingEnum.PINEAPPLE);
            ToppingsList.Add(pineapple);
            Ingredient salami = new Ingredient("salami", 5, 0.55, ToppingEnum.SALAMI);
            ToppingsList.Add(salami);
            Ingredient jalapeno = new Ingredient("jalapeno", 6, 0.50, ToppingEnum.JALAPENO);
            ToppingsList.Add(jalapeno);
            Ingredient sweetPepper = new Ingredient("sweet pepper", 7, 0.40, ToppingEnum.SWEET_PEPPER);
            ToppingsList.Add(sweetPepper);
            Ingredient chicken = new Ingredient("chicken", 8, 0.50, ToppingEnum.CHICKEN);
            ToppingsList.Add(chicken);
            Ingredient ham = new Ingredient("ham", 9, 0.50, ToppingEnum.HAM);
            ToppingsList.Add(ham);
            Ingredient olives = new Ingredient("olives", 10, 0.40, ToppingEnum.OLIVES);
            ToppingsList.Add(olives);
            Ingredient onion = new Ingredient("onion", 11, 0.35, ToppingEnum.ONION);
            ToppingsList.Add(onion);
            Ingredient pickles = new Ingredient("pickles", 12, 0.40, ToppingEnum.PICKLES);
            ToppingsList.Add(pickles);
            Ingredient mushrooms = new Ingredient("mushrooms", 13, 0.40, ToppingEnum.MUSHROOM);
            ToppingsList.Add(mushrooms);
            Ingredient tomato = new Ingredient("tomato", 14, 0.40, ToppingEnum.TOMATO);
            ToppingsList.Add(tomato);
            Ingredient kebab = new Ingredient("kebab", 15, 0.60, ToppingEnum.KEBAB);
            ToppingsList.Add(kebab);
            Ingredient mozzarella = new Ingredient("mozzarella", 16, 0.60, ToppingEnum.MOZZARELLA);
            ToppingsList.Add(mozzarella);
            Ingredient garlic = new Ingredient("garlic", 17, 0.20, ToppingEnum.GARLIC);
            ToppingsList.Add(garlic);
            Ingredient corn = new Ingredient("corn", 18, 0.35, ToppingEnum.CORN);
            ToppingsList.Add(corn);
        }

        public static Ingredient? GetToppingByEnum(ToppingEnum toppingEnum)
        {
            foreach (var ingredient in ToppingsList)
            {
                if (ingredient.ToppingEnum == toppingEnum)
                {
                    return ingredient;
                }
            }

            return null;
        }

        public static Ingredient? GetToppingById(int id)
        {
            foreach (var ingredient in ToppingsList)
            {
                if (ingredient.IngredientId == id)
                {
                    return ingredient;
                }
            }

            return null;
        }

        public static void PrintToppings()
        {
            foreach (var ingredient in ToppingsList)
            {
                Console.WriteLine($"{ingredient.IngredientId}. {ingredient.Name} {ingredient.IngredientPrice} €");
            }
        }
    }
}