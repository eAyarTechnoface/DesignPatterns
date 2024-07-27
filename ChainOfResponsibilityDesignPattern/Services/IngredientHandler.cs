using ChainOfResponsibilityDesignPattern.Models;

namespace ChainOfResponsibilityDesignPattern.Services
{
    // Zincirin temel işleyici sınıfını ve somut işleyici sınıflarını tanımlayalım.
    public abstract class IngredientHandler
    {

        protected IngredientHandler _nextHandler;

        // Bir sonraki işleyiciyi ayarlamak için bir metot tanımlayalım.
        public void SetNextHandler(IngredientHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        // İsteği işleyecek soyut metodu tanımlayalım.
        public abstract void Handle(Order order, Ingredient ingredient);
    }
}
