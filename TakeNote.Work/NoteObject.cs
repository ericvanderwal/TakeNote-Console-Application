using System;

namespace TakeNote.Work
{
    public class NoteObject : INoteObject
    {
        public int Count { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}