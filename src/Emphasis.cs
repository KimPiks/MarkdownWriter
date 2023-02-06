namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Italic(string text)
        {
            _lines.Add($"_{text}_");
            return this;
        }

        public Markdown Bold(string text)
        {
            _lines.Add($"__{text}__");
            return this;
        }
    }
}
