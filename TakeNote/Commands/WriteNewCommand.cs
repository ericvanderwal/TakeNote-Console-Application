using TakeNote.Work;
using TakeNote.Work.CSV;

namespace TakeNote.Commands
{
    public class WriteNewCommand : ICommand
    {
        public WriteNewCommand()
        {
            WriteActions writeActions = new WriteActions();
            writeActions.WriteSample();
        }

        public bool Execute()
        {
            return false;
        }
    }
}