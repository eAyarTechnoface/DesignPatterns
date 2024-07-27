using AdapterDesignPattern.NewSystem;
using AdapterDesignPattern.OldSystem;

namespace AdapterDesignPattern.Adapter
{
    //Eski sistemin arayüzünü, yeni sistemin arayüzü ile uyumlu hale getiren bir adapter: Yeni kargo sistemi için oluşturulacak adaptör.
    public class NewLogisticsAdapter : INewLogisticsSystem
    {
        private readonly OldLogisticsSystem _oldLogisticsSystem;

        public NewLogisticsAdapter(OldLogisticsSystem oldLogisticsSystem)
        {
            _oldLogisticsSystem = oldLogisticsSystem;
        }

        public void Send(string packageInfo)
        {
            var parts = packageInfo.Split(',');
            if (parts.Length == 2)
            {
                string description = parts[0];
                string destination = parts[1];
                _oldLogisticsSystem.ShipPackage(description, destination);
            }
            else
            {
                throw new ArgumentException("Invalid package information format.");
            }
        }
    }
}
