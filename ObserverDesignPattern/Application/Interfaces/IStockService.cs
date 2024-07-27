using ObserverDesignPattern.Domain.Events;

namespace ObserverDesignPattern.Application.Interfaces
{
    // Stok Servisi için arayüz, stok yönetimi ve gözlemci kaydı için metodları tanımlar.
    public interface IStockService
    {
        // Belirli bir ürün için stoğa miktar eklemek için metot.
        void AddStock(string productName, int quantity);
        // Belirli bir ürün için stoktan miktar çıkarmak için metot.
        void RemoveStock(string productName, int quantity);

        // Stok değişikliklerinden haberdar edilecek bir gözlemciyi kaydetmek için metot.
        void RegisterObserver(IStockObserver observer);
    }
}
