using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 乘法运算
    /// </summary>
    public class OperationMul:Operation
    {
        public override double GetOperstionResult()
        {
            double result = 0;
            result = numberA * numberB;
            return result;
        }
    }
}