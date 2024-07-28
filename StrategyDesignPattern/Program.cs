// Strategy Design Pattern, davranışsal tasarım desenlerinden biridir ve belirli bir işlemin nasıl gerçekleştirileceğine dair bir strateji oluşturulmasını sağlar. Bu desen, bir sınıfın çeşitli algoritmalar arasında geçiş yapabilmesini ve bu algoritmaların bağımsız olarak tanımlanmasını mümkün kılar. Gerçek hayat projelerinde bu desen, özellikle farklı iş kurallarını uygulamak veya değişken algoritmalar arasında geçiş yapmak gerektiğinde kullanılır.

// Gerçek hayat projelerinde bu desen, özellikle farklı iş kurallarını uygulamak veya değişken algoritmalar arasında geçiş yapmak gerektiğinde kullanılır.

//  Bu sefer bir sigorta şirketi senaryosu üzerinden örnek vereyim. Bu senaryoda, farklı sigorta türlerine (sağlık sigortası, araç sigortası, konut sigortası) ait prim hesaplamalarını strateji deseni ile gerçekleştireceğiz. Bu örnek, farklı sigorta türleri için prim hesaplama mantığını ayrı sınıflara dağıtarak esnek bir yapı oluşturmayı hedefler.

using StrategyDesignPattern.BusinessLogic.InsuranceStrategies;
using StrategyDesignPattern.Contexts;

//Context oluştur
InsuranceContext context = new InsuranceContext();

//Sigorta türünü seç ve context'e ata.
context.SetInsuranceStrategy(new HealthInsuranceStrategy());
decimal baseAmount = 1000; // Temel sigorta primi
int riskFactor = 2; // Risk faktörü

//Sigorta primini hesapla
decimal premium = context.ExecuteCalculatePremium(baseAmount, riskFactor);
Console.WriteLine($"Health Insurance Premium: {premium:C}");

// Farklı bir stratejiyi seçip tekrar hesaplama işlemi yapabiliriz.

context.SetInsuranceStrategy(new CarInsuranceStrategy());
decimal baseAmountCar = 2000; // Temel sigorta primi
int riskFactorCar = 3; // Risk faktörü

//Sigorta primini hesapla
decimal premiumCar = context.ExecuteCalculatePremium(baseAmountCar, riskFactorCar);
Console.WriteLine($"Car Insurance Premium: {premiumCar:C}");