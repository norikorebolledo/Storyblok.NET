using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Underline : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "u" };
        }
    }
}
