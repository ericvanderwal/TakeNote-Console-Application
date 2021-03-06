﻿using System.IO;

namespace NoteWork.Database.CSV.Helpers
{
    public static class CheckPathExists
    {
        public static bool PathExists(string path)
        {
            string folder = Path.GetDirectoryName(path);
            if (!Directory.Exists(folder))
            {
                return false;
            }

            if (!File.Exists(path))
            {
                return false;
            }

            return true;
        }
    }
}