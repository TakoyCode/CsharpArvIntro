namespace FromInterfaceToInheritance
{
    internal abstract class Command
    {
        public abstract void Run();

        private int Num { get; }

        private string Description { get; }

        protected Command(int num, string description)
        {
            Num = num;
            Description = description;
        }

        public static string AskStatic(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        public string Ask(string question)
        {
            Console.Write(question + Num);
            return Console.ReadLine();
        }

    }
}
