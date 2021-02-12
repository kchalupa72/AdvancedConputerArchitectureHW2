using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class OperationLoadInstructions
    {
        public static Dictionary<string, int> LoadInstructions = new Dictionary<string, int>()
        {
            { OperationCodeConstants.Lw, 8 },
            { OperationCodeConstants.Sw, 9 },
            { OperationCodeConstants.Sw, 9 },
            { OperationCodeConstants.Sw, 9 },
        };
    }
}
