namespace MarkdownWriter
{
    public partial class Markdown
    {
        private readonly string _name;
        private readonly List<string> _lines;

        public Markdown(string markdownFileName)
        {
            _name = markdownFileName;
            _lines = new List<string>();
        }

        public async Task SaveAndWrite()
        {
            await File.WriteAllLinesAsync($"{_name}.md", _lines);
        }

        private void AddEmptyLine() => _lines.Add(string.Empty);
    }
}