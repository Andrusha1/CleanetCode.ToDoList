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

        internal void ShowTasks()
        {
            List<string> tasks = new List<string>();
            if (_tasks.Count > 0)
            {
                foreach (var curtask in _tasks.Values)
                {
                    tasks.Add(curtask.Name);
                }
                foreach (string task in tasks)
                    Console.WriteLine($"{task}");
            }
            else
            {
                Console.WriteLine("Task list is empty!\n");
            }
            

            //foreach (var task in tasks)
            //    tasks.Add($"{task}\n ");
            //Console.WriteLine(tasks);
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