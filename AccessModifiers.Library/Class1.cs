namespace AccessModifiers.Library
{
    public class Class1
    {
        public int _i;
    }

    internal class Class2
    {
        public Class2()
        {
            new Class1();
        }
    }
}
