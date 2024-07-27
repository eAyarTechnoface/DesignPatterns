

//Chain of Responsibility (CoR) tasarım deseni, bir istek için bir dizi işleyici tanımlayarak, isteğin bu işleyiciler arasında dolaşmasını sağlar. Her işleyici, isteği işleyebilir veya bir sonraki işleyiciye iletebilir. Bu desen, özellikle isteklerin dinamik olarak işlenmesi gereken durumlarda kullanışlıdır.

// Bir online yemek sipariş sitesi için "ekstra malzemeler ekleme" senaryosunu Chain of Responsibility tasarım deseni ile nasıl uygulayabileceğimize dair bir örnek oluşturabiliriz. Bu senaryoda, kullanıcılar siparişlerine ekstra malzemeler ekleyebilirler ve her malzeme için ilgili bir işleyici, bu isteği ele alabilir.

//Bu işleyicileri zincir şeklinde bağlayalım ve nasıl kullanıldığını gösterelim.

// Bu örnek, Chain of Responsibility desenini kullanarak bir yemek siparişine ekstra malzemeler eklemenin nasıl yönetilebileceğini göstermektedir. Gerçek hayatta, bu desen, bir siparişe eklemeler yapma, istekleri farklı departmanlara yönlendirme veya belirli kurallara göre işlemler yapma gibi durumlarda kullanılabilir.

using ChainOfResponsibilityDesignPattern.Models;
using ChainOfResponsibilityDesignPattern.Services;

// Bu satır, yeni bir Order nesnesi oluşturur ve CustomerName özelliği "Emre Can Ayar" olarak ayarlanır. Order nesnesi, bir müşterinin sipariş detaylarını içerir, örneğin hangi malzemelerin eklendiği ve toplam sipariş tutarı gibi.
var order = new Order
{
    CustomerName = "Emre Can Ayar",
};

// Ekstra malzeme işleyici zincirini oluştur
// Bu satırlarda, CheeseHandler, TomatoHandler ve LettuceHandler sınıflarından yeni nesneler oluşturulur. Bu sınıflar, IngredientHandler sınıfından türetilmiştir ve her biri belirli bir malzemenin siparişe eklenmesiyle ilgilenir. Örneğin, CheeseHandler peynir, TomatoHandler domates, LettuceHandler ise marul eklemekten sorumludur.
var cheeseHandler = new CheeseHandler();
var tomatoHandler = new TomatoHandler();
var lettuceHandler = new LettuceHandler();

//Bu satırlar, işleyici zincirini kurar. cheeseHandler, SetNextHandler yöntemiyle bir sonraki işleyici olarak tomatoHandler'ı ayarlar. Benzer şekilde, tomatoHandler bir sonraki işleyici olarak lettuceHandler'ı ayarlar. Bu zincirleme yapı, bir işleyicinin kendisine verilen malzemeyi ekleyemediği durumda, isteğin bir sonraki işleyiciye geçmesini sağlar.

cheeseHandler.SetNextHandler(tomatoHandler);
tomatoHandler.SetNextHandler(lettuceHandler);

// Bu satırlarda, sırayla peynir, domates ve marul malzemeleri siparişe eklenmek istenir. cheeseHandler.Handle yöntemi, her malzeme için çağrılır. İşleyici zinciri, her malzemeyi doğru işleyiciye yönlendirir:

/*
 İlk çağrıda Ingredient.Cheese malzemesi cheeseHandler tarafından işlenir ve siparişe eklenir.
İkinci çağrıda Ingredient.Tomato malzemesi, cheeseHandler'ın değil, tomatoHandler'ın alanına girdiği için zincirde bir sonraki işleyici olan tomatoHandler tarafından işlenir ve siparişe eklenir.
Üçüncü çağrıda Ingredient.Lettuce malzemesi, lettuceHandler tarafından işlenir ve siparişe eklenir.
 
 */

cheeseHandler.Handle(order, Ingredient.Cheese);
cheeseHandler.Handle(order, Ingredient.Tomato);
cheeseHandler.Handle(order, Ingredient.Lettuce);

Console.WriteLine($"Final order total for {order.CustomerName} is {order.TotalPrice}");