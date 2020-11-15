using System.Collections.Generic;

namespace TakeNote.Work.Services
{
    public interface ICsvParserService
    {
        // List<NoteModel> ReadCsvFileToNoteModel(string path);
        void WriteNewCsvFile(string path, List<NoteModel> noteModels);
    }
}