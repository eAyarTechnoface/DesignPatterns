// Decorator Design Pattern, bir nesneye dinamik olarak yeni davranışlar eklemenizi sağlar. Gerçek hayatta bu deseni kullanabileceğiniz birçok senaryo vardır, örneğin bir ödeme sistemi. Bir ödeme sistemi üzerinde çalıştığınızı düşünelim ve bu sisteme çeşitli özellikler eklemek istiyoruz, örneğin indirim uygulama, lojistik maliyet ekleme, vergi ekleme gibi.


/*
 Bu örnek, bir sipariş nesnesine dinamik olarak indirim, vergi ve kargo maliyeti ekler. Her Decorator sınıfı, IOrder arayüzünü uygular ve temel sipariş nesnesini veya başka bir Decorator'ı sarmalar. Bu sayede, nesneler arasındaki bağımlılıklar azaltılır ve kodun bakımı daha kolay hale gelir.

Bu yapı, özellikle esnek ve genişletilebilir olması gereken büyük projelerde kullanışlıdır. Gerçek hayatta, bu tasarım deseni, bir web uygulamasında çeşitli kullanıcı rollerine özel davranışlar eklemek veya bir mesajlaşma sisteminde farklı türde mesaj işlemleri eklemek gibi senaryolarda kullanılabilir.
 
 */

using DecoratorDesignPattern.Abstracts;
using DecoratorDesignPattern.Concrete;
using DecoratorDesignPattern.Features;

IOrder order = new Order();
Console.WriteLine($"Description: {order.Description}, Cost: {order.GetTotalCost()}");

// İndirim uygulama özelliğini ekleyen sınıfımız.
order = new DiscountDecorator(order, 10);
Console.WriteLine($"Description: {order.Description}, Cost: {order.GetTotalCost()}");

// Vergi uygulama özelliğini ekleyen sınıfımız.
order = new TaxDecorator(order, 0.18m);
Console.WriteLine($"Description: {order.Description}, Cost: {order.GetTotalCost()}");

// Lojistik maliyet ekleme özelliğini ekleyen sınıfımız.
order = new ShippingCostDecorator(order, 5);
Console.WriteLine($"Description: {order.Description}, Cost: {order.GetTotalCost()}");