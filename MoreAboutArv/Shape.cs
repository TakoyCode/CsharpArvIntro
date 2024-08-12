namespace MoreAboutArv
{
    public abstract class Shape
    {
        protected Shape()
        {
            Console.WriteLine("Shape ctor");
        }

        public abstract double Area();

        public virtual void Show()
        {

        }
    }
}
