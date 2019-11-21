namespace BoomLibrary
{
    class ExternalResource
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ExternalResource(string title, string description)
        {
            Title = title;
            Description = description;
            Status = false;
        }
        
        public void EditTitle(string title)
        {
            Title = title;
        }

        public void EditDescription(string description)
        {
            Title = description;
        }

        public void SomethingElse()
        {

        }

        public override string ToString()
        {
            string str;
            str = $"Title: {Title}\nDescription: {Description}\nStatus: {Status}\n";
            return str;
        }
    }
}