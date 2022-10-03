using Storyblok.NET.Fields;
using Storyblok.NET.Helpers;
using Storyblok.NET.ProseMirror;
using System.Text;

namespace Storyblok.NET.RichtextRenderer
{
    public class RichtextResolver
    {
        private readonly Schema _schema;

        public RichtextResolver()
            : this(new Schema())
        {

        }
        public RichtextResolver(Schema schema)
        {
            _schema = schema;
        }

        public void AddNode(string key, Element node)
        {
            _schema.Nodes.Add(key, node);
        }

        public string Render(Richtext data)
        {
            if (data.Content != null)
            {
                var html = new StringBuilder();
                foreach (var node in data.Content)
                {
                    html.Append(RenderNode(node));
                }
                return html.ToString();
            }

            return string.Empty;
        }

        public string RenderNode(Node item)
        {
            var html = new StringBuilder();

            if (item.Marks != null)
            {
                foreach (var m in item.Marks)
                {
                    var mark = GetMatchingMark(m);

                    if (mark != null)
                    {
                        html.Append(RenderOpeningTag(mark));
                    }
                }
            }

            var node = GetMatchingNode(item);

            if (node != null && !node.IsSingleTag)
            {
                html.Append(RenderOpeningTag(node));
            }

            if (item.Content != null)
            {
                foreach (var content in item.Content)
                {
                    html.Append(RenderNode(content));
                }
            }
            else if (!string.IsNullOrEmpty(item.Text))
            {
                html.Append(HtmlHelper.EscapeHtml(item.Text));
            }
            else if (node != null && node.IsSingleTag)
            {
                html.Append(RenderTag(node, " /"));
            }
            else if (!string.IsNullOrEmpty(node?.Html))
            {
                html.Append(node.Html);
            }

            if (node != null && !node.IsSingleTag)
            {
                html.Append(RenderClosingTag(node));
            }

            if (item.Marks != null)
            {
                var marks = item.Marks.ToList();
                marks.Reverse();
                foreach (var m in marks)
                {
                    var mark = GetMatchingMark(m);

                    if (mark != null)
                    {
                        html.Append(RenderClosingTag(mark));
                    }
                }
            }

            return html.ToString();
        }

        public string RenderOpeningTag(ElementTag tag)
        {
            return RenderTag(tag);
        }

        public string RenderTag(ElementTag tag, string ending = "")
        {
            var html = new StringBuilder();
            html.Append($"<{tag.Tag}");

            if (tag.Attrs != null)
            {
                foreach (var attr in tag.Attrs)
                {
                    html.Append($" {attr.Key}=\"{attr.Value}\"");
                }
            }

            html.Append($"{ending}>");

            if (tag.Tags != null)
            {
                foreach (var t in tag.Tags)
                {
                    html.Append(RenderTag(t, ending));
                }
            }

            return html.ToString();
        }

        public string RenderClosingTag(ElementTag tag)
        {
            var html = new StringBuilder();
            html.Append($"</{tag.Tag}>");

            if (tag.Tags != null)
            {
                foreach (var t in tag.Tags)
                {
                    RenderClosingTag(t);
                }
            }

            return html.ToString();
        }

        public ElementTag GetMatchingNode(Node node)
        {
            ElementTag tag = null;
            if (_schema.Nodes.ContainsKey(node.Type))
            {
                tag = _schema.Nodes[node.Type].Render(node);
            }
            return tag;
        }

        public ElementTag GetMatchingMark(Node node)
        {
            ElementTag tag = null;
            if (_schema.Marks.ContainsKey(node.Type))
            {
                tag = _schema.Marks[node.Type].Render(node);
            }
            return tag;
        }
    }
}
