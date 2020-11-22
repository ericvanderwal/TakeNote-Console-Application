using System;
using System.Collections.Generic;
using TakeNote.Model;
using TakeNote.Work;

namespace TakeNote.Actions
{
    public class ReadActions
    {
        public List<NoteModel> ReadAll()
        {
            var noteList = Notes.Instance.ReadNotesAll();
            return noteList;
        }
        
        public List<NoteModel> ReadDay(DateTime dateTime)
        {
            var noteList = Notes.Instance.ReadNotesDay(dateTime);
            return noteList;
        }
    }
}