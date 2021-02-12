using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class MemoryManager
    {
        public MemoryArea MemoryArea = new MemoryArea();

        public MemoryState MemoryState;

        public MemoryManager(MemoryState memoryState) 
        {
            MemoryState = memoryState;
        }

        public int GetMemoryAtAddress(int address) 
        {
            return MemoryArea.GetMemoryAtAddress(address);           
        }

        public void SetMemoryAtAddress(int address, int value) 
        {
            MemoryArea.SetMemoryAtAddress(address, value);
            MemoryState.MemoryStateChanged();
        }

        public Dictionary<int, int> GetMemory() 
        {
            return MemoryArea.GetMemory();
        }

        public void ResetMemory() 
        {
            MemoryArea = new MemoryArea();
        }

    }
}
