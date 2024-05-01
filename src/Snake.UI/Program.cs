namespace Snake.UI
{
    class Program
    {
        public static void Main()
        {
            var message = new ConsoleMessages();
            var action = new UserActions(message);

            message.InitialCommand();

            while (true)
            {
                message.WriteStartCommadnInstructionMessage();
                message.WriteStopCommandInstructionMessage();

                var command = Console.ReadLine();

                if (command == "start")
                    action.Start();

                else if (command == "stop")
                    action.Stop();

                else
                    message.WriteErrorCommandMessage();
            }
        }
    }
}