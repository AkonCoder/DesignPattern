namespace StrategyPattern
{
    /// <summary>
    /// 策略A
    /// </summary>
    public class StrategyAFunction: Strategy
    {
        /// <summary>
        /// 策略A（正常收费）
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double DoActionInterface(double money)
        {
            return money;
        }
    }
}
