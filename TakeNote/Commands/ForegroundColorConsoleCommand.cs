using System;
using TakeNote.Work.Actions;

namespace TakeNote.Commands
{
    public class ForegroundColorConsoleCommand : ICommand
    {
        public ForegroundColorConsoleCommand(string color)
        {
            ColorActions colorActions = new ColorActions();
            colorActions.SetColor(color, true);
        }

        public bool Execute()
        {
            return false;
        }
    }
}