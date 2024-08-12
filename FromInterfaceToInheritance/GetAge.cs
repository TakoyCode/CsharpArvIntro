namespace FromInterfaceToInheritance
{
    internal class GetAge : Command
    {
        public GetAge() : base(1, "Get age")
        {
        }

        public override void Run()
        {
            Ask("non-static");
            AskStatic("static");
        }
    }
}
