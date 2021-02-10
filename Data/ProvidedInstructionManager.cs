using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
    public class ProvidedInstructionManager
    {
        public List<ApprovedInstruction> Instructions = new List<ApprovedInstruction>();

        public int InstructionIndex = 0;

        public void ProcessInstructions(string instructionsGiven)
        {
            ResetInstructions();

            //Split the instructions
            List<string> splitInstructions = SplitInstructions(instructionsGiven);

            //Filter Instructions and test the syntax 
            foreach (var instruction in splitInstructions)
            {
                if (IsInstructionValid(instruction.Trim()))
                {
                    var tempInstruction = new ApprovedInstruction(instruction);
                    Instructions.Add(tempInstruction);
                }
            }            
        }

        private void ResetInstructions() 
        {
            //Clear old instructions 
            Instructions.Clear();

            //Reset the index of the Instruction Set
            InstructionIndex = 0;
        }

        private static List<string> SplitInstructions(string instructionsGiven)
        {
            var instructions = instructionsGiven.Split(new char[] { ';', '\n' }).ToList();
            instructions.RemoveAll(i => string.IsNullOrEmpty(i));
            return instructions;
        }

        private static bool IsInstructionValid(string instructionGiven)
        {
            var instructionComponents = instructionGiven.Split(' ').ToList();

            // get Op Code of instruction statement
            var opCode = instructionComponents[0];

            // check if operation code exist
            return MipsInstructions.Instructions.ContainsKey(opCode);
        }

        public ApprovedInstruction GetNextInstruction()
        {
            return Instructions.ElementAt(InstructionIndex);
        }

        public string StringifyInstruction(ApprovedInstruction instruction)
        {
            var stringInstruction = instruction.Operation;
            instruction.Arguements.ForEach(arg => stringInstruction = stringInstruction + " " + arg);
            return stringInstruction;
        }

        public void AssignNewInstructions(List<ApprovedInstruction> newInstructions) 
        {
            Instructions = newInstructions;
        }
    }
}
