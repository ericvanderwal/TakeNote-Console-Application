using System;
using System.Collections.Generic;
using CsvHelper;
using TakeNote.Console;
using TakeNote.Work.Services;

namespace TakeNote.Work
{
    public class Notes
    {
        private List<NoteModel> NoteList;

        private static readonly Lazy<Notes> instance =
            new Lazy<Notes>(() => new Notes());

        private WriteActions _write;
        private ReadActions _read;
        private CsvParserServiceService _csvParser;

        public static Notes Instance
        {
            get { return instance.Value; }
        }

        private Notes()
        {
            if (!CheckPathExists.PathExists(Constants.Paths.path)) return;
            _csvParser = new CsvParserServiceService();
            NoteList = _csvParser.ReadCsvFileToNoteModel(Constants.Paths.path);
        }

        public void WriteAllNotes(NoteModel noteModel)
        {
            // save entire list
            NoteList.Add(noteModel);
            FileFolderGenerator.EvaluatePath(Constants.Paths.path);
            _csvParser.WriteNewCsvFile(Constants.Paths.path, NoteList);
        }

        public void WriteSingleNote(NoteModel noteModel)
        {
            NoteList.Add(noteModel);
            FileFolderGenerator.EvaluatePath(Constants.Paths.path);
            _csvParser.WriteNewCsvFile(Constants.Paths.path, NoteList);
        }

        public List<NoteModel> ReadNotes()
        {
            // load if no note list
            if (NoteList == null || NoteList.Count == 0)
            {
                return null;
            }

            return NoteList;
        }

        public bool DeleteNote(int number)
        {
            if (NoteList == null || NoteList.Count < number)
            {
                return false;
            }

            NoteList.RemoveAt(number - 1);
            FileFolderGenerator.EvaluatePath(Constants.Paths.path);
            _csvParser.WriteNewCsvFile(Constants.Paths.path, NoteList);
            return true;
        }

        public void DeleteAllNotes()
        {
            _csvParser.DeleteAllCSV(Constants.Paths.path);
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}