using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data.Instructions
{
    public class OperationInstruction
    {
        public string OpName { get; set; }

        public int OpCode { get; set; }
        public string Description { get; set; }

    }
}
