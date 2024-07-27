namespace FactoryDesignPattern.Concrete
{
    //Banka havalesi ile ödeme işlemlerini gerçekleştiren sınıf.
    public class BankTransferPaymentProcessor : IPaymentProcessor
    {
        // Banka havalesi ile ödeme işlemleri burada yapılır
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Bank Transfer Payment of {amount:C} processed.");
        }
    }
}
