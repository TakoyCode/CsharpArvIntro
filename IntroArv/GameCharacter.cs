namespace IntroArv
{
    internal abstract class GameCharacter
    {
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int MaxStamina { get; set; }
        public int MaxHealth { get; set; }

        public GameCharacter(int health, int stamina)
        {
            Health = MaxHealth = health;
            Stamina = MaxStamina = stamina;
        }

        public abstract void Fight(GameCharacter opponent);

        public void LooseHealth(int strength)
        {
            Health -= strength;
        }

        public void Recharge()
        {
            Stamina = MaxStamina;
        }

    }
}
