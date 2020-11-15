using System;
using System.Collections.Generic;
using TakeNote.Work.Services;

namespace TakeNote.Work.CSV
{
    public class WriteActions
    {
        private CsvParserServiceService _csvParser;
        private readonly List<NoteModel> _noteModels;

        public WriteActions()
        {
            _csvParser = new CsvParserServiceService();
            _noteModels = new List<NoteModel>();
            _noteModels.Add(new NoteModel()
            {
                Complete = false,
                Date = DateTime.Now.AddMinutes(-30),
                Count = 1,
                Note = "This is my first note in the system to get stuff done"
            });

            _noteModels.Add(new NoteModel()
            {
                Complete = true,
                Date = DateTime.Now.AddMinutes(-15),
                Count = 1,
                Note = "Here we have the second note and spelling be damned"
            });

            _noteModels.Add(new NoteModel()
            {
                Complete = true,
                Date = DateTime.Now.AddMinutes(-1),
                Count = 3,
                Note = "Here is a new note for number 3"
            });

            _noteModels.Add(new NoteModel()
                {
                    Complete = false,
                    Date = DateTime.Now.AddMinutes(-1),
                    Count = 4,
                    Note = "This is based"
                }
            );
        }

        public void WriteSample()
        {
            FileFolderGenerator.EvaluatePath(Constants.Paths.path);
            _csvParser.WriteNewCsvFile(Constants.Paths.path, _noteModels);
        }

        public void WriteSingleNote(string note)
        {
            NoteModel nextNote = new NoteModel()
            {
                Date = DateTime.Now,
                Complete = false,
                Count = 5,
                Note = note
            };

            FileFolderGenerator.EvaluatePath(Constants.Paths.path);
            _csvParser.AddCsvRecord(Constants.Paths.path, nextNote);
        }
    }
}