using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class HardBreak : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "br", IsSingleTag = true };
        }
    }
}
