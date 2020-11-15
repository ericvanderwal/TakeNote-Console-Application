using System;
using TakeNote.Work.CSV;

namespace TakeNote.Commands
{
    public class NewNoteCommand : ICommand
    {
        private readonly string completeNote;

        public NewNoteCommand(string s)
        {
            completeNote = string.IsNullOrWhiteSpace(s) ? "None" : s;
            WriteActions writeActions = new WriteActions();
            writeActions.WriteSingleNote(s);
        }

        public bool Execute()
        {
            if (completeNote != null)
            {
                Console.WriteLine("Note is: " + completeNote);
                Console.WriteLine("Note saved successfully");
            }
            else
            {
                Console.WriteLine("No Note Entered");
            }

            return false;
        }
    }
}