using System;
using System.Linq;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class ExecutionManager
    {
        public RegisterManager RegisterManager;

        public MemoryManager MemoryManager;
        
        public ProvidedInstructionManager InstructionManager;

        public ApprovedInstruction LastExecutedInstruction;
        
        public ExecutionManager(RegisterManager _registers, ProvidedInstructionManager instructionManager, MemoryManager memoryManager) 
        {
            RegisterManager = _registers;
            InstructionManager = instructionManager;
            MemoryManager = memoryManager;
        }

        public void ExecuteNextIntsruction() 
        {
            LastExecutedInstruction = InstructionManager.GetNextInstruction();
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
            // Direct Instruction based on Type
            if (OperationArithmeticInstructions.ArithmeticInstructions.ContainsKey(instruction.Operation)) 
            {
                ExecuteArithmeticInstruction(instruction);
            }
            else if (OperationLoadInstructions.LoadInstructions.ContainsKey(instruction.Operation)) 
            {
                ExecuteLoadInstruction(instruction);
            }
        }

        private void ExecuteArithmeticInstruction(ApprovedInstruction instruction) 
        {
            Func<int, int, int> arithmeticFunction = null;
            Func<int, int, bool> conditionalFunction = null;


            //Includes Add and Addi
            if (OperationCodeConstants.Addi.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.AddFunction;
            }
            else if (OperationCodeConstants.Subi.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.SubtractFunction;
            }
            else if (OperationCodeConstants.Multi.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.MultiplyFunction;
            }
            else if (OperationCodeConstants.Divi.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.DivideFunction;
            }
            else if (OperationCodeConstants.Dup.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.DuplicateFunction;
            }
            else if (OperationCodeConstants.Doubl.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.DoubleFunction;
            }
            else if (OperationCodeConstants.Squar.Contains(instruction.Operation))
            {
                arithmeticFunction = ArithmeticFunctions.SquareFunction;
            }
            else if (OperationCodeConstants.Eq.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.EqualToFunction;
            }
            else if (OperationCodeConstants.NEq.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.NotEqualToFunction;
            }
            else if (OperationCodeConstants.LT.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.LessThanFunction;
            }
            else if (OperationCodeConstants.LTE.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.LessThanEqualFunction;
            }
            else if (OperationCodeConstants.GT.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.GreaterThanFunction;
            }
            else if (OperationCodeConstants.GTE.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.GreaterThanEqualFunction;
            }
            else if (OperationCodeConstants.And.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.AndFunction;
            }
            else if (OperationCodeConstants.Or.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.OrFunction;
            }
            else if (OperationCodeConstants.Nor.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.NorFunction;
            }
            else if (OperationCodeConstants.Xor.Contains(instruction.Operation))
            {
                conditionalFunction = ArithmeticFunctions.XorFunction;
            }

            var instructionMeta = GetInstructionMeta(instruction, arithmeticFunction, conditionalFunction);
            ExecuteArithmetic(instructionMeta);
        }

        private void ExecuteLoadInstruction(ApprovedInstruction instruction) 
        {
            var loadInstructionMeta = new LoadInstructionMeta()
            {
                RegisterValue = RegisterManager.GetRegisterValue(instruction.Arguements[0]),
                RegisterIdentifier = instruction.Arguements[0],
                Offset = int.Parse(instruction.Arguements[1]),
                BaseAddress = int.Parse(instruction.Arguements[2]),
            };
            
            if (OperationCodeConstants.Lw.Equals(instruction.Operation)) 
            {
                RegisterManager.ChangeRegisterValue(loadInstructionMeta.RegisterIdentifier, MemoryManager.GetMemoryAtAddress(loadInstructionMeta.BaseAddress + loadInstructionMeta.Offset));  
            }
            else if (OperationCodeConstants.Sw.Equals(instruction.Operation)) 
            {
                MemoryManager.SetMemoryAtAddress(loadInstructionMeta.BaseAddress + loadInstructionMeta.Offset, RegisterManager.GetRegisterValue(loadInstructionMeta.RegisterIdentifier));
            }
        }

        private ArithmeticInstructionMeta GetInstructionMeta(ApprovedInstruction instruction, Func<int, int, int> arithmeticFunction, Func<int, int, bool> conditionalFunction) 
        {
            var instructionOperator = instruction.Operation;
            var firstOperand = RegisterManager.GetRegisterValue(instruction.Arguements[0]);
            var secondOperand = (instruction.Operation.Last() == 'i') ? int.Parse(instruction.Arguements[1]) : RegisterManager.GetRegisterValue(instruction.Arguements[1]);
            var destinationIdentifier = instruction.Arguements[0];
            var isConditionalFunction = false;
            if (arithmeticFunction != null)
            {
                isConditionalFunction = false;
                conditionalFunction = ArithmeticFunctions.EqualToFunction;
            }
            else 
            {
                isConditionalFunction = true;
                arithmeticFunction = ArithmeticFunctions.AddFunction;
            }

            return new ArithmeticInstructionMeta()
            {
                Operator = instructionOperator,
                FirstOperand = firstOperand,
                SecondOperand = secondOperand,
                IsConditionalFunction = isConditionalFunction,
                ArithmeticFunction = arithmeticFunction,
                ConditionalFunction = conditionalFunction,
                Destination = firstOperand,
                DestinationIdentifier = destinationIdentifier
            };
        }

        private void ExecuteArithmetic(ArithmeticInstructionMeta arithmeticInstruction) 
        {
            var result = 0;
            if (!arithmeticInstruction.IsConditionalFunction)
            {
                result = arithmeticInstruction.ArithmeticFunction(arithmeticInstruction.FirstOperand, arithmeticInstruction.SecondOperand);
            }
            else 
            {
                result = (arithmeticInstruction.ConditionalFunction(arithmeticInstruction.FirstOperand, arithmeticInstruction.SecondOperand))? 1 : 0;
            }
            
            RegisterManager.ChangeRegisterValue(arithmeticInstruction.DestinationIdentifier, result);
        }


        public string GetBinaryExecutionRepresentation(ApprovedInstruction instruction) 
        {
            // opCode
            var opCodeBinaryString = InstructionManager.GetOpCodeBinary(instruction.Operation);
            
            // Operand 1
            var firstOperandCode = RegisterManager.GetRegisterCode(instruction.Arguements[0]);
            var firstOperandBinaryString = Util.GetBinaryString(firstOperandCode, 5);

            // Operand 2
            var secondOperandCode = RegisterManager.GetRegisterCode(instruction.Arguements[1]);
            var SecondOperandBinaryString = Util.GetBinaryString(firstOperandCode, 5);

            return "[ " + opCodeBinaryString + " ][ " + firstOperandBinaryString + " ][ " + SecondOperandBinaryString + " ]";
        }

        public bool EndOfInstructionSet()
        {
            return (InstructionManager.Instructions.Count <= InstructionManager.InstructionIndex);
        }
    }
}
