using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class InstructionSet
    {
        public Dictionary<string, string> Instructions { get; set; }

        public InstructionSet(bool useMips = true) 
        {
            Instructions = (useMips) ? GetMipsInstructions(): GetInstructionSet() ;
        }

        private Dictionary<string, string> GetInstructionSet() 
        {
            Dictionary<string, string> instructions = new Dictionary<string, string>();
            return instructions;
        }

        private Dictionary<string, string> GetMipsInstructions() 
        {
            return MipsInstructions.Instructions;
        }


    }
}
