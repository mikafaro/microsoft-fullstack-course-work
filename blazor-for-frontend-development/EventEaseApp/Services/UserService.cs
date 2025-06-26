using System.Collections.Generic;
using System.Linq;
using EventEaseApp.Models;

// For in-memory storage of user registrations. Obviously just for the purpose of managing user info in a mock app.
// Not focused on secure storage of user information.

namespace EventEaseApp.Services
{
    public class UserService
    {
        private readonly List<UserDetails> users = new();

        public async Task<bool> RegisterUserAsync(UserDetails user)
        {
            // Simulate async work (e.g., database call)
            await Task.Yield();

            if (users.Any(u => u.Username == user.Username))
            return false; // Username taken

            users.Add(user);
            return true;
        }

        public bool ValidateLogin(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }
    }
}