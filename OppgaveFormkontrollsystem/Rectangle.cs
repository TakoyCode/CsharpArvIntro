namespace OppgaveFormkontrollsystem
{
    internal class Rectangle : Shape
    {
        public int Length { get; }
        public int Width { get; }


        public Rectangle(string name, string color, int length, int width) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        public override decimal CalculateArea()
        {
            return Length * Width;
        }
    }
}
