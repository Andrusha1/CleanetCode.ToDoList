using System.IO;
using CleanetCode.TodoList.Models;

namespace CleanetCode.TodoList.Storages
{
    public static class UserStorage
    {
        private static readonly Dictionary<string, User> _users = new ();

        public static User? Get(string email)
        {
            _users.TryGetValue(email, out User? user);
            return user;
        }

        public static bool Create(User user)
        {
            File.AppendAllText("Users.txt", $"{user.Email}\n");
            return _users.TryAdd(user.Email, user);
        }
    }
}