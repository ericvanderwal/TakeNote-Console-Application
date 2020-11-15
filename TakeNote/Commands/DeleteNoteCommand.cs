using System;
using TakeNote.Actions;

namespace TakeNote.Commands
{
    public class DeleteNoteCommand : ICommand
    {
        public DeleteNoteCommand(string sNumber)
        {
            if (Int32.TryParse(sNumber, out int number))
            {
                DeleteActions deleteActions = new DeleteActions();
                bool found = deleteActions.DeleteSingleNote(number);

                if (!found)
                {
                    Console.WriteLine("Not found in database");
                }
            }
            else
            {
                Console.WriteLine("Number not recognized");
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}