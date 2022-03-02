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
                new LoginUserOperation()
            };
            Menu menu = new Menu(operations);
            Application application = new Application(menu);
            application.Run();
        }
    }
}