namespace ObserverDesignPattern.Domain.Entities
{
    // Stok sınıfı, bir ürünün stok seviyesini ve adını temsil eder.
    public class Stock
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public Stock(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }

        // Stoğa miktar eklemek için kullanılan metot.
        public void AddStock(int quantity)
        {
            Quantity += quantity;
            // Gözlemcilere stok değişikliği olduğunu bildirir.
            OnStockChanged();
        }

        // Stoktan miktar çıkarmak için kullanılan metot.
        public void RemoveStock(int quantity)
        {
            // Çıkarılacak miktarın mevcut stok miktarını aşmadığından emin olur.
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
                // Gözlemcilere stok değişikliği olduğunu bildirir.
                OnStockChanged();
            }
        }

        // Stok miktarı değiştiğinde StockChangedEvent olayını tetikleyen özel metot.
        private void OnStockChanged()
        {
            StockChangedEvent?.Invoke(this);
        }

        // Stok miktarı değiştiğinde tetiklenen olay.
        public event Action<Stock> StockChangedEvent;
    }
}
