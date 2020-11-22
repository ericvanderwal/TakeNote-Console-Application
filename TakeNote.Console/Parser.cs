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
                case "EXIT": return new ExitConsoleCommand();
                case "*": return new NewNoteCommand(arg);
                case "BACKGROUND": return new BackgroundColorConsoleCommand(arg);
                case "TEXT": return new ForegroundColorConsoleCommand(arg);
                case "HELP": return new HelpCommand();
                case "CLEAR": return new ClearConsoleCommand();
                case "RESET": return new ResetColorCommand();
                case "DELETE": return new DeleteNoteCommand(arg);
                case "DELETEALL": return new DeleteAllNotesCommand(arg);
                case "DAY": return new ShowDayCommand(arg);
                case "SHOW": return new ShowAllCommand();
                case "EXPORT": return new Export(arg);

                default: return null;
            }
        }
    }
}