using BlazorApp.Data.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class OperationInstructions
    {
        public static List<OperationInstruction> Instructions = new List<OperationInstruction>()
        {
            new OperationInstruction() { OpName = OperationCodeConstants.Add, OpCode = 1, Description = "Add $s1 $s2" },
            new OperationInstruction() { OpName = OperationCodeConstants.Sub, OpCode = 2, Description = "Sub $s1 $s2" },
            new OperationInstruction() { OpName = OperationCodeConstants.Mult, OpCode = 3, Description = "Mul $s1 $s2 $s3" },
            new OperationInstruction() { OpName = OperationCodeConstants.Div, OpCode = 4, Description = "Div $s1 $s2 $s3" },
            new OperationInstruction() { OpName = OperationCodeConstants.Addi, OpCode = 5, Description = "Addi $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Subi, OpCode = 6, Description = "Subi $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Multi,OpCode = 7, Description = "Multi $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Divi, OpCode = 8, Description = "Divi $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Dup, OpCode = 9, Description = "Dup $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Doubl, OpCode = 10, Description = "Doubl $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Squar, OpCode = 11, Description = "Squar $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Eq, OpCode = 12, Description = "Eq $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.NEq, OpCode = 13, Description = "Neq $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.LT, OpCode = 14, Description = "LT $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.LTE, OpCode = 15, Description = "LTE $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.GT, OpCode = 16, Description = "GT $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.GTE, OpCode = 17, Description = "GTE $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.And, OpCode = 18, Description = "And $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Or, OpCode = 19, Description = "Or $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Nor, OpCode = 20, Description = "Nor $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Xor, OpCode = 21, Description = "Xor $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Lw, OpCode = 22, Description = "Lw $s1 $v" },
            new OperationInstruction() { OpName = OperationCodeConstants.Sw, OpCode = 23, Description = "Sw $s1 $v" },
        };
    }
}
