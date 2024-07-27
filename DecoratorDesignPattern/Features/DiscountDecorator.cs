using DecoratorDesignPattern.Abstracts;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.Features
{
    // İndirim uygulama özelliğini ekleyen sınıfımız.
    public class DiscountDecorator : OrderDecorator
    {
        private readonly decimal _discountAmount;

        public DiscountDecorator(IOrder order, decimal discountAmount) : base(order)
        {
            _discountAmount = discountAmount;
        }

        public override string Description => $"{_order.Description}, with Discount";

        public override decimal GetTotalCost()
        {
            return base.GetTotalCost() - _discountAmount;
        }
    }
}
