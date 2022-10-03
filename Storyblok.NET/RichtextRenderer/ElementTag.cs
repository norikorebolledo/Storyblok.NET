namespace Storyblok.NET.RichtextRenderer
{
    public class ElementTag
    {
        public string Tag { get; set; }
        public bool IsSingleTag { get; set; }
        public Dictionary<string, object> Attrs { get; set; }
        public string Html { get; set; }
        public ElementTag[] Tags { get; set; }
    }
}
