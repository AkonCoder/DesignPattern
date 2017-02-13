using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class OperationDiv:Operation
    {
        public override double GetOperstionResult()
        {
            double result = 0;
            if (numberB == 0)
            {
                throw  new Exception("除数不能为0！");
            }
            result = numberA/numberB;
            return result;
        }
    }
}