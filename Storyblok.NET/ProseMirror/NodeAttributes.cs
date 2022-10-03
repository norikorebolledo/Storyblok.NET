using System.Text.Json.Serialization;

namespace Storyblok.NET.ProseMirror
{
    public class NodeAttributes
    {
        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonPropertyName("alt")]
        public string Alt { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("target")]
        public string Target { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("linktype")]
        public string LinkType { get; set; }

        [JsonPropertyName("anchor")]
        public string Anchor { get; set; }
    }
}
