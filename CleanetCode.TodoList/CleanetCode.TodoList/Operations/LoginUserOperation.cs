using CleanetCode.TodoList.Models;
using CleanetCode.TodoList.Storages;

namespace CleanetCode.TodoList.Operations
{
    public class LoginUserOperation : IOperation
    {
        public string Name => "Login into the system";

        public void Execute()
        {
            Console.WriteLine("Enter user email to log in");
            string email = Console.ReadLine();
            User? user = UserStorage.Get(email);

            if (user != null)
            {
                UserSession.CurrentUser = user;
            }
        }
    }
}