using System;

namespace BoomLibrary
{
    public class NoteBuilder
    {
        GTD_Status status = GTD_Status.HasNotBeenSet;
        string title = String.Empty;
        string description = String.Empty;
        int boom = 0;
        
        public void BuilderSetStatus(GTD_Status noteStatus) { status = noteStatus; }
        public void BuilderSetTitle(string noteTitle) { title = noteTitle; }
        public void BuilderSetDescription(string noteDescription) { description = noteDescription; }
        public void BuilderSetBoom(int noteBoom) { boom = noteBoom; }
        public Note BuilderBuildNote()
        {
            Note newNote = new Note();
            newNote.Status = status;
            newNote.Title = title;
            newNote.Description = description;
            newNote.Boom = boom;


            if (title != String.Empty && status != GTD_Status.HasNotBeenSet)
            {
                return newNote;
            }
            else
            {
                throw new Exception("NoteBuilder: The note is missing a title & status.");
            }
        }
    }
}