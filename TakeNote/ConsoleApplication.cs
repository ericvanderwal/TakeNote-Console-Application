using System;

namespace TakeNote
{
    public class ConsoleApplication
    {
        public void Run()
        {
            Console.Title = "Take Note";
            AsciiArt.Display();
            Console.WriteLine("Enter command <help to display help>: ");
            string value = null;

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