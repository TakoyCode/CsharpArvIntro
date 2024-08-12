namespace OppgaveAbaxrekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("NF123456", 147, 200, "green", "light vehicle");
            var car2 = new Car("NF654321", 150, 195, "blue", "light vehicle");
            var jet = new Plane("LN1234", 1000, 30, 2, 10, "jet");
            var boat = new Boat("ABC123", 100, 30, 500);

            car1.Show();
            car2.Show();
            car1.Compare(car1);

            jet.Show();

            car1.Drive();
            jet.Fly();

            boat.Show();
        }
    }
}
