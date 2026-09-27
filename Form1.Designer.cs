using System;
using System.Drawing;
using System.Windows.Forms;

namespace dotnet_miniproject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblKeywordPrompt = new Label();
            txtKeyword = new TextBox();
            grpSearchScope = new GroupBox();
            rbEntireSystem = new RadioButton();
            rbSelectedFolder = new RadioButton();
            btnBrowse = new Button();
            txtPath = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            txtheading = new Label();
            label3 = new Label();
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lvResults = new ListView();
            colFileName = new ColumnHeader();
            colLineNumber = new ColumnHeader();
            colMatchedLine = new ColumnHeader();

            grpSearchScope.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(231, 122);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;

            // lblKeywordPrompt
            lblKeywordPrompt.AutoSize = true;
            lblKeywordPrompt.Font = new Font("Segoe UI Black", 18.25F, FontStyle.Bold);
            lblKeywordPrompt.ForeColor = Color.DarkMagenta;
            lblKeywordPrompt.Location = new Point(259, 102);
            lblKeywordPrompt.Name = "lblKeywordPrompt";
            lblKeywordPrompt.Size = new Size(341, 35);
            lblKeywordPrompt.TabIndex = 1;
            lblKeywordPrompt.Text = "Enter a keyword to search:";

            // txtKeyword
            txtKeyword.Font = new Font("Segoe UI", 14.25F);
            txtKeyword.Location = new Point(616, 102);
            txtKeyword.Multiline = true;
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(244, 35);
            txtKeyword.TabIndex = 2;

            // grpSearchScope
            grpSearchScope.Controls.Add(rbEntireSystem);
            grpSearchScope.Controls.Add(rbSelectedFolder);
            grpSearchScope.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            grpSearchScope.Location = new Point(420, 179);
            grpSearchScope.Name = "grpSearchScope";
            grpSearchScope.Size = new Size(500, 100);
            grpSearchScope.TabIndex = 3;
            grpSearchScope.TabStop = false;
            grpSearchScope.Text = "Search Location";

            // rbEntireSystem
            rbEntireSystem.AutoSize = true;
            rbEntireSystem.Location = new Point(20, 60);
            rbEntireSystem.Name = "rbEntireSystem";
            rbEntireSystem.Size = new Size(129, 24);
            rbEntireSystem.TabIndex = 1;
            rbEntireSystem.TabStop = true;
            rbEntireSystem.Text = "Search entirely";
            rbEntireSystem.CheckedChanged += new EventHandler(rbEntireSystem_CheckedChanged);

            // rbSelectedFolder
            rbSelectedFolder.AutoSize = true;
            rbSelectedFolder.Location = new Point(20, 30);
            rbSelectedFolder.Name = "rbSelectedFolder";
            rbSelectedFolder.Size = new Size(194, 24);
            rbSelectedFolder.TabIndex = 0;
            rbSelectedFolder.TabStop = true;
            rbSelectedFolder.Text = "Search in selected folder";
            rbSelectedFolder.CheckedChanged += new EventHandler(rdoSelectedFolder_CheckedChanged);

            // btnBrowse
            btnBrowse.BackColor = Color.SteelBlue;
            btnBrowse.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(924, 102);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(172, 32);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse Folder";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += new EventHandler(btnBrowse_Click);

            // txtPath
            txtPath.Location = new Point(481, 312);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(400, 23);
            txtPath.TabIndex = 5;

            // btnSearch
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(580, 351);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += new EventHandler(btnSearch_Click);

            // btnClear
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Font = new Font("Georgia", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(720, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 33);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += new EventHandler(btnClear_Click);

            // txtheading
            txtheading.AutoSize = true;
            txtheading.Font = new Font("Georgia", 21.75F, FontStyle.Bold);
            txtheading.ForeColor = Color.White;
            txtheading.Location = new Point(526, 18);
            txtheading.Name = "txtheading";
            txtheading.Size = new Size(355, 34);
            txtheading.TabIndex = 8;
            txtheading.Text = "Text File Search Utility";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 10;

            // pnlHeader
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(txtheading);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1318, 70);
            pnlHeader.TabIndex = 11;

            // pictureBox1
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;

            // panel2
            panel2.BackColor = Color.SteelBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 577);
            panel2.Name = "panel2";
            panel2.Size = new Size(1318, 34);
            panel2.TabIndex = 12;

            // lvResults
            lvResults.Columns.AddRange(new ColumnHeader[] { colFileName, colLineNumber, colMatchedLine });
            lvResults.FullRowSelect = true;
            lvResults.GridLines = true;
            lvResults.Location = new Point(80, 399);
            lvResults.Name = "lvResults";
            lvResults.Size = new Size(1199, 236);
            lvResults.TabIndex = 13;
            lvResults.UseCompatibleStateImageBehavior = false;
            lvResults.View = View.Details;
            lvResults.DoubleClick += new EventHandler(LvResults_DoubleClick);

            // colFileName
            colFileName.Text = "File Name";
            colFileName.Width = 300;

            // colLineNumber
            colLineNumber.Text = "Line No.";
            colLineNumber.Width = 80;

            // colMatchedLine
            colMatchedLine.Text = "Matched Line";
            colMatchedLine.Width = 400;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1318, 611);
            Controls.Add(btnClear);
            Controls.Add(lvResults);
            Controls.Add(pnlHeader);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtPath);
            Controls.Add(btnBrowse);
            Controls.Add(grpSearchScope);
            Controls.Add(txtKeyword);
            Controls.Add(lblKeywordPrompt);
            Controls.Add(label1);
            Location = new Point(550, 100);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            Text = "Ins_miniproject";
            WindowState = FormWindowState.Maximized;
            Load += new EventHandler(Form1_Load);

            grpSearchScope.ResumeLayout(false);
            grpSearchScope.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKeywordPrompt;
        private TextBox txtKeyword;
        private GroupBox grpSearchScope;
        private RadioButton rbSelectedFolder;
        private RadioButton rbEntireSystem;
        private Button btnBrowse;
        private TextBox txtPath;
        private Button btnSearch;
        private Button btnClear;
        private Label txtheading;
        private Label label3;
        private Panel pnlHeader;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ListView lvResults;
        private ColumnHeader colFileName;
        private ColumnHeader colLineNumber;
        private ColumnHeader colMatchedLine;
    }
}
