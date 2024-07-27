using DecoratorDesignPattern.Abstracts;

namespace DecoratorDesignPattern.Concrete
{
    // Temel sınıfımız olan Order sınıfımızı oluşturuyoruz.
    public class Order : IOrder
    {
        public string Description => "Basic Order";

        public decimal GetTotalCost()
        {
            return 100; // Temel sipariş ücreti
        }
    }
}
