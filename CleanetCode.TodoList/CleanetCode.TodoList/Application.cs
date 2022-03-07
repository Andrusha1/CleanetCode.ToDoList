namespace CleanetCode.TodoList
{
    public class Application
    {
        private readonly Menu _menu;
        public Application(Menu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
            bool userQuit= false;
            
            while (!userQuit)
            {
                List<string> operationNames = new List<string>();
                //Не получается выводить имя текущего юзера.
                if (UserSession.CurrentUser == null)
                    operationNames.Add($"Current user: Not login");
                else
                    operationNames.Add($"Current user: {UserSession.CurrentUser.Email.ToString()}\n");
                operationNames.Add("q - close program");
                operationNames.AddRange(_menu.GetOperationNames());

                Console.WriteLine(String.Join("\n", operationNames));
                Console.WriteLine("Enter operation number: ");

                string? userInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(userInput) && userInput.Trim().ToLower() == "q")
                {
                    userQuit = true;
                }
                else
                {
                    bool isNumber = int.TryParse(userInput, out int operationNumber);
                    if (isNumber)
                    {
                        _menu.Enter(operationNumber);
                    }
                }
            }
            
        }
    }
}