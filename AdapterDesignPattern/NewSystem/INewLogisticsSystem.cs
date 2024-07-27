namespace AdapterDesignPattern.NewSystem
{
    // Yeni kargo sistemi için oluşturulacak arayüz.
    public interface INewLogisticsSystem
    {
        // Kargo paketini sevk eden metot.
        void Send(string packageInfo);
    }
}
