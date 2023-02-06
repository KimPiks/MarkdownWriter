namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Blockquote(string text)
        {
            _lines.Add($"> {text}");
            this.AddEmptyLine();
            return this;
        }
    }
}
