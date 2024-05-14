using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace DNU_Library_website.App_Plugins.ManagementSection.TopicTrees
{
    public class TopicTreeNodeController
    {
        public Collection<TopicTreeNode> TopicTrees { get; set; }

        public TopicTreeNodeController() { }

        public Collection<TopicTreeNode> GetTreeNodes() { return TopicTrees; }
        public void GenerateTopicTreeNodePath(string path)
        {
            
        }
                
    }
}
