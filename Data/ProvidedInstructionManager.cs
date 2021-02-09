using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
    public class ProvidedInstructionManager
    {
        public List<ApprovedInstruction> Instructions = new List<ApprovedInstruction>();

        public int InstructionIndex = 0;

        public void FilterInstructions(List<string> instructionsGiven) 
        {
            foreach (var instruction in instructionsGiven)
            {
                if (IsInstructionValid(instruction.Trim())) 
                {
                    var tempInstruction = new ApprovedInstruction(instruction);
                    Instructions.Add(tempInstruction);
                }
            }
        }

        private bool IsInstructionValid(string instructionGiven) 
        {
            var instructionComponents = instructionGiven.Split(' ').ToList();

            // get Op Code of instruction statement
            var opCode = instructionComponents[0];


            // check if operation code exist
            return MipsInstructions.Instructions.ContainsKey(opCode);
        }



    }
}
