using ObserverDesignPattern.Application.Interfaces;
using ObserverDesignPattern.Domain.Entities;
using ObserverDesignPattern.Domain.Events;

namespace ObserverDesignPattern.Application.Services
{
    // IStockService arayüzünün somut bir uygulaması.
    public class StockService : IStockService
    {
        // Kayıtlı gözlemcilerin listesi.
        private List<IStockObserver> _observers;
        // Takip edilen stokların listesi.
        private List<Stock> _stockList;

        // Yapıcı metot, gözlemci ve stok listelerini başlatır.
        public StockService()
        {
            _observers = new List<IStockObserver>();
            _stockList = new List<Stock>();
        }

        // Bir ürün için stoğa miktar eklemek için metot. Ürün mevcut değilse, yeni bir stok girişi oluşturur.
        public void AddStock(string productName, int quantity)
        {
            // Ürün için stok kaydını bul.
            var stock = _stockList.Find(s => s.ProductName == productName);
            if (stock == null)
            {
                // Bulunamazsa yeni bir stok kaydı oluştur.
                stock = new Stock(productName, quantity);
                // StockService'ı stokun StockChangedEvent olayına abone et.
                stock.StockChangedEvent += StockChangedHandler;
                _stockList.Add(stock);
            }
            else
            {
                // Stok kaydı varsa, miktarı güncelle.
                stock.AddStock(quantity);
            }
        }
        // Stok değişikliklerinden haberdar edilecek bir gözlemciyi kaydetmek için metot.
        public void RegisterObserver(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        // Bir ürün için stoktan miktar çıkarmak için metot.
        public void RemoveStock(string productName, int quantity)
        {
            // Ürün için stok kaydını bul.
            var stock = _stockList.Find(s => s.ProductName == productName);
            if (stock != null)
            {
                // Stok kaydı varsa, miktarı güncelle.
                stock.RemoveStock(quantity);
            }
        }

        // Stok değişikliklerini kaydedilen tüm gözlemcilere bildiren olay işleyici.
        private void StockChangedHandler(Stock stock)
        {
            foreach (var observer in _observers)
            {
                observer.Update(stock);
            }
        }
    }
}
