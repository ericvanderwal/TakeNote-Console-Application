using System;

namespace TakeNote.Commands
{
    public class NoteCommand : ICommand
    {
        private readonly string completeNote;

        public NoteCommand(string s)
        {
            completeNote = string.IsNullOrWhiteSpace(s) ? null : s;
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