namespace CleanetCode.TodoList.Operations
{
    public class CompleteTaskOperation : IOperation
    {
        string IOperation.Name => "Mark task as complete";

        public void Execute()
        {
            
        }

        void IOperation.Execute()
        {
            throw new NotImplementedException();
        }
    }
}