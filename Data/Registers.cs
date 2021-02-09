using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlazorApp.Data
{
    public class Registers
    {
        public Dictionary<string, Register> RegisterRepo = new Dictionary<string, Register>();

        private static string LastChangedRegister = String.Empty;

        public Registers() 
        {
            InstantiateRegisters();
        }

        public void InstantiateRegisters() 
        {
            foreach (FieldInfo field in typeof(RegisterIdentifierConstants).GetFields())
            {
                RegisterRepo.Add(field.GetValue(null).ToString(), new Register { Identifier = field.GetValue(null).ToString(), Value = 5, JustChanged = false });
            }
        }

        public int GetRegisterValue(string identifier) 
        {
            return RegisterRepo[identifier].Value;
        }

        public void ChangeRegisterValue(string identifier, int value) 
        {
            // update that the previous register is no longer Just Changed
            if (LastChangedRegister.Length > 0)
            {
                var lastRegister = RegisterRepo[LastChangedRegister];
                lastRegister.JustChanged = false;
            }

            var registerToChange = RegisterRepo[identifier];
            registerToChange.Value = value;
            registerToChange.JustChanged = true;
            LastChangedRegister = registerToChange.Identifier;
        }

    }
}
