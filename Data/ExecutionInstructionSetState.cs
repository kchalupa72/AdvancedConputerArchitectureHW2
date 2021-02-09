using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class ExecutionInstructionSetState
    {
        public event Action OnChange;

        public List<ApprovedInstruction> Instructions = new List<ApprovedInstruction>();

        public void SetExecutingInstructionSet(List<ApprovedInstruction> instructions) 
        {
            Instructions = instructions;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
