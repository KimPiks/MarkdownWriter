namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Code(string code)
        {
            this.AddEmptyLine();
            _lines.Add($"```{code}```");
            this.AddEmptyLine();
            return this;
        }
    }
}
