namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown LineBreak()
        {
            _lines.Add($"<br>");
            return this;
        }
    }
}
