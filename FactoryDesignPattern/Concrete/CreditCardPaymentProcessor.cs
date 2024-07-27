namespace FactoryDesignPattern.Concrete
{
    //Kredi kartı ile ödeme işlemlerini gerçekleştiren sınıf.
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Kredi kartı ile ödeme işlemleri burada yapılır
            Console.WriteLine($"Credit Card Payment of {amount:C} processed.");
        }
    }
}
