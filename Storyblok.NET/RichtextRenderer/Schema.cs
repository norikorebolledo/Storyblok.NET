using Storyblok.NET.RichtextRenderer.Marks;
using Storyblok.NET.RichtextRenderer.Nodes;

namespace Storyblok.NET.RichtextRenderer
{
    public class Schema
    {
        public Dictionary<string, Element> Nodes { get; set; } = new Dictionary<string, Element>()
        {
            { "horizontal_rule",  new HorizontalRule() },
            { "blockquote",  new Blockquoute() },
            { "bullet_list",  new BulletList() },
            { "code_block",  new CodeBlock() },
            { "hard_break",  new HardBreak() },
            { "heading",  new Heading() },
            { "image",  new Image() },
            { "list_item",  new ListItem() },
            { "ordered_list",  new OrderedList() },
            { "paragraph",  new Paragraph() }
        };
        public Dictionary<string, Element> Marks { get; set; } = new Dictionary<string, Element>()
        {
            { "bold",  new Bold() },
            { "strike",  new Strike() },
            { "underline",  new Underline() },
            { "strong",  new Strong() },
            { "code",  new Code() },
            { "italic",  new Italic() },
            { "link",  new Link() },
            { "styled",  new Styled() }
        };
    }
}
