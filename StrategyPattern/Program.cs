using System;

namespace StrategyPattern
{
    class Program
    {
        /// <summary>
        /// 客户端根据需求选择相应的策略
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var needPayMoney = 0d;
            var selectKey = Convert.ToInt32(Console.ReadLine());
            switch (selectKey)
            {
                case 1:
                    needPayMoney = new Context(new StrategyAFunction(), 600).GetResult();
                    break;
                case 2:
                    needPayMoney = new Context(new StrategyBFunction(), 600).GetResult();
                    break;
                case 3:
                    needPayMoney = new Context(new StrategyCFunction(), 600).GetResult();
                    break;
            }

            Console.WriteLine(string.Format("当前应付的金额为：{0}", needPayMoney));
            Console.ReadLine();
        }
    }
}
