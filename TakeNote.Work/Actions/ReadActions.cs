using System.Collections.Generic;
using TakeNote.Work;

namespace TakeNote.Actions
{
    public class ReadActions
    {
        public List<NoteModel> ReadAll()
        {
            var noteList = Notes.Instance.ReadNotes();
            return noteList;
        }
    }
}