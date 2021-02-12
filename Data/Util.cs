using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public static class Util
    {

        public static string GetBinaryString(int num, int length = 32) 
        {
            var binaryString = Convert.ToString(num, 2);


            for (int i = binaryString.Length; i < length; i ++) 
            {
                binaryString = binaryString.Insert(0, "0");
            }

            return binaryString;
        }
    }
}
