using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Strong : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "strong" };
        }
    }
}
