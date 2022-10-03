using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Bold : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "bold" };
        }
    }
}
