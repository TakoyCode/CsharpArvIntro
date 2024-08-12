namespace IntroArv
{
    internal class Boss : GameCharacter
    {
        private Random r;

        public Boss(int health, int stamina) : base(health, stamina)
        {
            r = new Random();
        }

        public override void Fight(GameCharacter opponent)
        {
            opponent.LooseHealth(r.Next(0, 31));
        }
    }
}
