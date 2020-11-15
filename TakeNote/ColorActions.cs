using System;

namespace TakeNote
{
    public class ColorActions
    {
        public void ResetColor()
        {
            System.Console.ResetColor();
        }

        public void SetColor(string color, bool isForeground)
        {
            if (color == null)
            {
                System.Console.WriteLine("No color has been entered");
            }

            else
            {
                ConsoleColor consoleColor;

                if (!Enum.TryParse(color, true, out consoleColor))
                {
                    System.Console.WriteLine("You have entered incorrect color name");
                }
                else
                {
                    if (isForeground)
                    {
                        System.Console.ForegroundColor = consoleColor;
                    }
                    else
                    {
                        System.Console.BackgroundColor = consoleColor;
                    }

                    System.Console.Clear();
                    System.Console.WriteLine("Color Changed");
                }
            }
        }
    }
}