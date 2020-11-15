using TakeNote.Work;

namespace TakeNote
{
    public class Initiate
    {
        public void Run()
        {
            Notes.Instance.Init();
        }
    }
}