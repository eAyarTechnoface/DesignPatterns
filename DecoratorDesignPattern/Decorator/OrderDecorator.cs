using DecoratorDesignPattern.Abstracts;

namespace DecoratorDesignPattern.Decorator
{
    // Decorator Design Pattern, bir nesneye dinamik olarak yeni davranışlar eklemenizi sağlar. Gerçek hayatta bu deseni kullanabileceğiniz birçok senaryo vardır, örneğin bir ödeme sistemi. Bir ödeme sistemi üzerinde çalıştığınızı düşünelim ve bu sisteme çeşitli özellikler eklemek istiyoruz, örneğin indirim uygulama, lojistik maliyet ekleme, vergi ekleme gibi.

    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        protected OrderDecorator(IOrder order)
        {
            _order = order;
        }
        public virtual string Description => _order.Description;

        public virtual decimal GetTotalCost()
        {
            return _order.GetTotalCost();
        }
    }
}
