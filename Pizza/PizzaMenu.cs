using System;
using System.Collections.Generic;
using Warehouse;

namespace Pizza
{
    public static class PizzaMenu
    {
        static List<Pizza> InMenu;
        
        static PizzaMenu()
        {
            var hamPizzaIngredients = new List<ToppingEnum>() {ToppingEnum.CHEESE,ToppingEnum.MUSHROOM,ToppingEnum.HAM,ToppingEnum.TOMATO};
            var havaijPizzaIngredients = new List<ToppingEnum>() {ToppingEnum.CHEESE,ToppingEnum.CHICKEN,ToppingEnum.PINEAPPLE,ToppingEnum.CORN};
            var kebabPizzaIngredients = new List<ToppingEnum>() {ToppingEnum.CHEESE,ToppingEnum.KEBAB,ToppingEnum.JALAPENO,ToppingEnum.CORN};
            var cananasPizzaIngredients = new List<ToppingEnum>() {ToppingEnum.CHEESE,ToppingEnum.HAM,ToppingEnum.SWEET_PEPPER,ToppingEnum.BACON};
            var vegetarianPizzaIngredients = new List<ToppingEnum>() {ToppingEnum.CHEESE,ToppingEnum.MOZZARELLA,ToppingEnum.SWEET_PEPPER,ToppingEnum.GARLIC};

            
            InMenu=new List<Pizza>();
            Pizza pizza1 = new Pizza("Ham Pizza", hamPizzaIngredients, 6);
            InMenu.Add(pizza1);
            Pizza pizza2 = new Pizza("Hawaij Pizza", havaijPizzaIngredients, 6);
            InMenu.Add(pizza2);
            Pizza pizza3 = new Pizza("Kebab Pizza", kebabPizzaIngredients, 6);
            InMenu.Add(pizza3);
            Pizza pizza4 = new Pizza("Cananas", cananasPizzaIngredients, 6.0);
            InMenu.Add(pizza4);
            Pizza pizza5 = new Pizza("Vegetariana", vegetarianPizzaIngredients, 6.0);
            InMenu.Add(pizza5);
            Pizza pizza6 = new Pizza("Custom pizza", new List<ToppingEnum>(), 6.0);
            InMenu.Add(pizza6);
        }

        public static bool PizzaInMenu(int id)
        {
            return (id <= InMenu.Count && id >0);
        }

        public static Pizza GetPizza(int id)
        {
            return InMenu[id - 1].GetCopy();
        }
        
        public static void PrintInMenu()
        {
            var i = 1;
            foreach (Pizza pizza in InMenu)
            {
                Console.WriteLine($"{i}. {pizza}");
                i++;
            }

           
            
        }
        
        
        
    }
    
}