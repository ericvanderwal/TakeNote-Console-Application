using CsvHelper.Configuration;

namespace TakeNote.Work
{
    public sealed class NoteMapper : ClassMap<NoteModel>
    {
        public NoteMapper()
        {
            Map(m => m.Count).Name(Constants.CsvHeaders.Count).Index(0);
            Map(m => m.Note).Name(Constants.CsvHeaders.Note).Index(2);
            Map(m => m.Date).Name(Constants.CsvHeaders.Date).Index(1);
            Map(m => m.Complete).Name(Constants.CsvHeaders.Complete).Index(3);
        }
    }
}