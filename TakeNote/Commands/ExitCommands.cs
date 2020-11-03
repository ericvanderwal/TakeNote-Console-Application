using System;

namespace TakeNote.Commands
{
    public class ExitCommand : ICommand
    {
        public bool Execute()
        {
            Console.WriteLine("Exiting program");
            return true;
        }
    }
}