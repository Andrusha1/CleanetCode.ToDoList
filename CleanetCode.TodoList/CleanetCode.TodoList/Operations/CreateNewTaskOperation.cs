using CleanetCode.TodoList.Models;
using CleanetCode.TodoList.Storages;

namespace CleanetCode.TodoList.Operations
{
    public class CreateNewTaskOperation : IOperation
    {
        public string Name => "Create new task";

        public void Execute()
        {
            Console.Write("Enter task name:\n");
            string? taskName = Console.ReadLine();
            Console.Write("Enter task discription:\n");
            string? taskDescript = Console.ReadLine();

            UsersTask task = new UsersTask
            {
                Name = taskName,
                Description = taskDescript,
                IsCompleted = false,
                CreatedDate = DateTime.Now,
            };

            bool taskCreated = TaskStorage.Create(task);
            if (!taskCreated)
                Console.WriteLine("Task with that name already created");
            else
                Console.WriteLine("Task created successful");
        }
    }
}