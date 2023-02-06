namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown TaskList(string text, bool @checked = false)
        {
            var checkedField = @checked ? "[x]" : "[ ]";
            _lines.Add($"- {checkedField} {text}");
            return this;
        }
    }
}
