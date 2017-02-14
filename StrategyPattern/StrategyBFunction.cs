using System;

namespace StrategyPattern
{
    /// <summary>
    /// 策略B
    /// </summary>
     public  class StrategyBFunction:Strategy
    {
         /// <summary>
         /// 策略B（满500返200）
         /// </summary>
         /// <param name="money"></param>
         /// <returns></returns>
         public override double DoActionInterface(double money)
         {
             if (money>=500)
             {
               return  money = money - Math.Round(money/500)*200;
             }
             return money;
         }
    }
}
