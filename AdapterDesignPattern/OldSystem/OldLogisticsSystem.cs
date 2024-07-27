namespace AdapterDesignPattern.OldSystem
{
    // Kargo firmasının eski sistemini temsil eden sınıf.
    public class OldLogisticsSystem
    {
        // Kargo paketini sevk eden metot.
        public void ShipPackage(string description, string destination)
        {
            Console.WriteLine($"Shipping '{description}' to {destination} using Old Logistics System.");
        }
    }
}
