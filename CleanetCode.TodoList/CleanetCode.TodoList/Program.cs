using CleanetCode.TodoList.Operations;

namespace CleanetCode.TodoList
{
    class Program
    {
        public static void Main()
        {
            IOperation[] operations = new IOperation[] 
            {
                new CreateNewUserOperation(),
                new CreateNewTaskOperation(),
                new LoginUserOperation(),
                new ShowTasksOperation(),
                new CompleteTaskOperation(),
                new UpdateTaskOperation(),
                new DeleteTaskOperation()
            };
            Menu menu = new Menu(operations);
            Application application = new Application(menu);
            application.Run();
        }
    }
}