using ObserverDesignPattern.Domain.Entities;

namespace ObserverDesignPattern.Domain.Events
{
    // Stok gözlemcileri için bir arayüz, Update metodunu uygulamak zorundadır.
    public interface IStockObserver
    {
        // Gözlemciyi yeni stok bilgisiyle güncellemek için kullanılan metot.
        void Update(Stock stock);
    }
}
