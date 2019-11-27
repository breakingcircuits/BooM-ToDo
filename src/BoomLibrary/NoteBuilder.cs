using System;

namespace BoomLibrary
{
    public class NoteBuilder
    {
        public Note CreateNewNote() 
        {
            Note newNote = new Note();
            newNote.Status = GTD_Status.Done;
            newNote.Title = "En titel";
            newNote.Description = "En beskrivning";
            newNote.Boom = 0;
            return newNote;
        }
    }
}