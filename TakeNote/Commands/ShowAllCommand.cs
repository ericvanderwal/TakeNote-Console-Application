using System;
using TakeNote.Actions;

namespace TakeNote.Commands
{
    public class ShowAllCommand : ICommand
    {
        public ShowAllCommand()
        {
            ReadActions readActions = new ReadActions();
            var notes = readActions.ReadAll();

            if (notes == null || notes.Count == 0)
            {
                Console.WriteLine("No notes have been created");
            }

            else
            {
                for (var index = 0; index < notes.Count; index++)
                {
                    var note = notes[index];
                    Console.WriteLine(
                        index + " : " + note.Date + " : " + note.Note
                    );
                }
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}