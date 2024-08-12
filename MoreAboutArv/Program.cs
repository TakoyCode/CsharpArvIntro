namespace MoreAboutArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(10);
            
            // Ikke mulig å lage ett objekt av en klasse som er abstract eks.:
            // var shape = new Shape();

            Console.WriteLine(square.Area());
            square.Show();

            // Ikke bruk new, i stedet for override
            // Rectangle r = square;
            // Console.WriteLine(r.Area());
        }
    }
}
