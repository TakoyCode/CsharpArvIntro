namespace RemoveIfStatementsViaInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var men = new[]
            {
                new WavingMan(10, 1),
                new LeftHandedWavingMan(20, 1)
            };

            while (true)
            {
                Console.Clear();
                foreach (var man in men)
                {
                    man.Show();
                    man.Wave();
                }

                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                Thread.Sleep(500);
            }
        }
    }
}
