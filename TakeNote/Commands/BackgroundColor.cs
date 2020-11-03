using System;
using System.Collections.Generic;

namespace TakeNote.Commands
{
    public class BackgroundColor : ICommand
    {
        private readonly string color;

        public BackgroundColor(string color)
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
                    Console.BackgroundColor = consoleColor;
                    Console.Clear();
                    Console.WriteLine("Color Changed");
                }
            }
        }
    }
}