using CsvHelper.Configuration;
using NoteWork.Database.CSV;
using TakeNote.Model;

namespace TakeNote.Work
{
    public sealed class NoteMapper : ClassMap<NoteModel>
    {
        public NoteMapper()
        {
            Map(m => m.Note).Name(Constants.CsvHeaders.Note).Index(2);
            Map(m => m.Date).Name(Constants.CsvHeaders.Date).Index(1);
        }
    }
}