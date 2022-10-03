using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Styled : Element
    {
        public override ElementTag Render(Node node)
        {
            var attrs = new Dictionary<string, object>();

            if (node != null)
            {
                if (!string.IsNullOrEmpty(node.Attrs?.Class))
                {
                    attrs.Add("class", node.Attrs.Class);
                }
            }

            return new ElementTag { Tag = "span", Attrs = attrs };
        }
    }
}
