using System;

namespace TakeNote.Commands
{
    public class ResetColorCommand : ICommand
    {
        public bool Execute()
        {
            Console.ResetColor();
            return false;
        }
    }
}