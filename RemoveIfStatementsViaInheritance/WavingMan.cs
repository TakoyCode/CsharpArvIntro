namespace RemoveIfStatementsViaInheritance
{
    internal class WavingMan
    {
        protected bool _armIsUp;
        protected readonly int _x;
        protected readonly int _y;

        public WavingMan(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Wave()
        {
            _armIsUp = !_armIsUp;
        }

        public void Show()
        {
            Console.CursorTop = _y;
            Console.CursorLeft = _x;
            WriteHead();
            Console.CursorLeft = _x;
            WriteBody();
            Console.CursorLeft = _x;
            Console.Write("/ \\");
        }

        protected virtual void WriteBody()
        {
            Console.WriteLine(_armIsUp ? " |\\ " : "/|\\");
        }

        protected virtual void WriteHead()
        {
            Console.WriteLine(_armIsUp ? "\\o " : " o");
        }

    }
}
