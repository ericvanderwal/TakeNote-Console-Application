using System;

namespace TakeNote.Commands
{
    public class ExitConsoleCommand : ICommand
    {
        public bool Execute()
        {
            Console.WriteLine("Exiting program");
            return true;
        }
    }
}