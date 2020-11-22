using System;
using TakeNote.Actions;
using TakeNote.Work;

namespace TakeNote.Commands
{
    public class Export : ICommand
    {
        public Export(string path)
        {
            ExportActions exportActions = new ExportActions();
            bool success = exportActions.Export(path);
            if (success)
            {
                Console.WriteLine("Notes were successfully exported to : " + path);
            }
            else
            {
                Console.WriteLine(
                    $"Notes were not successfully exported to : {path} . This path may be invalid or you do not have access.");
            }
        }

        public bool Execute()
        {
            return false;
        }
    }
}