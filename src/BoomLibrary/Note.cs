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
            return $"Title: {title}\nDescription: {description}\nBoomValue: {boom}";
            //TODO: Implement this.
        }
        public void AddExternalResource() 
        {
            // TODO: Implement AddExternalResource().
        }
        public DateTime CreateDate() 
        {
            return DateTime.Now;
        }
    }
}




