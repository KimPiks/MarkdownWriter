namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Text(string text)
        {
            _lines.Add($"{text}");
            return this;
        }
    }
}
