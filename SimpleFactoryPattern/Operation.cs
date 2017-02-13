using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 运算基类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;


        public double numberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double numberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetOperstionResult()
        {
            double result = 0;
            return result;
        }
    }
}