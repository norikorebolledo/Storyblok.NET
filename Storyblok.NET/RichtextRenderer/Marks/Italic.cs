using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Italic : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag { Tag = "italic" };
        }
    }
}
