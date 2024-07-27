namespace FactoryDesignPattern
{
    //Tüm ödeme yöntemlerinin uygulaması gereken arayüz.
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
