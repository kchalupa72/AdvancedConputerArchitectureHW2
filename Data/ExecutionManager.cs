using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ExecutionManager
    {
        public Registers registers;
        public ExecutionManager(Registers _registers) 
        {
            registers = _registers;
        }

        public void ExecuteInstruction(ApprovedInstruction instruction) 
        {

            if (instruction.Operation == OperationCodeConstants.Incr)
            {
                var firstRegisterIdentifier = instruction.Arguements[0];
                var firstRegisterValue = registers.GetRegisterValue(firstRegisterIdentifier);
                var sum = AddInstructionsUtil.Incr(firstRegisterValue);
                registers.ChangeRegisterValue(firstRegisterIdentifier, sum);
            }
        }
    }
}
