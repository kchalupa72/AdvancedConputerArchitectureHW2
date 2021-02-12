using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ArithmeticInstructionMeta
    {
        public string Operator { get; set; }
        public int FirstOperand { get; set; }
        public int SecondOperand { get; set; }
        public int Destination { get; set; }
        public string DestinationIdentifier { get; set; }
        public bool IsConditionalFunction { get; set; }
        public Func<int, int, int> ArithmeticFunction { get; set; }
        public Func<int, int, bool> ConditionalFunction { get; set; }

    }
}
