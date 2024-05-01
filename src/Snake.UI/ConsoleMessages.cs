namespace Snake.UI
{
    internal class ConsoleMessages
    {
        public void InitialCommand()
        {
            Console.WriteLine("Привет! Введите пожалуйста своё имя!");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Вы зашли под именем {name}");
        }

        public void WriteStartCommadnInstructionMessage()
        {
            Console.WriteLine("Введите -start, что бы начать поиск игры");
        }

        public void WriteStopCommandInstructionMessage()
        {
            Console.WriteLine("Введите -stop, что бы прекратить поиск игры");
        }

        public void WriteErrorCommandMessage()
        {
            Console.WriteLine("Error! Команада не найдена!");
        }
    }
}
