using CleanetCode.TodoList.Models;
using CleanetCode.TodoList.Storages;

namespace CleanetCode.TodoList.Operations
{
    public class ShowTasksOperation : IOperation
    {
        public string Name => "Show tasks";

        public void Execute()
        {
            TaskStorage tasksStr = new TaskStorage();
            tasksStr.ShowTasks();
        }
    }
}