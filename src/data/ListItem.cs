namespace MarkdownWriter.data
{
    public class ListItem
    {
        public string Value { get; set; } = string.Empty;
        public List<ListItem>? Child { get; set; }
    }
}
