namespace Snake.UI
{
    class Program
    {
        public static void Main()
        {
            var message = new ConsoleMessages();
            var action = new UserActions();

            message.InitialCommand();
            message.WriteStartCommadnInstructionMessage();
            message.WriteStopCommandInstructionMessage();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "-start")
                {
                    action.Start();
                }

                else if (command == "-stop")
                {
                    action.Stop();
                    break;
                }

                else
                {
                    message.WriteErrorCommandMessage();
                }
            }
        }
    }
}