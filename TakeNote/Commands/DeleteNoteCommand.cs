using System;

namespace TakeNote.Commands
{
    public class DeleteNoteCommand : ICommand
    {
        private string sNumber;

        public DeleteNoteCommand(string number)
        {
            sNumber = number;
        }

        public bool Execute()
        {
            if (Int32.TryParse(sNumber, out int number))
            {
                //todo logic of deleting from DB
            }
            else
            {
                Console.WriteLine("Number not recognized");
            }

            return false;
        }
    }
}