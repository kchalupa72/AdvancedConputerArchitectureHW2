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

            var tempComponents = new List<string>();
            foreach (var component in instructionComponents)
            {
                tempComponents.Add(component.Trim(','));
            }

            Operation = tempComponents[0].ToLower();
            tempComponents.RemoveAt(0);

            Arguements = tempComponents;
        }
    }
}
