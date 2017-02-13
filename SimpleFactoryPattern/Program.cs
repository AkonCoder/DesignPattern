using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var operation = OperationFactory.CreateOperation("*");
            operation.numberA = 10;
            operation.numberB = 20;
            var result = operation.GetOperstionResult();
            Console.WriteLine("运算的结果为：" + result);
            Console.ReadLine();
        }
    }
}