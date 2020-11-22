using System;

namespace TakeNote
{
    public static class ConsoleApplication
    {
        public static void Run()
        {
            Console.Title = "Take Note Console Application";
            AsciiArt.Display();
            Console.WriteLine("Enter command <HELP to display help>: ");
            string value = null;

            Initiate initiate = new Initiate();
            initiate.Run();

            var exit = false;
            while (exit == false)
            {
                value = Console.ReadLine();
                if (value != null && !string.IsNullOrWhiteSpace(value))
                {
                    var command = Parser.Parse(value);

                    if (command != null)
                    {
                        // should exit?
                        exit = command.Execute();
                    }
                }
            }
        }
    }
}