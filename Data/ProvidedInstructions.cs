using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProvidedInstructions
    {
        private List<ApprovedInstruction> Instructions = new List<ApprovedInstruction>();

        public void AddInstruction(ApprovedInstruction instruction) 
        {
            Instructions.Add(instruction);
        }

        public void RemoveInstruction(ApprovedInstruction instruction) 
        {
            Instructions.Remove(instruction);
        }

        public List<ApprovedInstruction> GetAllInstructions() 
        {
            return Instructions;        
        }
    }
}
