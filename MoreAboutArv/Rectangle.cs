namespace MoreAboutArv
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height) : base()
        {
            _width = width;
            _height = height;
            Console.WriteLine("Rectangle ctor (int, int)");
        }

        public Rectangle(int side) : this(side, side)
        {
            Console.WriteLine("Rectangle ctor (int)");
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override void Show()
        {
            Console.WriteLine("|---|");
            Console.WriteLine("|   |");
            Console.WriteLine("|   |");
            Console.WriteLine("|---|");
        }
    }
}
