using System.Text.RegularExpressions;

namespace Storyblok.NET.Helpers
{
    public static class HtmlHelper
    {
        public static string EscapeHtml(string html)
        {
            var htmlExcapes = new Dictionary<string, string>
            {
                { "&", "&amp;" },
                { "<", "&lt;" },
                { ">", "&gt;" },
                { "\"", "&quot;"},
                {"'", "&#39;"}
            };

            var reUnescapedHtml = "/[&<> \"']/g";
            var reHasUnescapedHtml = new Regex(reUnescapedHtml, RegexOptions.IgnoreCase);
            return !string.IsNullOrEmpty(html) && reHasUnescapedHtml.IsMatch(html) 
                        ? reHasUnescapedHtml.Replace(html, match => htmlExcapes[match.Value])
                        : html;
        }
    }
}
