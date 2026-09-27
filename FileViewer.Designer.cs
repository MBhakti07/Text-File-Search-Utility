namespace dotnet_miniproject
{
    partial class FileViewer
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox richTextBoxViewer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            richTextBoxViewer = new RichTextBox();
            SuspendLayout();

            // 
            // richTextBoxViewer
            // 
            richTextBoxViewer.Dock = DockStyle.Fill;
            richTextBoxViewer.Location = new System.Drawing.Point(0, 0);
            richTextBoxViewer.Name = "richTextBoxViewer";
            richTextBoxViewer.ReadOnly = true;
            richTextBoxViewer.Size = new System.Drawing.Size(800, 450);
            richTextBoxViewer.TabIndex = 0;
            richTextBoxViewer.Text = "";

            // 
            // FileViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(richTextBoxViewer);
            Name = "FileViewer";
            Text = "File Viewer";
            Load += FileViewer_Load;  // ✅ This was missing before
            ResumeLayout(false);
        }
    }
}
