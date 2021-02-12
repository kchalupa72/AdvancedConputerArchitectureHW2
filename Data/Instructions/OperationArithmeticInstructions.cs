using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class OperationArithmeticInstructions
    {
        public static Dictionary<string, int> ArithmeticInstructions = new Dictionary<string, int>()
        {
            { OperationCodeConstants.Add, 0 },
            { OperationCodeConstants.Sub, 1 },
            { OperationCodeConstants.Mult, 2 },
            { OperationCodeConstants.Div, 3 },
            { OperationCodeConstants.Addi, 4 },
            { OperationCodeConstants.Subi, 5 },
            { OperationCodeConstants.Multi, 6 },
            { OperationCodeConstants.Divi, 7 },
            { OperationCodeConstants.Dup, 7 },
            { OperationCodeConstants.Doubl, 7 },
            { OperationCodeConstants.Squar, 7 },
            { OperationCodeConstants.Eq, 7 },
            { OperationCodeConstants.NEq, 7 },
            { OperationCodeConstants.LT, 7 },
            { OperationCodeConstants.LTE, 7 },
            { OperationCodeConstants.GT, 7 },
            { OperationCodeConstants.GTE, 7 },
            { OperationCodeConstants.And, 7 },
            { OperationCodeConstants.Or, 7 },
            { OperationCodeConstants.Nor, 7 },
            { OperationCodeConstants.Xor, 7 },
        };
    }
}
