using TakeNote.Work;

namespace TakeNote.Actions
{
    public class WriteActions
    {
        public void Write(NoteModel noteModel)
        {
            Notes.Instance.WriteSingleNote(noteModel);
        }
    }
}