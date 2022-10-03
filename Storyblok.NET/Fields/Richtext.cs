using Markdig;
using Storyblok.NET.ProseMirror;
using Storyblok.NET.RichtextRenderer;
using System.Text.Json.Serialization;

namespace Storyblok.NET.Fields
{
    public class Richtext
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("content")]
        public Node[] Content { get; set; }

        public string PreviousFieldValue { get; set; }

        public string Html
        {
            get
            {

                if(!string.IsNullOrEmpty(PreviousFieldValue))
                {
                    var builder = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
                    return Markdown.ToHtml(PreviousFieldValue ?? "", builder);
                }

                var resolver = new RichtextResolver();
                return resolver.Render(this);
            }
        }
    }
}
