using DNU_Library_website.Models;

namespace DNU_Library_website.App_Plugins.ManagementSection.TopicTrees
{
    public class TopicTreeNode
    {
        public object Id { get; }
        public object ParentId { get; }
        public string Alias { get; }
        public string Name { get; }
        public string NodeType { get; }
        public string Path { get; }
        public string RoutePath { get; }
        public Topic topic;
        public IDictionary<string, object> AdditionalData { get; }

        public TopicTreeNode(int id,int parentId,string name){
            this.Id = id;
            this.ParentId = parentId;
            this.Name = name;
        }
    }
}
