using System.Drawing;

namespace OppgaveAbaxrekruttering
{
    internal class Plane : Vehicle
    {
        private int _wingSpan;
        private int _loadCapacity;
        private int _ownWeight;
        private string _planeClass;

        public Plane(string registrationPlate, int effect, int wingSpan, int loadCapacity, int ownWeight, string planeClass) : base(registrationPlate, effect)
        {
            _wingSpan = wingSpan;
            _loadCapacity = loadCapacity;
            _ownWeight = ownWeight;
            _planeClass = planeClass;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", {_wingSpan}m wingspan, {_loadCapacity} ton load capacity, {_ownWeight} ton own weight, of class {_planeClass}");
        }

        public void Fly()
        {
            Console.WriteLine("The motor starts and the plane flies away!");
        }
    }
}
