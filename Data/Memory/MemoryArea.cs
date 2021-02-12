using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class MemoryArea
    {
        private Dictionary<int, int> Memory = new Dictionary<int, int>();

        public int? LastChangedMemoryBlock = null;

        public MemoryArea()
        {
            InstantiateMemory();
        }

        private void InstantiateMemory() 
        {
            var index = 0;
            while (index < 100)
            {
                Memory.Add(index, 0);
                index += 4;
            }
        }

        public int GetMemoryAtAddress(int address) 
        {
            return Memory[address];
        }

        public void SetMemoryAtAddress(int address, int value) 
        {
            Memory[address] = value;
            LastChangedMemoryBlock = address;
        }

        public Dictionary<int, int> GetMemory() 
        {
            Dictionary<int, int> tempMemory = Memory;
            return tempMemory;
        }
    }
}
