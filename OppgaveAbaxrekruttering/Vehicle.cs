using System.Drawing;

namespace OppgaveAbaxrekruttering
{
    internal abstract class Vehicle
    {
        private string RegistrationPlate;

        private int Effect;

        protected Vehicle(string registrationPlate, int effect)
        {
            RegistrationPlate = registrationPlate;
            Effect = effect;
        }

        public virtual void Show()
        {
            Console.Write($"reg. nr {RegistrationPlate}, {Effect}kw effect");
        }
    }
}
