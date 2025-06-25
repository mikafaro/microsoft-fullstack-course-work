using System.Collections.Generic;
using System.Linq;
using EventEaseApp.Models;

public class UserService
{
    private readonly List<UserDetails> users = new();

    public bool Register(string username, string email, string password)
    {
        if (users.Any(u => u.Username == username))
            return false; // Username taken

        users.Add(new UserDetails { Username = username, Email = email, Password = password });
        return true;
    }

    public bool ValidateLogin(string username, string password)
    {
        return users.Any(u => u.Username == username && u.Password == password);
    }
}