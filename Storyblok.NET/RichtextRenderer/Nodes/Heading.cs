using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class Heading : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = $"h{node?.Attrs?.Level}" };
        }
    }
}
