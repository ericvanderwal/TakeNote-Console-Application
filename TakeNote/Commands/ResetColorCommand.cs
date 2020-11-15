using System;
using TakeNote.Work.Actions;

namespace TakeNote.Commands
{
    public class ResetColorCommand : ICommand
    {
        public bool Execute()
        {
            ColorActions colorActions = new ColorActions();
            colorActions.ResetColor();
            return false;
        }
    }
}