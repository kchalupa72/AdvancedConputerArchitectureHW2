using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public static class AddInstructionsUtil
    {
        public static int Add(int firstValue, int secondValue) 
        {
            return firstValue + secondValue;
        }

        public static int Incr(int registerValue) 
        {
            return registerValue++;
        }
    }
}
