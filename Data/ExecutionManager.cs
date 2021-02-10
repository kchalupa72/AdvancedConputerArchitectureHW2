using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class ExecutionManager
    {
        public Registers registers;
        
        public ProvidedInstructionManager InstructionManager;
        
        public ExecutionManager(Registers _registers, ProvidedInstructionManager instructionManager) 
        {
            registers = _registers;
            InstructionManager = instructionManager;
        }

        public void ExecuteNextIntsruction() 
        {
            ExecuteInstruction(InstructionManager.GetNextInstruction());
            InstructionManager.InstructionIndex++;
        }

        public void ExecuteInstructions(List<ApprovedInstruction> instructions ) 
        {
            foreach (var instruction in instructions) 
            {
                ExecuteInstruction(instruction);
            }
        }

        public void ExecuteInstruction(ApprovedInstruction instruction) 
        {

            //TODO Clean up code to better organize handling instruction execution, probably with Func or Delegates
            if (instruction.Operation == OperationCodeConstants.Add)
            {
                var firstRegisterIdentifier = instruction.Arguements[0];
                var secondRegisterIdentifier = instruction.Arguements[1];
                var firstRegisterValue = registers.GetRegisterValue(firstRegisterIdentifier);
                var secondRegisterValue = registers.GetRegisterValue(secondRegisterIdentifier);

                var sum = firstRegisterValue + secondRegisterValue;
                registers.ChangeRegisterValue(firstRegisterIdentifier, sum);
            }
            else if (instruction.Operation == OperationCodeConstants.Sub)
            {
                var firstRegisterIdentifier = instruction.Arguements[0];
                var secondRegisterIdentifier = instruction.Arguements[1];
                var firstRegisterValue = registers.GetRegisterValue(firstRegisterIdentifier);
                var secondRegisterValue = registers.GetRegisterValue(secondRegisterIdentifier);

                var sum = firstRegisterValue - secondRegisterValue;
                registers.ChangeRegisterValue(firstRegisterIdentifier, sum);
            }
            else if (instruction.Operation == OperationCodeConstants.Incr)
            {
                var firstRegisterIdentifier = instruction.Arguements[0];
                var firstRegisterValue = registers.GetRegisterValue(firstRegisterIdentifier);
                var sum = AddInstructionsUtil.Incr(firstRegisterValue);
                registers.ChangeRegisterValue(firstRegisterIdentifier, sum);
            }
        }

        public bool EndOfInstructionSet()
        {
            return (InstructionManager.Instructions.Count <= InstructionManager.InstructionIndex);
        }
    }
}
