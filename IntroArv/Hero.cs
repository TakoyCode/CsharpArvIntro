namespace IntroArv
{
    internal class Hero : GameCharacter
    {
        public Hero(int health, int stamina, int strength) : base(health,stamina)
        {
            Strength = strength;
        }

        public override void Fight(GameCharacter opponent)
        {
            opponent.LooseHealth(Strength);
        }
    }
}
