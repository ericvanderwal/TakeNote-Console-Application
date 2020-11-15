using TakeNote.Work.Services;

namespace TakeNote.Work.CSV
{
    public class DeleteActions
    {
        private CsvParserServiceService _csvParser;

        public DeleteActions()
        {
            _csvParser = new CsvParserServiceService();
        }


        public void DeleteAllNotes(bool confirm)
        {
            if (confirm == true)
            {
                _csvParser.DeleteAllCSV(Constants.Paths.path);
            }
        }
    }
}