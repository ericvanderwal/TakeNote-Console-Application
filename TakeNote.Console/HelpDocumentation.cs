namespace TakeNote
{
    public static class HelpDocumentation
    {
        public static string HelpText = @"

        The following commands are available for use within Take Note.

        HELP        displays this help page
        EXIT        closes the console application

        ------------------------------------------------------------------------

        *           followed by the note body will create and save a new note.
        SHOW        display all notes.
        DELETE      followed by a number deletes the associated note.
        DELETEALL   followed by 'true', deletes all notes saved in the database.  
        EXPORT      followed by a valid path and file name. Eg c:/Folder/myNotes.csv      
       
        ------------------------------------------------------------------------

        CLEAR       clears all notes from the console screen.
        BACKGROUND  followed by a valid color will change the background color.
        TEXT        followed by a valid color will change the text color.
        RESET       clears all console colors back to default

        Valid Colors: Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGray, DarkGreen
                      DarkMagenta, DarkRed, DarkYellow, Gray, Green, Magenta, Red
                      White, Yellow

";
    }
}