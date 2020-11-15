using TakeNote.Work;

namespace TakeNote.Actions
{
    public class DeleteActions
    {
        public void DeleteAllNotes(bool confirm)
        {
            if (confirm == true)
            {
                Notes.Instance.DeleteAllNotes();
            }
        }

        public bool DeleteSingleNote(int number)
        {
          bool found =  Notes.Instance.DeleteNote(number);
          return found;
        }
    }
}