using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class OperationFactory
    {
        /// <summary>
        /// 返回实例对象
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static Operation CreateOperation(string operation)
        {
            Operation operationObj = null;
            switch (operation)
            {
                case  "+":
                    operationObj = new OperationAdd();
                    break;
                case  "-":
                    operationObj = new OperationSub();
                    break;
                case  "*":
                    operationObj = new OperationMul();
                    break;
                case  "/":
                    operationObj = new OperationDiv();
                    break;
            }
            return operationObj;
        }
    }
}