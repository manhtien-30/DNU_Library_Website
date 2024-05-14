using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Actions;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models.Trees;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Trees;
using Umbraco.Cms.Web.BackOffice.Trees;
using Umbraco.Cms.Web.Common.Attributes;
using Umbraco.Cms.Web.Common.ModelBinders;
using Umbraco.Extensions;
using uSync.Core;

namespace DNU_Library_website.App_Plugins.ManagementSection.TopicTrees
{
    [Tree("ManagementSection", "Topic", IsSingleNodeTree = false, TreeTitle = "Topic")]
    [PluginController("ManagementSection")]
    public class TopicTreeController : TreeController
    {
        private readonly IMenuItemCollectionFactory menuFactory;
        public TopicTreeController(ILocalizedTextService localizedTextService,
            IMenuItemCollectionFactory menuItemCollectionFactory,
            UmbracoApiControllerTypeCollection umbracoApiControllerTypeCollection,
            IEventAggregator eventAggregator) : base(localizedTextService, umbracoApiControllerTypeCollection, eventAggregator)
        {
            menuFactory = menuItemCollectionFactory ?? throw new ArgumentNullException(nameof(menuItemCollectionFactory));
        }
        protected override ActionResult<TreeNodeCollection> GetTreeNodes(string id, FormCollection queryStrings)
        {
            var nodes = new TreeNodeCollection();
            Dictionary<int, TopicTreeNode> topics = new Dictionary<int, TopicTreeNode>();
            topics.Add(1, new TopicTreeNode(1, -1, "gioi thieu"));
            topics.Add(2, new TopicTreeNode(2, -1, "nhung dieu can biet"));
            topics.Add(3, new TopicTreeNode(3, -1, "tai nguyen thong tin"));
            topics.Add(4, new TopicTreeNode(4, 1, "chuc nang nhiem vu"));
            topics.Add(5, new TopicTreeNode(5, 2, "quy dinh"));
            topics.Add(6, new TopicTreeNode(6, 3, "tai lieu chuyen nganh"));

            // check if we're rendering the root node's children
            if (id == Constants.System.Root.ToInvariantString())
            {
                // you can get your custom nodes from anywhere, and they can represent anything...
                // loop through our favourite things and create a tree item for each one
                foreach (var thing in topics)
                {
                    //add node   to colection
                    if ((int)thing.Value.ParentId == -1)
                    {
                        var node = CreateTreeNode(thing.Key.ToString(), thing.Value.ParentId.ToString(), queryStrings, thing.Value.Name, "icon-presentation", true);
                        nodes.Add(node);
                    }
                }
            }
            else
            {

                for (int i = 1; i < 4; i++)
                {
                    if (id == i.ToString())
                    {
                        foreach (var thing in topics)
                        {   if( thing.Value.ParentId.ToString() == id)
                            {
                    var node = CreateTreeNode(thing.Key.ToString(), thing.Value.ParentId.ToString(), queryStrings, thing.Value.Name, "icon-presentation", true);
                            nodes.Add(node);}
                        }
                    }
                }
            }
            return nodes;

        }


        protected override ActionResult<MenuItemCollection> GetMenuForNode(string id, FormCollection queryStrings)
        {
            // create a Menu Item Collection to return so people can interact with the nodes in your tree
            var menu = menuFactory.Create();

            if (id == Constants.System.Root.ToInvariantString())
            {
                // root actions, perhaps users can create new items in this tree, or perhaps it's not a content tree, it might be a read only tree, or each node item might represent something entirely different...
                // add your menu item actions or custom ActionMenuItems
                menu.Items.Add(new CreateChildEntity(LocalizedTextService));
                // add refresh menu item (note no dialog)
                menu.Items.Add(new RefreshNode(LocalizedTextService, true));
            }
            else
            {   
                // add a delete action to each individual item
                menu.Items.Add<ActionDelete>(LocalizedTextService, true, opensDialog: true);
                menu.Items.Add<ActionNew>(LocalizedTextService, true, opensDialog: true);
                menu.Items.Add<ActionMove>(LocalizedTextService, true, opensDialog: true);
                menu.Items.Add<ActionUpdate>(LocalizedTextService, true, opensDialog: true);
                menu.Items.Add<ActionCopy>(LocalizedTextService, true, opensDialog: true);
            }

            return menu;
        }

        protected override ActionResult<TreeNode?> CreateRootNode(FormCollection queryStrings)
        {
            var rootResult = base.CreateRootNode(queryStrings);
            if (!(rootResult.Result is null))
            {
                return rootResult;
            }

            var root = rootResult.Value;
            // set the icon
            root.Icon = "icon-hearts";
            // could be set to false for a custom tree with a single node.
            root.HasChildren = true;
            //url for menu
            root.MenuUrl = null;

            return root;
        }
    }
}
