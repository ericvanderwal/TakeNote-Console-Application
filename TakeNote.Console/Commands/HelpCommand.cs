using System;

namespace TakeNote.Commands
{
    public class HelpCommand : ICommand
    {
        public bool Execute()
        {
            Console.WriteLine(HelpDocumentation.HelpText);
            return false;
        }
    }
}