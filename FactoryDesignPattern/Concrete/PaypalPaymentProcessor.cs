namespace FactoryDesignPattern.Concrete
{
    //Paypal ile ödeme işlemlerini gerçekleştiren sınıf.
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        // Paypal ile ödeme işlemleri burada yapılır
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paypal Payment of {amount:C} processed.");
        }
    }
}
