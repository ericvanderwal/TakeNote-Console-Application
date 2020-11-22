using System;
using System.Collections.Generic;
using TakeNote.Model;

namespace TakeNote
{
    public class GenerateDisplay
    {
        public void Show(List<NoteModel> noteList)
        {
            for (var index = 0; index < noteList.Count; index++)
            {
                var note = noteList[index];
                var timeDisplay = note.Date.Month + " / " + note.Date.Day;
                Console.WriteLine(
                    index + 1 + " - " + timeDisplay + " : " + note.Note
                );
            }
        }
    }
}