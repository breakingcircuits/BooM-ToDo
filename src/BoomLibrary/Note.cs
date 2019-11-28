using System;
using System.Collections.Generic;

namespace BoomLibrary
{
    public class Note
    {
        // Fields & Properties
        public GTD_Status Status { get {return Status;} set { value = GTD_Status.HasNotBeenSet;} }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Boom { get; set; }
        private List<ExternalResource> checklist = new List<ExternalResource>();

        // Methods
        public override string ToString()
        {
            return $"Status: {Status}\nTitle: {Title}\nDescription: {Description}\nChecklist: BoomValue: {Boom}";
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
                checklist += item + " ";
            }
            return checklist;
        }
        public string GetNoteValues()
        {
            return $"Status: {Status}\nTitle: {Title}\nDescription: {Description}\nChecklist: {checklist}\nBoomValue: {Boom}";
        }
    }

    public enum GTD_Status
        {
            HasNotBeenSet,
            In,
            NextActions,
            WaitingFor,
            Projects,
            SomeDayMaybe,
            Done
        }
}




