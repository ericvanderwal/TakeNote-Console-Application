using System;

namespace TakeNote.Work
{
    public class NoteModel
    {
        public int Count { get; set; }
        public bool Complete { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}