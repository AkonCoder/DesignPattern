using System;

namespace StrategyPattern
{
    /// <summary>
    /// 策略C
    /// </summary>
     public class StrategyCFunction:Strategy
    {
         /// <summary>
         /// 策略C(打8折)
         /// </summary>
         /// <param name="money"></param>
         /// <returns></returns>
       public override double DoActionInterface(double money)
         {
             return money*0.8;
         }
    }
}
