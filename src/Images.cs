namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Image(string text, string path)
        {
            _lines.Add($"![{text}]({path})");
            return this;
        }
    }
}
