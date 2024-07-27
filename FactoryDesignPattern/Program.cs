//Örnek olarak bir e-ticaret uygulamasında farklı ödeme yöntemleri (kredi kartı, PayPal, banka transferi vb.) için bir ödeme işleme sistemi düşünelim. Bu sistemde, her ödeme yöntemi için farklı işlem adımları olabilir. Factory Design Pattern kullanarak bu ödeme işlemlerini merkezileştirebiliriz. Bu sayede, yeni bir ödeme yöntemi eklemek istediğimizde sadece yeni bir ödeme sınıfı oluşturmamız yeterli olacaktır.

// Factory Design Pattern, bir sınıfın nesne oluşturma işlemini alt sınıflara devreder. Bu sayede, nesne oluşturma işlemi alt sınıflara bırakılarak sınıflar arasındaki bağımlılık azaltılır. Factory Design Pattern, nesne oluşturma işlemini alt sınıflara devrederken, hangi alt sınıfın nesne oluşturacağına karar vermek için bir arayüz veya bir sınıf kullanır.

// Kullanım Örneği
using FactoryDesignPattern.Factory;
using static FactoryDesignPattern.ComplexTypes.Enums;

var amount = 150.00m;
var paymentMethod = PaymentMethod.CreditCard;

var paymentProcessor = PaymentProcessorFactory.CreatePaymentProcessor(paymentMethod);
paymentProcessor.ProcessPayment(amount);