namespace CleanetCode.TodoList.Operations
{
    public interface IOperation
    {
        string Name { get; }

        void Execute();
    }
}