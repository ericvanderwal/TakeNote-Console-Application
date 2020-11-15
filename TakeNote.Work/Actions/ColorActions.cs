using System;

namespace TakeNote.Work.Actions
{
    public class ColorActions
    {
        public void ResetColor()
        {
            Console.ResetColor();
        }

        public void SetColor(string color, bool isForeground)
        {
            if (color == null)
            {
                Console.WriteLine("No color has been entered");
            }

            else
            {
                ConsoleColor consoleColor;

                if (!Enum.TryParse(color, true, out consoleColor))
                {
                    Console.WriteLine("You have entered incorrect color name");
                }
                else
                {
                    if (isForeground)
                    {
                        Console.ForegroundColor = consoleColor;
                    }
                    else
                    {
                        Console.BackgroundColor = consoleColor;
                    }

                    Console.Clear();
                    Console.WriteLine("Color Changed");
                }
            }
        }
    }
}