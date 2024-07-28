using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.Contexts
{
    public class InsuranceContext
    {
        private IInsuranceStrategy _insuranceStrategy;

        public void SetInsuranceStrategy(IInsuranceStrategy insuranceStrategy)
        {
            _insuranceStrategy = insuranceStrategy;
        }

        public decimal ExecuteCalculatePremium(decimal baseAmount, int riskFactor)
        {
            return _insuranceStrategy.CalculatePremium(baseAmount, riskFactor);
        }
    }
}
