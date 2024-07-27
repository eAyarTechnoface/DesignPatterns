using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Services
{
    public class CheeseHandler : IngredientHandler
    {
        //  Bu parametreler, siparişin kendisini ve eklenmek istenen ekstra malzemeyi temsil eder.
        public override void Handle(Order order, Ingredient ingredient)
        {
            // Bu satır, ekstra malzemenin peynir olup olmadığını kontrol eder. Ingredient bir enum türüdür ve burada Ingredient.Cheese ile karşılaştırma yapılmaktadır. Eğer eklenmek istenen malzeme peynir ise, bu koşul doğru olur ve ilgili kod bloğu çalıştırılır.

            if (ingredient == Ingredient.Cheese)
            {
                order.AddIngredient(ingredient, 1.00m); // Eğer peynir seçildiyse peynir ücreti ekleniyor.
                Console.WriteLine($"Cheese added to order for {order.CustomerName}: Total Price = {order.TotalPrice}");
            }

            //Eğer eklenmek istenen malzeme peynir değilse, bu durumda kontrol, zincirin bir sonraki halkasına (yani bir sonraki işleyiciye) geçer. _nextHandler, IngredientHandler sınıfında tanımlı bir protected değişkendir ve bu işleyiciye zincirde bir sonraki işleyiciyi atamak için kullanılır. Eğer _nextHandler null değilse, Handle metodu çağrılır ve işlem bir sonraki işleyiciye devredilir. Bu sayede, zincirin diğer işleyicileri sırasıyla malzeme ekleme işlemlerini gerçekleştirebilir.
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(order, ingredient);
            }
        }
    }
}
