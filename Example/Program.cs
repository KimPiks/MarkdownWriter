using MarkdownWriter;
using MarkdownWriter.data;

var md = new Markdown("EXAMPLE");

// Table
var table = new List<Table>()
{
    new Table() { Header = "A1", Values = new List<string>() { "val1", "val2", "val3" } },
    new Table() { Header = "B1", Values = new List<string>() { "val4", "val5", "val6" } },
     new Table() { Header = "C1", Values = new List<string>() { "val7", "val8", "val9" } }
};

md.Table(table);

// Tasklist
md.TaskList("task1", true);
md.TaskList("task2");

// List
var list = new List<ListItem>()
{
    new ListItem() { Value = "a", Child = new List<ListItem>() { new ListItem() { Value = "b" } } },
    new ListItem() { Value = "c", Child = new List<ListItem>() { new ListItem() { Value = "d" }, new ListItem() { Value = "2" } } },
    new ListItem() { Value = "e" },
    new ListItem() { Value = "f" },
    new ListItem() { Value = "g", Child = new List<ListItem>() { new ListItem() { Value = "x" } } },
    new ListItem() { Value = "i" }
};

md.UnorderedList(list);
md.OrderedList(list);

// Linebreak
md.LineBreak();

// Code
md.Code("<script>alert()</script>");

// Header
md.H1("Header");

// Link
md.Link("Github", "https://github.com/KimPiks/");

md.LineBreak();

// Text
md.Text("Text");

// Blockquotes
md.Blockquote("Quote");

// Images
md.Image("Img", "https://avatars.githubusercontent.com/u/35846232?v=4");

md.LineBreak();

// You can also combine functions in this way to simplify notation
md.Italic("Some").LineBreak().Bold("text" ).Text("sth");

await md.SaveAndWrite();