namespace IntroArv
{
    internal class CustomList<T> : List<T>
    {
        public void AddTwo(T itemOne, T itemTwo)
        {
            Add(itemOne);
            Add(itemTwo);
        }
    }
}
