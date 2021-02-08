using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProvidedInstructionManager
    {
        private List<ProvidedInstruction> Instructions = new List<ProvidedInstruction>();

        public void FilterInstructions(List<string> instructionsGiven) 
        {
            foreach (var instruction in instructionsGiven)
            {
                if (IsInstructionValid(instruction)) 
                {
                    var tempInstruction = new ProvidedInstruction(instruction);
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
