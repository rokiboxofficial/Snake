namespace Snake.UI
{
    internal class ConsoleSpinner
    {
        private readonly string[,] sequence = null;

        public int Delay { get; set; } = 400;

        int totalSequences = 0;
        int counter;

        public ConsoleSpinner()
        {
            counter = 0;
            sequence = new string[,]
            {
                {"   ", ".  ", ".. ", "..." }
            };

            totalSequences = sequence.GetLength(0);
        }

        public void GetAnimation(string displayMsg = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

            int counterValue = counter % 4;

            string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
            int msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }
    }
}
