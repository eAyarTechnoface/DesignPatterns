namespace StrategyDesignPattern.Interfaces
{
    // Tüm sigorta stratejilerinin uygulayacağı bir arayüz tanımlayalım.
    public interface IInsuranceStrategy
    {
        // Prim hesaplama metodu    
        decimal CalculatePremium(decimal baseAmount, int riskFactor);
    }
}
