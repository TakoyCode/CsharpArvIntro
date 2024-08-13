namespace OppgaveFormkontrollsystem
{
    internal class Circle : Shape
    {
        public int Radius { get; }

        public Circle(string name, string color, int radius) : base(name, color)
        {
            Radius = radius;
        }

        public override decimal CalculateArea()
        {
            return (3.14M * (Radius*Radius));
        }

       
    }
}
