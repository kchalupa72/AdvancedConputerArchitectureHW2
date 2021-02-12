using BlazorApp.Data.Instructions;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class InstructionSet
    {
        public List<OperationInstruction> Instructions { get; set; }

        public InstructionSet(bool useMips) 
        {
            Instructions = GetInstructionSet();
        }

        private List<OperationInstruction> GetInstructionSet() 
        {
            return OperationInstructions.Instructions;
        }

        private Dictionary<string, string> GetMipsInstructions() 
        {
            return MipsInstructions.Instructions;
        }


    }
}
