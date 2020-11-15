using System;
using System.IO;

namespace TakeNote.Work
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