using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.BusinessLogic.InsuranceStrategies
{
    // Araç sigortası prim hesaplama stratejisi
    public class CarInsuranceStrategy : IInsuranceStrategy
    {
        // Araç sigortası prim hesaplama metodu
        public decimal CalculatePremium(decimal baseAmount, int riskFactor)
        {
            return baseAmount + (riskFactor * 200);
        }
    }
}
