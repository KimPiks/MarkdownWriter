# MarkdownWriter

Library for creating Markdown files in c#

```dotnet add package csharp-MarkdownWriter```

## Usage

1. Create an instance of the Markdown class with the name of the target file <br>
```var md = new Markdown("EXAMPLE");```

2. Add the necessary elements to your file using functions from [Docs](https://github.com/KimPiks/MarkdownWriter/blob/main/README.md#Docs) <br>

```
md.H1("Header");
md.LineBreak();
md.Text("Hello");
```

3. Save your file
```await md.SaveAndWrite();```

Your file will be saved as `EXAMPLE.md` in the program execution location

## Docs

* ```Text(string text)```
* ```TaskList(string text, bool @checked = false)```
* ```Table(List<Table> tables)```
* ```UnorderedList(List<ListItem> listItems)```
* ```OrderedList(List<ListItem> listItems)```
* ```Link(string text, string url)```
* ```LineBreak()```
* ```Image(string text, string path)```
* ```H1(string text)```
* ```H2(string text)```
* ```H3(string text)```
* ```H4(string text)```
* ```H5(string text)```
* ```H6(string text)```
* ```Italic(string text)```
* ```Bold(string text)```
* ```Code(string code)```
* ```Blockquote(string text)```
* ```async SaveAndWrite()```

## Example
```
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
```

For example, the generated file can be found at [here](https://github.com/KimPiks/MarkdownWriter/blob/main/EXAMPLE.md)
