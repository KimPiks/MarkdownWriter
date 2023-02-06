using MarkdownWriter.data;

namespace MarkdownWriter
{
    public partial class Markdown
    {
        public Markdown Table(List<Table> tables)
        {
            var headerLine = string.Empty;
            var headerBreak = string.Empty;
            var valuesLines = new List<string>();

            for (var i = 0; i < tables.Count; i++)
            {
                headerLine += tables[i].Header;
                headerBreak += "----";

                if (i < tables.Count() - 1)
                {
                    headerLine += " | ";
                    headerBreak += " | ";
                }

                for (var o = 0; o < tables[i].Values.Count(); o++)
                {
                    if (valuesLines.Count() <= o)
                        valuesLines.Add(string.Empty);

                    valuesLines[o] += tables[i].Values[o];

                    if (i < tables.Count() - 1)
                        valuesLines[o] += " | ";
                }
            }

            _lines.Add(headerLine);
            _lines.Add(headerBreak);
            _lines.AddRange(valuesLines);

            this.AddEmptyLine();
            return this;
        }
    }
}
