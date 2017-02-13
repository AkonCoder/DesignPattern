using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 减法运算
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetOperstionResult()
        {
            double result = 0;
            result = numberA - numberB;
            return result;
        }
    }
}