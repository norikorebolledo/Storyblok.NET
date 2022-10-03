using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer
{
    public abstract class Element
    {
        public abstract ElementTag Render(Node node);
    }
}
