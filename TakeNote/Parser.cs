using TakeNote.Commands;

namespace TakeNote
{
    public static class Parser
    {
        public static ICommand Parse(string commandString)
        {
            string arg = null;
            var commandParts = commandString.Split(' ', 2);
            var commandName = commandParts[0];
            if (commandParts.Length > 1)
            {
                arg = commandParts[1]; // the arguments is after the command
            }

            switch (commandName)
            {
                // Create command based on CommandName (and maybe arguments)
                case "EXIT": return new ExitCommand();
                case "*": return new NoteCommand(arg);
                case "BACKGROUND": return new BackgroundColor(arg);
                case "TEXT": return new ForegroundColor(arg);
                case "HELP": return new HelpCommand();
                case "CLEAR": return new ClearCommand();
                case "RESET": return new ResetColorCommand();
                case "DELETE": return new DeleteCommand(arg);
                case "DELETEALL": return new DeleteAllCommand();
                case "DAY": return new DayCommand(arg);
                case "SHOW": return new ShowCommand();

                default: return null;
            }
        }
    }
}