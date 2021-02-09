using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
    public class ApprovedInstruction
    {
        public string Operation { get; set; }

        public List<string> Arguements { get; set; }

        public bool IsNext = false;

        public ApprovedInstruction(string instructionGiven) 
        {
            var instructionComponents = instructionGiven.Split(' ').ToList();

            Operation = instructionComponents[0];
            instructionComponents.RemoveAt(0);

            Arguements = instructionComponents;
        }
    }
}
