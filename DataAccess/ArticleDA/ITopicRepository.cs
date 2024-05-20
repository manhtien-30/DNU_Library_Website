using DNU_Library_website.BusinessObjects;

namespace DNU_Library_website.DataAccess.ArticleDA
{
    public interface ITopicRepository
    {
        public ICollection<Topic> getAllTopic();
        public Topic getTopicById(int id);
        public void deleteTopicById(int id);
        public void updateTopic(Topic topic);
        public void saveTopic(Topic topic);
    }
}
