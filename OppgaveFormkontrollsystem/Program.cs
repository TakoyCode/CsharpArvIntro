namespace OppgaveFormkontrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            [
                new Circle("pizza", "yellow", 4),
                new Circle("plate", "turquoise", 4),
                new Rectangle("bookshelf", "brown", 10, 4),
                new Rectangle("monitor", "black", 3, 5),
                new Triangle("picture", "blue", 7, 5),
                new Triangle("clothes hanger", "white", 6, 4),
            ];

            GetShapesInfo(shapes);
            GetTotalArea();
            SortShapesByArea();
            SortShapesByColor();

            void SortShapesByColor()
            {
                var orderedShapes = shapes.OrderBy(s => s.Color).ToArray();
                GetShapesInfo(orderedShapes);
            }

            void SortShapesByArea()
            {
                var orderedShapes = shapes.OrderBy(s => s.CalculateArea()).ToArray();
                GetShapesInfo(orderedShapes);
            }

            void GetShapesInfo(Shape[] shapesArray)
            {
                foreach (var shape in shapesArray)
                {
                    var area = shape.CalculateArea();
                    Console.WriteLine($"Name: {shape.Name} --- Color: {shape.Color} --- Area: {area}m2");
                }
            }

            void GetTotalArea()
            {
                decimal totalArea = 0;
                foreach (var shape in shapes)
                {
                    totalArea += shape.CalculateArea();
                }
                Console.WriteLine($"The total area of all shapes is {totalArea}m2");
            }


        }

       
    }
}
