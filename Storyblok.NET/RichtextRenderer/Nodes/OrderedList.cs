using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class OrderedList : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = $"ol" };
        }
    }
}
