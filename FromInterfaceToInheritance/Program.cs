namespace FromInterfaceToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Command.AskStatic("test"));
            
            //var getAge = new GetAge();
            //Console.WriteLine(getAge.Ask("asdasd"));
            var test = new Test();

            string[] questions = [ "How old are you", "test" ];
            Type[] questionTypes = [ typeof(int), typeof(string), typeof(bool), typeof(double), typeof(DateTime), typeof(Test)];
            object[] answers = [ 1, "text", true, 2.1, DateTime.Now, test];

            var index = 0;
            

            //var test = 1 + (int)answer;

            foreach (var o in answers)
            {
                var answer = answers[index];
                var questionType = questionTypes[index];

                Console.WriteLine(o);
                Console.WriteLine(o.GetType());
                Console.WriteLine(questionType);

                Console.WriteLine();
                index++;
            }

        }
    }
}
