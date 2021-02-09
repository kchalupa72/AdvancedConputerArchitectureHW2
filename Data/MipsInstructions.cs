using System.Collections.Generic;

namespace BlazorApp.Data
{
    public static class MipsInstructions
    {
        public static Dictionary<string, string> Instructions = new Dictionary<string, string>() 
        {
            { MIPSOperationCodeConstants.Add, "Add $s1 $s2 $s3" },
            { MIPSOperationCodeConstants.Sub, "Sub $s1 $s2 $s3" },
        };
    }
}
