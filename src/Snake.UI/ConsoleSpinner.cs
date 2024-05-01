namespace Snake.UI
{
    internal class ConsoleSpinner
    {
        private readonly string[,] sequence = null;

        public int Delay { get; set; } = 400;

        int sequences = 0;
        int counter;

        public ConsoleSpinner()
        {
            counter = 0;
            sequence = new string[,]
            {
                {"   ", ".  ", ".. ", "..." }
            };

            sequences = sequence.GetLength(0);
        }

        public void GetDotAnimation(string message = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > sequences - 1 ? 0 : sequenceCode;

            var counterValue = counter % 4;

            var fullMessage = message + sequence[sequenceCode, counterValue];
            var msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }
    }
}