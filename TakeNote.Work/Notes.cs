using System;
using System.Collections.Generic;
using TakeNote.Model;
using TakeNote.Work.Services;

namespace TakeNote.Work
{
    public class Notes
    {
        private List<NoteModel> _noteMaster;

        private List<NoteModel> _displayList;

        private static readonly Lazy<Notes> instance =
            new Lazy<Notes>(() => new Notes());

        private CsvParserServiceService _csvParser;

        public static Notes Instance
        {
            get { return instance.Value; }
        }

        private Notes()
        {
            _csvParser = new CsvParserServiceService();
            _noteMaster = _csvParser.ReadCsvFileToNoteModel() ?? new List<NoteModel>();
        }

        public void WriteSingleNote(NoteModel noteModel)
        {
            //add note to master
            _noteMaster.Add(noteModel);
            _csvParser.AddCsvRecord(noteModel);
        }

        public List<NoteModel> ReadNotesAll()
        {
            _displayList = _noteMaster;

            // load if no note list
            if (_displayList == null || _displayList.Count == 0)
            {
                return null;
            }

            return _displayList;
        }

        /// <summary>
        /// Return true if success
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool DeleteNote(int number)
        {
            if (_displayList == null || _displayList.Count < number)
            {
                return false;
            }

            //take deleted note out from master and display
            NoteModel foundNote = _displayList[number - 1];
            _displayList.Remove(foundNote);
            _noteMaster.Remove(foundNote);

            // resave master list
            _csvParser.WriteNewCsvFile(_noteMaster);
            return true;
        }

        public void DeleteAllNotes()
        {
            _displayList = new List<NoteModel>();
            _noteMaster = new List<NoteModel>();
            _csvParser.DeleteAllCSV();
        }

        public void Init()
        {
        }

        public List<NoteModel> ReadNotesDay(in DateTime dateTime)
        {
            _displayList = new List<NoteModel>();

            foreach (var note in _noteMaster)
            {
                if (note.Date.Day == dateTime.Date.Day
                    && note.Date.Month == dateTime.Month
                    && note.Date.Year == dateTime.Year)
                {
                    _displayList.Add(note);
                }
            }

            return _displayList;
        }

        public bool Export(string path)
        {
            bool success = _csvParser.ExportCSV(path, _noteMaster);
            return success;
        }
    }
}