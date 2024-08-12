using AccessModifiers.Library;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aa = new AA();

            var a1 = new A();
            var a2 = new A();
            //Console.WriteLine(a._i);
            a1.DoSomething(aa);

            var class1 = new Class1();
            Console.WriteLine(class1._i);

            var testClass = new TestClassB();

        }
    }

    public abstract class TestClass
    {
        protected TestClass()
        {
            
        }

        protected abstract int Sum();

        protected virtual void DoSomething()
        {
            Console.WriteLine("something");
        }
    }

    public class TestClassB : TestClass
    {
        public TestClassB() : base()
        {
            
        }

        protected override int Sum()
        {
            return 5;
        }
    }

    public interface TestClass2
    {
        public int Sum();
    }

    public class A
    {
        protected int _i;

        internal void DoSomething(A otherA)
        {
            Console.WriteLine(otherA._i);
        }
    }

    public class AA : A
    {
        public AA()
        {
            Console.WriteLine(_i);

            //DoSomething();
        }
    }
}
