using CleanetCode.TodoList.Models;
using CleanetCode.TodoList.Storages;

namespace CleanetCode.TodoList.Operations
{
    public class CreateNewTaskOperation : IOperation
    {
        public string Name => "Create new task";

        public void Execute()
        {
            Console.Write("Введите название задачи\n");
            string? taskName = Console.ReadLine();
            Console.Write("Введите описание задачи\n");
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