namespace TakeNote.Commands
{
    public class BackgroundColorConsoleCommand : ICommand
    {
        public BackgroundColorConsoleCommand(string color)
        {
            ColorActions colorActions = new ColorActions();
            colorActions.SetColor(color, false);
        }

        public bool Execute()
        {
            return false;
        }
    }
}