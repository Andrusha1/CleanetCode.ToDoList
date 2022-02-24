using CleanetCode.TodoList.Operations;

namespace CleanetCode.TodoList
{
    public class Menu
    {
        private IOperation[] _operations;

        public Menu(IOperation[] operations)
        {
            _operations = operations;
        }
    }
}