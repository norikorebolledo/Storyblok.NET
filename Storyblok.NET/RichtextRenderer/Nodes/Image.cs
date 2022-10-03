using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class Image : Element
    {
        public override ElementTag Render(Node node)
        {
            var attrs = new Dictionary<string, object>();

            if (node != null)
            {
                if (!string.IsNullOrEmpty(node.Attrs?.Src))
                {
                    attrs.Add("src", node.Attrs.Src);
                }
                if (!string.IsNullOrEmpty(node.Attrs?.Alt))
                {
                    attrs.Add("alt", node.Attrs.Alt);
                }
                if (!string.IsNullOrEmpty(node.Attrs?.Title))
                {
                    attrs.Add("title", node.Attrs.Title);
                }
            }

            return new ElementTag { Tag = $"img", IsSingleTag = true, Attrs = attrs };
        }
    }
}
