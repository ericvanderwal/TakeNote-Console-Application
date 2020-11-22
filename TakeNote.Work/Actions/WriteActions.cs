using System;
using TakeNote.Model;
using TakeNote.Work;

namespace TakeNote.Actions
{
    public class WriteActions
    {
        public void Write(string noteString)
        {
            NoteModel noteModel = new NoteModel()
            {
                Note = noteString,
                Date = DateTime.Now,
            };

            Notes.Instance.WriteSingleNote(noteModel);
        }
    }
}