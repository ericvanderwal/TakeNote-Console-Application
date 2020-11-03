using System;

namespace TakeNote.Commands
{
    public class DeleteCommand : ICommand
    {
        private string sNumber;

        public DeleteCommand(string number)
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