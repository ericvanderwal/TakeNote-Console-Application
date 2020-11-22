using System;

namespace TakeNote
{
    public class ColorActions
    {
        public void ResetColor()
        {
            System.Console.ResetColor();
            System.Console.Clear();
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
                    System.Console.WriteLine("You have entered invalid color name");
                    Console.WriteLine (@"Valid Colors:
                                       Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGray, DarkGreen, " +
                                      "DarkMagenta, DarkRed, DarkYellow, Gray, Green, Magenta, " +
                                      "Red, White, Yellow");
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
                }
            }
        }
    }
}