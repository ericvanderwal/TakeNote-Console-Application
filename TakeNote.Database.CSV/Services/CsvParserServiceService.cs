using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using NoteWork.Database.CSV;
using NoteWork.Database.CSV.Helpers;
using TakeNote.Model;

namespace TakeNote.Work.Services
{
    public class CsvParserServiceService
    {
        public CsvParserServiceService()
        {
            if (!CheckPathExists.PathExists(Constants.Paths.path))
            {
                using StreamWriter sw = new StreamWriter(Constants.Paths.path, false, new UTF8Encoding(true));
                using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<NoteModel>();
                }
            }
        }


        public List<NoteModel> ReadCsvFileToNoteModel()
        {
            try
            {
                using StreamReader reader = new StreamReader(Constants.Paths.path, new UTF8Encoding(true));
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

        public void WriteNewCsvFile(List<NoteModel> noteModels)
        {
            using StreamWriter sw = new StreamWriter(Constants.Paths.path, false, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<NoteMapper>();
                csv.WriteRecords(noteModels);
            }
        }

        public void AddCsvRecord(NoteModel noteModel)
        {
            using StreamWriter sw = new StreamWriter(Constants.Paths.path, true, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.RegisterClassMap<NoteMapper>();
                sw.WriteLine();
                csv.WriteRecord(noteModel);
            }
        }

        public void DeleteAllCSV()
        {
            using StreamWriter sw = new StreamWriter(Constants.Paths.path, false, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<NoteModel>();
            }
        }

        public bool ExportCSV(string path, List<NoteModel> noteMaster)
        {
            if (!Path.IsPathFullyQualified(path))
            {
                return false;
            }

            if (!Path.HasExtension(path))
            {
                return false;
            }

            string extension = Path.GetExtension(path);
            if (extension != ".csv")
            {
                return false;
            }

            if (!CheckPathExists.PathExists(path))
            {
                FileFolderGenerator.EvaluatePath(path);
            }

            using StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(true));
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<NoteMapper>();
                csv.WriteRecords(noteMaster);
            }

            return true;
        }
    }
}