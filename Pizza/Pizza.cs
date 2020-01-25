using System;
using System.Collections.Generic;
using Warehouse;

namespace Pizza
{
    public class Pizza
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double Price { get; set; }
        
        public bool IsThin { get; set; }

        public Pizza(string name, List<Ingredient> ingredients, double price, bool isThin = true)
        {
            Name = name;
            Price = price;
            IsThin = isThin;
            Ingredients = ingredients;

        }
        
        public Pizza(string name, List<ToppingEnum> ingredientsEnums, double price, bool isThin = true)
        {
            Name = name;
            Price = price;
            IsThin = isThin;
            Ingredients = new List<Ingredient>();
            foreach (var ingredientsEnum in ingredientsEnums)
            {
                AddIngredient(ingredientsEnum);
            }
            
        }

        public void AddIngredient(ToppingEnum ingredientEnum)
        {
            var ingredient = Toppings.GetToppingByEnum(ingredientEnum);
            if (ingredient != null)
            {
                Ingredients.Add(ingredient);
            }
            CalculatePrice();
        }

        public bool AddIngredient(int id)
        {
            var topping = Toppings.GetToppingById(id);
            if (topping == null)
            {
                return false;
            }
            Ingredients.Add(topping);
            CalculatePrice();
            return true;
        }
        
        public void CalculatePrice()
        {
            Price = 6;
            foreach (var ingredient in Ingredients)
            {
                Price += ingredient.IngredientPrice;
            }
            Price=Math.Round(Price, 2);
        }

        public Pizza GetCopy()
        {
            return new Pizza(Name, Ingredients, Price, IsThin);
        }
        
        public override string ToString()
        {
            var str = "";
            str += Name+ (IsThin? " Thin":" Thick") +" ingredients: ";
            foreach (var ingredient in Ingredients)
            {
                str += ingredient.Name + " ";
            }

            str += Price + "€";
            
            return str;
        }

    }
    
    
}