namespace StrategyPattern
{
    /// <summary>
    /// 上下文对象（构造对象）
    /// </summary>
     public class Context
    {
        private readonly Strategy _strategy;
        private readonly double _factMoney;

        public Context(Strategy strategy,double money)
        {
            this._strategy = strategy;
            this._factMoney = money;
        }

         /// <summary>
         /// 返回结果
         /// </summary>
         /// <returns></returns>
        public double GetResult()
        {
           return _strategy.DoActionInterface(this._factMoney);
        }
    }
}
