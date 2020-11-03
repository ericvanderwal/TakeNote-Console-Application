using System;

namespace TakeNote.Commands
{
    public class ClearCommand : ICommand
    {
        public bool Execute()
        {
            Console.Clear();
            return false;
        }
    }
}