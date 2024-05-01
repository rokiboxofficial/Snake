namespace Snake.UI
{
    public class UserActions
    {
        public void Start()
        {
            Console.Clear();

            ConsoleSpinner spinner = new ConsoleSpinner();

            while (true)
            {
                spinner.GetAnimation(displayMsg: "Пожалуйста подождите", sequenceCode: 1);
            }
        }

        public void Stop()
        {
            Console.Clear();
            Console.WriteLine("Stop");
        }
    }
}