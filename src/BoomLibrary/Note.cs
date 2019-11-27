using System;
using System.Collections.Generic;

namespace BoomLibrary
{
    public class Note
    {
        // Fields & Properties
        private string title;
        private string description;
        private int boom;
        List<ExternalResource> checklist = new List<ExternalResource>();

        // Methods
        public override string ToString() 
        {
            return $"Title: {title}\nDescription: {description}\nChecklist: BoomValue: {boom}";
        }
        public void AddExternalResource() 
        {
            // TODO: Implement AddExternalResource().
            //TODO: For every ext.resource added, increment boom by one.
        }
        public DateTime CreateDate() 
        {
            return DateTime.Now;
        }
        private string ViewCheckList() 
        {
            string checklist = string.Empty;
            foreach (var item in checklist)
            {
                checklist +=  item + " ";
            }
            return checklist;
        }
        public string GetNoteValues() 
        {
             return $"Title: {title}\nDescription: {description}\nChecklist:{}\nBoomValue: {boom}"; 
        }
    }
    public class GTD_Enum
    {
        enum GTD_Status 
        {
            In,
            NextActions,
            WaitingFor,
            Projects,
            SomeDayMaybe,
            Done

        }
    }
}




