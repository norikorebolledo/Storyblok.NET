using System.Text.Json.Serialization;

namespace Storyblok.NET.ProseMirror
{
    public class Node
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attrs")]
        public virtual NodeAttributes Attrs { get; set; }

        [JsonPropertyName("marks")]
        public virtual Node[] Marks { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("content")]
        public Node[] Content { get; set; }
    }
}
