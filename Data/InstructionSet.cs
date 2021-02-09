using System.Collections.Generic;

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
