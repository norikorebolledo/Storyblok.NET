using Storyblok.NET.ProseMirror;

namespace Storyblok.NET.RichtextRenderer.Nodes
{
    public class CodeBlock : Element
    {
        public override ElementTag Render(Node node)
        {
            return new ElementTag
            {
                Tag = "pre",
                Tags = new ElementTag[] {
                    new ElementTag{ Tag = "code" }
                }
            };
        }
    }
}
