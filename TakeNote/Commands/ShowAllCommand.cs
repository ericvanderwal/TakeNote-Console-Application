using System;
using TakeNote.Work.CSV;

namespace TakeNote.Commands
{
    public class ShowAllCommand : ICommand
    {
        public ShowAllCommand()
        {
            ReadActions readActions = new ReadActions();
            readActions.ReadAll();
        }

        public bool Execute()
        {
            return false;
        }
    }
}