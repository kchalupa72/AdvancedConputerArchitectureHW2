using System;

namespace BlazorApp.Data
{
    public class RegisterState
    {
        public event Action OnChange;

        public bool ResetRegisters = false;

        public bool RegistersChanged { get; private set; }

        public void RegistersStateChanged() 
        {
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
