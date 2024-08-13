namespace OppgaveFormkontrollsystem
{
    internal class Triangle : Shape

    {
        public int Base { get; }
        public int Height { get; }

        public Triangle(string name, string color, int @base , int height) : base(name, color)
        {
            Base = @base;
            Height = height;
        }

        public override decimal CalculateArea()
        {
            return (0.5M * (Base * Height));
        }
    }
}
