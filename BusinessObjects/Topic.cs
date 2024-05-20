using DNU_Library_website.Models;

namespace DNU_Library_website.BusinessObjects
{
    public class Topic
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime _created => DateTime.Now;
        public DateTime _updated => DateTime.Now;
        public virtual ICollection<Article>? Articles { get; set; }  
    }
}
