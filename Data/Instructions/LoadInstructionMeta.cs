using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class LoadInstructionMeta
    {
        public string Operator { get; set; }
        public int BaseAddress { get; set; }
        public int Offset { get; set; }
        public int RegisterValue { get; set; }
        public string RegisterIdentifier { get; set; }
        public Func<int, int, int> ArithmeticFunction { get; set; }
    }
}
