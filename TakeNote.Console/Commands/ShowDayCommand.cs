using System;
using TakeNote.Actions;

namespace TakeNote.Commands
{
    public class ShowDayCommand : ICommand
    {
        public ShowDayCommand(string number)
        {
            if (Int32.TryParse(number, out int num))
            {
                DateTime dateTime = DateTime.Now.AddDays(-num);
                ReadActions readActions = new ReadActions();
                var notes = readActions.ReadDay(dateTime);

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
            else
            {
                Console.WriteLine("An invalid number has been entered");
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}