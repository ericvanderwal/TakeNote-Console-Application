using System;

namespace TakeNote.Commands
{
    public class ForegroundColor : ICommand
    {
        private readonly string color;

        public ForegroundColor(string color)
        {
            this.color = string.IsNullOrWhiteSpace(color) ? null : color;
        }

        public bool Execute()
        {
            CheckColor();
            return false;
        }

        private void CheckColor()
        {
            if (color == null)
            {
                Console.WriteLine("No color has been entered");
            }

            else
            {
                ConsoleColor consoleColor;

                if (!Enum.TryParse(this.color, true, out consoleColor))
                {
                    Console.WriteLine("You have entered incorrect color name");
                }
                else
                {
                    Console.ForegroundColor = consoleColor;
                    Console.Clear();
                    Console.WriteLine("Color Changed");
                }
            }
        }
    }
}