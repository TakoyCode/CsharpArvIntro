namespace OppgaveAbaxrekruttering
{
    internal class Boat : Vehicle
    {
        private int _maxSpeed;
        private int _grossTonnage;

        public Boat(string registrationPlate, int effect, int maxSpeed, int grossTonnage) : base(registrationPlate, effect)
        {
            _maxSpeed = maxSpeed;
            _grossTonnage = grossTonnage;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", max speed {_maxSpeed} knots, {_grossTonnage}kg gross tonnage");
        }
    }
}
