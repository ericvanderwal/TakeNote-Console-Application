using System;
using System.IO;

namespace NoteWork.Database.CSV.Helpers
{
    public static class FileFolderGenerator
    {
        public static string EvaluatePath(string path)
        {
            try
            {
                string folder = Path.GetDirectoryName(path);
                if (!Directory.Exists(folder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(folder);
                }
            }
            catch (IOException ioException)
            {
                Console.WriteLine(ioException.Message);
                return "";
            }

            return path;
        }
    }
}