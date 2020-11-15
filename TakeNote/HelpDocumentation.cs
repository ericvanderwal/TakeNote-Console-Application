namespace TakeNote
{
    public static class HelpDocumentation
    {
        public static string HelpText = @"

        The following commands are available for use within Take Note.

        HELP        displays this help page
        *           followed by the note body will create and save a new note.
        DELETE      followed by a number deletes the associated note.
        DELETEALL   followed by 'true', deletes all notes saved in the database.
        CLEAR       clears all notes from the console screen.
        EXIT        closes the console application

        ------------------------------------------------------------------------

        SHOW        display all notes.
        DAY         followed by a number to display notes according to date.
                    eg, DAY 0 for today's notes. DAY -1 for yesterday's notes.

        ------------------------------------------------------------------------

        BACKGROUND  followed by a valid color will change the background color.
        TEXT        followed by a valid color will change the text color.
        RESET       clears all console colors back to default

        Valid Colors: Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGray, DarkGreen
                      DarkMagenta, DarkRed, DarkYellow, Gray, Green, Magenta, Red
                      White, Yellow

";
    }
}