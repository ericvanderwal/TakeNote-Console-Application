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
                GenerateDisplay generateDisplay = new GenerateDisplay();
                generateDisplay.Show(notes);
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}