namespace IntroArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eksempel på arv, via at en klasse arver fra List klassen
            List<int> normalList = new List<int>();
            CustomList<int> customList = new CustomList<int>(); 

            normalList.Add(1);
            customList.AddTwo(1,2);

            normalList.ForEach(num => Console.WriteLine(num));
            customList.ForEach(num => Console.WriteLine(num));


            // Meg som tester at CustomList klassen fungerer først
            var books = new CustomList<string>();
            books.AddTwo("Hatched as a dragon", "Woke up as a spider");
            
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
