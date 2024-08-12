namespace FromInterfaceToInheritance
{
    internal class Test
    {
        public DateTime Today { get; set; }

        public Test()
        {
            Today = DateTime.Now.AddDays(7);
        }
    }
}
