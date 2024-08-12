namespace MoreAboutArv
{
    public class Square : Rectangle
    {
        private int _side;

        // base sin constructor blir utført før Square sin constructor
        public Square(int side) : base(side)
        {
            _side = side;
            Console.WriteLine("Square ctor");
        }

        public override double Area()
        {
            // base. kan kalle på metoden du ville har arvet, sånn at du kan utvide funksjonalitet til den orginale metoden
            var area = base.Area();
            area += 10;
            return area;
        }
    }
}
