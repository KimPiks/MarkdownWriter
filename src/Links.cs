namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Link(string text, string url)
        {
            _lines.Add($"[{text}]({url})");
            return this;
        }
    }
}
