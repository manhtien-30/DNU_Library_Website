namespace DNU_Library_website.Models
{
    public class Topic
    {
        private int Id;
        private string Name;
        private string Description;
        private DateTime _created => DateTime.Now;
        private DateTime _updated => DateTime.Now;
        public Topic(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
