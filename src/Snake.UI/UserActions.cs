namespace Snake.UI
{
    internal class UserActions
    {
        private readonly ConsoleMessages _consoleMessages;

        public UserActions(ConsoleMessages consoleMessages)
        {
            _consoleMessages = consoleMessages;
        }

        public void Start()
        {
            Console.Clear();

            ConsoleSpinner spinner = new ConsoleSpinner();

            _consoleMessages.WriteStopCommandInstructionMessage();

            while (true)
            {
                spinner.GetDotAnimation(message: "Идёт поиск, пожалуйста подождите", sequenceCode: 1);

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}