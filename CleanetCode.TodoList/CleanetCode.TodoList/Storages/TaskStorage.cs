using CleanetCode.TodoList.Models;

namespace CleanetCode.TodoList.Storages
{
    public class TaskStorage
    {
        private static readonly Dictionary<string, UsersTask> _tasks = new();

        public static UsersTask? Get(string task)
        {
            _tasks.TryGetValue(task, out UsersTask? usrtask);
            return usrtask;
        }

        public static bool Create(UsersTask task)
        {
            _tasks.TryAdd(task.Name, task);
            _tasks.TryAdd(task.Description, task);

            File.AppendAllText("tasks.txt", $"{task.Name}\n");
            return _tasks.TryAdd(task.Name, task) && _tasks.TryAdd(task.Description, task);
        }
    }
}