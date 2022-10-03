using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class Blockquoute : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "blockquote" };
        }
    }
}
