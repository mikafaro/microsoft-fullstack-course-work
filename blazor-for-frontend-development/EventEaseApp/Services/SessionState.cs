using System;

namespace EventEaseApp.Services
{
    public class SessionState
    {
        // Example state properties
        public string? Username { get; private set; }
        public bool IsAuthenticated { get; private set; }

        // Event for state change notification
        public event Action? OnChange;

        public void SetUser(string username)
        {
            Username = username;
            IsAuthenticated = true;
            NotifyStateChanged();
        }

        public void ClearUser()
        {
            Username = null;
            IsAuthenticated = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
