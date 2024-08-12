using System.Text;

namespace OppgaveAbaxrekruttering
{
    internal class Car : Vehicle
    {
        private int _maxSpeed;
        private string _color;
        private string _type;

        public Car(string registrationPlate, int effect, int maxSpeed, string color, string type) : base(registrationPlate, effect)
        {
            _maxSpeed = maxSpeed;
            _color = color;
            _type = type;
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine($", {_maxSpeed}km/t, {_color} color, of type {_type}");
        }

        public void Compare(Car otherCar)
        {
            if (Equals(otherCar))
            {
                Console.WriteLine("The cars are the same car!");
            }
            else
            {
                Console.WriteLine("The cars are not the same car");
            }
        }

        public void Drive()
        {
            Console.WriteLine("The motor starts and the car drives away!");
        }

    }
}

