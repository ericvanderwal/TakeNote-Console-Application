using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace TakeNote.Work.Services
{
    public class CsvParserServiceService : ICsvParserService
    {
        // public List<NoteModel> ReadCsvFileToNoteModel(string path)
        // {
        //     try
        //     {
        //         using var reader = new StreamReader(path, Encoding.Default);
        //         using var csv = new CsvReader(reader);
        //         csv.Configuration.RegisterClassMap<NoteModel>();
        //         var records = csv.GetRecords<NoteModel>().ToList();
        //         return records;
        //     }
        //     catch (UnauthorizedAccessException e)
        //     {
        //         throw new Exception(e.Message);
        //     }
        //     catch (FieldValidationException e)
        //     {
        //         throw new Exception(e.Message);
        //     }
        //     catch (CsvHelperException e)
        //     {
        //         throw new Exception(e.Message);
        //     }
        //     catch (Exception e)
        //     {
        //         throw new Exception(e.Message);
        //     }
        // }

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