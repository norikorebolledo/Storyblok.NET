using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Marks
{
    public class Link : Element
    {
        public override ElementTag Render(Node node)
        {
            var attrs = new Dictionary<string, object>();

            if (node != null)
            {
                if (node.Attrs?.LinkType == "email")
                {
                    node.Attrs.Href = $"mailto:${node.Attrs.Href}";
                }
                if(!string.IsNullOrEmpty(node.Attrs?.Anchor))
                {
                    node.Attrs.Href = $"{node.Attrs.Href}#${node.Attrs.Anchor}";
                }

                if (!string.IsNullOrEmpty(node.Attrs?.Href))
                {
                    attrs.Add("href", node.Attrs.Href);
                }
                if (!string.IsNullOrEmpty(node.Attrs?.Target))
                {
                    attrs.Add("target", node.Attrs.Target);
                }
            }

            return new ElementTag { Tag = "a", Attrs = attrs };
        }
    }
}
