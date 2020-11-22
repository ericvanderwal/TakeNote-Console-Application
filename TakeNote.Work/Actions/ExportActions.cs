using TakeNote.Work;

namespace TakeNote.Actions
{
    public class ExportActions
    {
        public bool Export(string path)
        {
            bool success = Notes.Instance.Export(path);
            return success;

        }
    }
}