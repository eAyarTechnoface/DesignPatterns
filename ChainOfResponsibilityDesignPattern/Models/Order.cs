namespace ChainOfResponsibilityDesignPattern.Models
{
    // Temel bir sipariş sınıfı oluşturuyoruz.
    public class Order
    {
        public string CustomerName { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = [];
        public decimal TotalPrice { get; set; } = 0;

        public void AddIngredient(Ingredient ingredient, decimal price)
        {
            Ingredients.Add(ingredient);
            TotalPrice += price;
        }
    }
}
