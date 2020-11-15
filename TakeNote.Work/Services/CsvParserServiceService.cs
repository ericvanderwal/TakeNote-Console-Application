using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TakeNote.Work.Services
{
    public class CsvParserServiceService : ICsvParserService
    {
        public List<NoteModel> ReadCsvFileToNoteModel(string path)
        {
            try
            {
                using StreamReader reader = new StreamReader(path, new UTF8Encoding(true));
                using CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.RegisterClassMap<NoteMapper>();
                var records = csv.GetRecords<NoteModel>().ToList();
                return records;
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void WriteNewCsvFile(string path, List<NoteModel> noteModels)
        {
            using StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<NoteMapper>();
                csv.WriteRecords<NoteModel>(noteModels);
            }
        }

        public void AddCsvRecord(string path, NoteModel noteModel)
        {
            using StreamWriter sw = new StreamWriter(path, true, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.RegisterClassMap<NoteMapper>();
                csv.WriteRecord(noteModel);
            }
        }

        public void DeleteAllCSV(string path)
        {
            using StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.WriteComment("Empty");
            }
        }
    }
}