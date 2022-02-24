using CleanetCode.TodoList.Operations;

IOperation[] operations = new IOperation[]
{
    new CreateNewUserOperation(),
    new LoginUserOperation()
};

foreach (IOperation operation in operations)
{
    operation.Execute();
}
