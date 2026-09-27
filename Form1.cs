using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_miniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set ListView column headers for summary view
            if (lvResults.Columns.Count >= 3)
            {
                lvResults.Columns[0].Text = "File Name";
                lvResults.Columns[1].Text = "Occurrences";
                lvResults.Columns[2].Text = "File Path";
            }

            lvResults.View = View.Details;
            lvResults.FullRowSelect = true;
            lvResults.GridLines = true;

            rbSelectedFolder.CheckedChanged += rdoSelectedFolder_CheckedChanged;
            rbEntireSystem.CheckedChanged += rbEntireSystem_CheckedChanged;
        }

        string lastSearchedKeyword = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Require mode selection before browsing
            if (!rbSelectedFolder.Checked && !rbEntireSystem.Checked)
            {
                MessageBox.Show("Please select a search mode first (Specific Folder or Entire System).");
                return;
            }

            // Disallow browsing in Entire System mode
            if (rbEntireSystem.Checked)
            {
                MessageBox.Show("Browse is only available when 'Search in Selected Folder' is selected.");
                return;
            }

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();
            string path = txtPath.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a keyword.");
                return;
            }

            if (rbSelectedFolder.Checked && string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Please select a folder.");
                return;
            }

            lvResults.Items.Clear();
            lastSearchedKeyword = keyword;

            string baseDir = rbEntireSystem.Checked ? @"C:\" : path;

            btnSearch.Enabled = false;
            btnBrowse.Enabled = false;
            Cursor = Cursors.WaitCursor;

            label3.Text = "Searching...";
            label3.Refresh();

            bool anyMatchesFound = false;

            try
            {
                await Task.Run(() =>
                {
                    Queue<string> dirs = new Queue<string>();
                    dirs.Enqueue(baseDir);

                    while (dirs.Count > 0)
                    {
                        string currentDir = dirs.Dequeue();
                        try
                        {
                            foreach (string file in Directory.EnumerateFiles(currentDir, "*.txt"))
                            {
                                try
                                {
                                    int count = 0;
                                    List<int> matchLines = new List<int>();
                                    int lineNumber = 0;

                                    foreach (var line in File.ReadLines(file))
                                    {
                                        if (line.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                                        {
                                            count++;
                                            matchLines.Add(lineNumber);
                                        }
                                        lineNumber++;
                                    }

                                    if (count > 0)
                                    {
                                        anyMatchesFound = true;
                                        Invoke(new Action(() =>
                                        {
                                            var item = new ListViewItem(Path.GetFileName(file));
                                            item.SubItems.Add(count.ToString());
                                            item.SubItems.Add(file);
                                            item.Tag = new { FilePath = file, MatchLines = matchLines };
                                            lvResults.Items.Add(item);
                                        }));
                                    }
                                }
                                catch { }
                            }

                            foreach (string subDir in Directory.GetDirectories(currentDir))
                            {
                                dirs.Enqueue(subDir);
                            }
                        }
                        catch
                        {
                            continue; // Skip inaccessible folders
                        }
                    }
                });

                if (lvResults.Columns.Count > 0)
                {
                    lvResults.Columns[lvResults.Columns.Count - 1].Width = -2;
                }
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
                btnBrowse.Enabled = true;

                if (!anyMatchesFound)
                {
                    label3.Text = "No matches found.";
                    MessageBox.Show("No matches found.");
                }
                else
                {
                    label3.Text = $"Search complete. {lvResults.Items.Count} file(s) found.";
                    MessageBox.Show($"Search complete. {lvResults.Items.Count} file(s) found.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            txtPath.Clear();
            lvResults.Items.Clear();
            Cursor = Cursors.Default;
            label3.Text = "";
            btnSearch.Enabled = true;
            btnBrowse.Enabled = true;
            rbSelectedFolder.Checked = false;
            rbEntireSystem.Checked = false;
        }

        private void rbEntireSystem_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Enabled = !rbEntireSystem.Checked;
            btnBrowse.Enabled = !rbEntireSystem.Checked;
        }

        private void rdoSelectedFolder_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Enabled = true;
            btnBrowse.Enabled = true;
        }

        private void LvResults_DoubleClick(object sender, EventArgs e)
        {
            if (lvResults.SelectedItems.Count == 0)
                return;

            var tag = lvResults.SelectedItems[0].Tag;
            if (tag == null) return;

            string filePath = (string)tag.GetType().GetProperty("FilePath")?.GetValue(tag, null);
            var matchLines = tag.GetType().GetProperty("MatchLines")?.GetValue(tag, null) as List<int>;

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                int firstLine = (matchLines != null && matchLines.Count > 0) ? matchLines[0] : 0;
                var viewer = new FileViewer(filePath, lastSearchedKeyword, matchLines, firstLine);
                viewer.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void txtKeyword_TextChanged(object sender, EventArgs e) { }
        private void grpSearchLocation_Enter(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
