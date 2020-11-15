using TakeNote.Work;

namespace TakeNote.Commands
{
    public class SampleCommand : ICommand
    {
        public SampleCommand()
        {
            Notes.Instance.Init();
        }

        public bool Execute()
        {
            return false;
        }
    }
}