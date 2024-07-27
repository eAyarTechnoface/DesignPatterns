using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Services
{
    public class LettuceHandler : IngredientHandler
    {
        public override void Handle(Order order, Ingredient ingredient)
        {
            if (ingredient == Ingredient.Lettuce)
            {
                order.AddIngredient(ingredient, 0.25m);
                Console.WriteLine($"Lettuce added to order for {order.CustomerName}: Total Price = {order.TotalPrice}");
            }

            else if (_nextHandler != null)
            {
                _nextHandler.Handle(order, ingredient);
            }
        }
    }
}
