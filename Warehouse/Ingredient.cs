namespace Warehouse
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public double IngredientPrice { get; set;}

        public ToppingEnum? ToppingEnum { get; set; }
        
        public Ingredient(string name, int ingredientId, double ingredientPrice, ToppingEnum? toppingEnum=null)
        {
            Name = name;
            IngredientId = ingredientId;
            IngredientPrice = ingredientPrice;
            ToppingEnum = toppingEnum;
        }
    }
}