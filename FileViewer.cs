using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dotnet_miniproject
{
    public partial class FileViewer : Form
    {
        private string keyword;
        private List<int> matchLines;

        public FileViewer(string filePath, string keyword, List<int> matchLines, int highlightLine)
        {
            InitializeComponent();
            this.keyword = keyword;
            this.matchLines = matchLines;

            //  Set window title dynamically
            this.Text = $"Text File Search Utility - {Path.GetFileName(filePath)}";

            HighlightFileContent(filePath, highlightLine);
        }

        private void HighlightFileContent(string filePath, int highlightLine)
        {
            string[] lines = File.ReadAllLines(filePath);
            richTextBoxViewer.Text = string.Join(Environment.NewLine, lines);

            // Scroll to first match line
            int charIndex = richTextBoxViewer.GetFirstCharIndexFromLine(highlightLine);
            if (charIndex >= 0)
            {
                richTextBoxViewer.Select(charIndex, 0);
                richTextBoxViewer.ScrollToCaret();
            }

            // Highlight all keyword occurrences (case-insensitive)
            int startIndex = 0;
            string content = richTextBoxViewer.Text;

            while (startIndex < content.Length)
            {
                int wordStartIndex = content.IndexOf(keyword, startIndex, StringComparison.OrdinalIgnoreCase);
                if (wordStartIndex == -1)
                    break;

                richTextBoxViewer.Select(wordStartIndex, keyword.Length);
                richTextBoxViewer.SelectionBackColor = Color.Yellow;
                startIndex = wordStartIndex + keyword.Length;
            }
            richTextBoxViewer.SelectionLength = 0;
        }

        private void FileViewer_Load(object sender, EventArgs e)
        {
            // No changes needed here
        }
    }
}
