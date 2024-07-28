using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.BusinessLogic.InsuranceStrategies
{
    // Sağlık sigortası prim hesaplama stratejisi
    public class HealthInsuranceStrategy : IInsuranceStrategy
    {
        public decimal CalculatePremium(decimal baseAmount, int riskFactor)
        {
            // Sağlık sigortası primi hesaplama mantığı
            return baseAmount + (riskFactor * 100);
        }
    }
}
