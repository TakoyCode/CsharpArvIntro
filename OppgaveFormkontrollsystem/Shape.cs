namespace OppgaveFormkontrollsystem
{
    internal abstract class Shape
    {
        public string Name { get; }
        public string Color { get; }

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract decimal CalculateArea();

    }
}
