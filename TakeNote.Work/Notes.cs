using System;

namespace TakeNote.Work
{
    public class Notes
    {
        private static readonly Lazy<Notes> instance =
            new Lazy<Notes>(() => new Notes());

        public static Notes Instance
        {
            get { return instance.Value; }
        }

        private Notes()
        {
            Console.WriteLine("New Notes instantiated");
        }

        public void Run()
        {
            Console.WriteLine("Run Notes");
        }
    }
}