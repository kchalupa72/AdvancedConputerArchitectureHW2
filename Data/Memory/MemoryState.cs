using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class MemoryState
    {
        public event Action OnChange;

        public bool ResetMemory = false;

        public bool MemoryChanged { get; private set; }
        
        public void MemoryStateChanged() 
        {
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
