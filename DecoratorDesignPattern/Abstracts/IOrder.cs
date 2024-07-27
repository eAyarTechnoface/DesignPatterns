namespace DecoratorDesignPattern.Abstracts
{
    // Sipariş için arayüz
    public interface IOrder
    {
        string Description { get; }
        decimal GetTotalCost();
    }
}
