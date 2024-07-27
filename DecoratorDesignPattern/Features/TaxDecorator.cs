using DecoratorDesignPattern.Abstracts;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.Features
{
    // Vergi uygulama özelliğini ekleyen sınıfımız.
    public class TaxDecorator : OrderDecorator
    {
        private readonly decimal _taxRate;

        public TaxDecorator(IOrder order, decimal taxRate) : base(order)
        {
            _taxRate = taxRate;
        }

        public override string Description => $"{_order.Description}, with Tax";
        public override decimal GetTotalCost()
        {
            return base.GetTotalCost() * (1 + _taxRate);
        }
    }
}
