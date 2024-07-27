using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Services
{
    public class TomatoHandler : IngredientHandler
    {
        public override void Handle(Order order, Ingredient ingredient)
        {
            if (ingredient == Ingredient.Tomato)
            {
                order.AddIngredient(ingredient, 0.5m);
                Console.WriteLine($"Tomato added to order for {order.CustomerName}: Total Price = {order.TotalPrice}");
            }

            else if (_nextHandler != null)
            {
                _nextHandler.Handle(order, ingredient);
            }
        }
    }
}
