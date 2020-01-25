using System;
using Warehouse;


namespace Pizza
{
    class Program
    {
        private static ShoppingCart _cart;
        
        
        static void Main(string[] args)
        {
            Console.Clear();

            _cart = new ShoppingCart();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to the pizza shop!");
                Console.WriteLine("_________________________________");
                Console.WriteLine("A to add pizza");
                Console.WriteLine("C to confirm");
                Console.WriteLine("X to exit");
                Console.Write(">");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "a")
                {
                    GetPizzaMenu();
                }
                else if (userInput == "c")
                {
                    _cart.PrintShoppingCart();
                    Console.ReadKey();
                }
                else if (userInput == "x")
                {
                    break;
                }

            }
        }

        public static void GetPizzaMenu()
        {

            int pizzaId = 0;
            while (pizzaId <1)
            {
                Console.Clear();
                Console.WriteLine("Please select a pizza");
                PizzaMenu.PrintInMenu();
                Console.Write(">");

                var userInput = Console.ReadLine();
                
                if (!int.TryParse(userInput, out pizzaId) || !PizzaMenu.PizzaInMenu(pizzaId))
                {
                    Console.WriteLine("User input was not correct.");
                    Console.ReadKey();
                    continue;
                }

                var pizza = PizzaMenu.GetPizza(pizzaId);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose a pizza dough (thin or thick)");
                    userInput = Console.ReadLine().ToLower();
                } while (userInput!="thin" && userInput!="thick");

                if (userInput == "thin")
                {
                    pizza.IsThin = true;
                }
                else
                {
                    pizza.IsThin = false;
                }

                userInput = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Pizza: {pizza}");
                    Console.WriteLine("Select additional toppings. Insert empty line if you want to add pizza to shopping cart.");
                    Toppings.PrintToppings();
                    Console.Write(">");
                    userInput = Console.ReadLine();
                    if (userInput=="")
                    {
                        break;
                    }
                    
                    if (!int.TryParse(userInput, out var toppingId) || Toppings.GetToppingById(toppingId)==null)
                    {
                        Console.WriteLine("User input is not correct");
                        Console.ReadKey();
                        continue;
                    }

                    pizza.AddIngredient(toppingId);
                    Console.WriteLine("Topping added");
                    Console.ReadKey();

                } while (userInput!="");
                
                _cart.AddPizza(pizza);

            }

            Console.WriteLine("Pizza added to cart");
            Console.ReadLine();
            
        }
        
    }
}