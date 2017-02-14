using System;

namespace StrategyPattern
{
    class Program
    {
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
