using MarkdownWriter.data;

namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown UnorderedList(List<ListItem> listItems) 
        {
            foreach (var item in listItems) 
            {
                _lines.Add($"* {item.Value}");
                if (item.Child != null)
                {
                    foreach (var child in item.Child)
                    {
                        _lines.Add($"\t* {child.Value}");
                    }
                }
            }
            this.AddEmptyLine();
            return this;
        }

        public Markdown OrderedList(List<ListItem> listItems)
        {
            foreach (var (item, index) in listItems.Select((item, index) => (item, index)))
            {
                _lines.Add($"{index + 1}. {item.Value}");
                if (item.Child != null)
                {
                    foreach (var child in item.Child)
                    {
                        _lines.Add($"\t* {child.Value}");
                    }
                }
            }
            this.AddEmptyLine();
            return this;
        }
    }
}
