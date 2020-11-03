using System;

namespace TakeNote.Work
{
    public interface INoteObject
    {
        public int Count { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }
}