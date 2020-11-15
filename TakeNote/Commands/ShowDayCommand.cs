using System;

namespace TakeNote.Commands
{
    public class ShowDayCommand : ICommand
    {
        private string sNumber;

        public ShowDayCommand(string number)
        {
            sNumber = number;
        }

        public bool Execute()
        {
            if (Int32.TryParse(sNumber, out int number))
            {
                //todo logic from DB
            }
            else
            {
                Console.WriteLine("Number not recognized");
            }

            return false;
        }
    }
}