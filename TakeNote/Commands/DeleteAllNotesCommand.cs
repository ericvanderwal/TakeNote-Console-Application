using TakeNote.Actions;

namespace TakeNote.Commands
{
    public class DeleteAllNotesCommand : ICommand
    {
        public DeleteAllNotesCommand(string arg)
        {
            if (arg == "true")
            {
                DeleteActions deleteActions = new DeleteActions();
                deleteActions.DeleteAllNotes(true);
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}