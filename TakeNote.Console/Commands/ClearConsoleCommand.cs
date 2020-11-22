using System;

namespace TakeNote.Commands
{
    public class ClearConsoleCommand : ICommand
    {
        public bool Execute()
        {
            Console.Clear();
            return false;
        }
    }
}