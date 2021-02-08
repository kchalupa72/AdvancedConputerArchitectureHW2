using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProvidedInstructions
    {
        private List<ProvidedInstruction> Instructions = new List<ProvidedInstruction>();

        public void AddInstruction(ProvidedInstruction instruction) 
        {
            Instructions.Add(instruction);
        }

        public void RemoveInstruction(ProvidedInstruction instruction) 
        {
            Instructions.Remove(instruction);
        }

        public List<ProvidedInstruction> GetAllInstructions() 
        {
            return Instructions;        
        }
    }
}
