using System;
using System.Collections.Generic;

namespace Pizza
{
    public class ShoppingCart
    { 
        public List<Pizza> Pizzas = new List<Pizza>();
        public double TotalPrice { get; set; } = 0;

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            CalculateTotalPrice();
        }
        
        public void CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (var pizza in Pizzas)
            {
                TotalPrice += pizza.Price;
            }
            TotalPrice=Math.Round(TotalPrice, 2);
        }

        public void PrintShoppingCart()
        {
            for (int i = 0; i < Pizzas.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Pizzas[i]}");
      
            }

            Console.WriteLine($"Total price: {TotalPrice}");
        }
    }
    
}