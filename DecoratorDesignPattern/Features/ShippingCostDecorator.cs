using DecoratorDesignPattern.Abstracts;
using DecoratorDesignPattern.Decorator;

namespace DecoratorDesignPattern.Features
{
    // Lojistik maliyet ekleme özelliğini ekleyen sınıfımız.
    public class ShippingCostDecorator : OrderDecorator
    {
        private readonly decimal _shippingCost;
        public ShippingCostDecorator(IOrder order, decimal shippingCost) : base(order)
        {
            _shippingCost = shippingCost;
        }

        override public string Description => $"{_order.Description}, with Shipping Cost";
        override public decimal GetTotalCost()
        {
            return base.GetTotalCost() + _shippingCost;
        }
    }
}
