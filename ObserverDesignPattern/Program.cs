
// Observer Design Pattern, özellikle bir nesnenin (subject) durumundaki değişikliklerin bir dizi diğer nesneye (observers) bildirilmesi gerektiğinde kullanılır. Bu desen, genellikle olay tabanlı sistemlerde, durum değişikliklerini yönetmek için kullanılır. Örneğin, bir haber uygulamasında yeni haber eklendiğinde abonelere bilgi verilmesi gibi senaryolarda kullanılabilir.

using ObserverDesignPattern.Application.Interfaces;
using ObserverDesignPattern.Application.Services;
using ObserverDesignPattern.Domain.Entities;
using ObserverDesignPattern.Domain.Events;

// StockService'ın bir örneğini oluştur.
IStockService stockService = new StockService();

// Gözlemcilerin örneklerini oluştur.
IStockObserver salesDepartment = new SalesDepartment();
IStockObserver purchasingDepartment = new PurchasingDepartment();

// Gözlemcileri stok servisine kaydet.
stockService.RegisterObserver(salesDepartment);
stockService.RegisterObserver(purchasingDepartment);

// Stoğa miktar ekle ve bildirimleri gözlemle.
stockService.AddStock("Laptop", 50);
stockService.RemoveStock("Laptop", 5);


class SalesDepartment : IStockObserver
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Sales Department: Stock of {stock.ProductName} updated to {stock.Quantity}.");
    }
}

class PurchasingDepartment : IStockObserver
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Purchasing Department: Stock of {stock.ProductName} updated to {stock.Quantity}.");
    }
}