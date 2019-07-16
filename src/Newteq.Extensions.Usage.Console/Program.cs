using System;

namespace Newteq.Extensions.Usage.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloWorld = "hello world with all the first letter's capitalized";
            Console.WriteLine(helloWorld.ToTitle());

            NextExample();

            var names = new string[]
            {
                "John",
                "Dave",
                "Dane",
                "Alice",
                "Sarah",
                "Sofia",
            };
            Console.WriteLine($"Everyone is here: {names.NaturalJoin()}");

            PromptClose();
        }

        private static void NextExample()
        {
            Console.WriteLine("Press any key for next example");
            Console.ReadLine();
        }

        private static void PromptClose()
        {
            Console.WriteLine("That's it :). Press any key for to exit");
            Console.ReadLine();
        }
    }
}
