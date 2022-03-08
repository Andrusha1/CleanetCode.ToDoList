using CleanetCode.TodoList.Models;
using CleanetCode.TodoList.Storages;

namespace CleanetCode.TodoList.Operations
{
    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new User";

        public void Execute()
        {
            Console.WriteLine("Enter your email:");
            string? email = Console.ReadLine();

            User newUser = new User
            {
                Email = email,
            };

            bool userCreated = UserStorage.Create(newUser);
            if (!userCreated)
            {
                Console.WriteLine("User with this email already created");
            }
            

            Console.WriteLine("User created successful");
        }
    }
}