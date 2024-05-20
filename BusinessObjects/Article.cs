using DNU_Library_website.BusinessObjects;
using Microsoft.Identity.Client;

namespace DNU_Library_website.Models
{
    public class Article
    {
        private string Id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private string path { get; set; }
        private string content { get; set; }
        private DateTime _create => DateTime.Now;
        private DateTime _update => DateTime.Now;

        public virtual ICollection<Topic> Topics { get; set; } 

    }
}