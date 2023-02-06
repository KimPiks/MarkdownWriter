namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown H1(string text)
        {
            _lines.Add($"# {text}");
            return this;
        }

        public Markdown H2(string text)
        {
            _lines.Add($"## {text}");
            return this;
        }
        public Markdown H3(string text)
        {
            _lines.Add($"### {text}");
            return this;
        }

        public Markdown H4(string text)
        {
            _lines.Add($"#### {text}");
            return this;
        }

        public Markdown H5(string text)
        {
            _lines.Add($"##### {text}");
            return this;
        }

        public Markdown H6(string text)
        {
            _lines.Add($"###### {text}");
            return this;
        }
    }
}
