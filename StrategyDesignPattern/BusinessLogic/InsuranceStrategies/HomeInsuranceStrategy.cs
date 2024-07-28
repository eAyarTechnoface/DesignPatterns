using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.BusinessLogic.InsuranceStrategies
{
    // Konut sigortası prim hesaplama stratejisi
    public class HomeInsuranceStrategy : IInsuranceStrategy
    {
        public decimal CalculatePremium(decimal baseAmount, int riskFactor)
        {
            // Konut sigortası primi hesaplama mantığı
            return baseAmount + (riskFactor * 150);
        }
    }
}
