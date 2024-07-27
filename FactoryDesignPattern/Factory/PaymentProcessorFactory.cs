using FactoryDesignPattern.Concrete;
using static FactoryDesignPattern.ComplexTypes.Enums;

namespace FactoryDesignPattern.Factory
{
    //Bu örnekte, PaymentProcessorFactory sınıfı, ödeme yöntemine göre uygun IPaymentProcessor implementasyonunu oluşturur ve geri döner. Bu, istemcinin hangi sınıfın kullanılacağını bilmeden ödeme işlemini gerçekleştirmesini sağlar. Ayrıca, yeni bir ödeme yöntemi eklendiğinde, sadece yeni bir sınıf ve PaymentProcessorFactory sınıfına bir durum eklemek yeterlidir; istemci kodunda herhangi bir değişiklik yapılmasına gerek kalmaz.
    public static class PaymentProcessorFactory
    {
        // CreatePaymentProcessor metodu, ödeme yöntemine göre uygun IPaymentProcessor implementasyonunu oluşturur ve geri döner.
        public static IPaymentProcessor CreatePaymentProcessor(PaymentMethod paymentMethod)
        {
            // switch-case yapısı kullanılarak, ödeme yöntemine göre uygun IPaymentProcessor implementasyonu oluşturulur ve geri döner.
            return paymentMethod switch
            {
                PaymentMethod.CreditCard => new CreditCardPaymentProcessor(),
                PaymentMethod.Paypal => new PaypalPaymentProcessor(),
                PaymentMethod.BankTransfer => new BankTransferPaymentProcessor(),
                _ => throw new ArgumentException("Invalid payment method", nameof(paymentMethod)),
            };
        }
    }
}
