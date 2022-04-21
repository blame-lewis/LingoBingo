namespace LingoBingo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationalblamenetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridCountBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sheetCountBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fontSizeBar = new System.Windows.Forms.TrackBar();
            this.printButton = new System.Windows.Forms.Button();
            this.saveToDiskButton = new System.Windows.Forms.Button();
            this.titleSizeBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridHeightBox = new System.Windows.Forms.MaskedTextBox();
            this.gridWidthBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveWordListButton = new System.Windows.Forms.Button();
            this.loadWordListButton = new System.Windows.Forms.Button();
            this.wordListBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.saveWordListDialog = new System.Windows.Forms.SaveFileDialog();
            this.openWordListDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCardsDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleSizeBar)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.wordListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToDiskToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 6);
            // 
            // saveToDiskToolStripMenuItem
            // 
            this.saveToDiskToolStripMenuItem.Name = "saveToDiskToolStripMenuItem";
            this.saveToDiskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToDiskToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveToDiskToolStripMenuItem.Text = "Save...";
            this.saveToDiskToolStripMenuItem.Click += new System.EventHandler(this.saveToDiskToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // wordListToolStripMenuItem
            // 
            this.wordListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.wordListToolStripMenuItem.Name = "wordListToolStripMenuItem";
            this.wordListToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.wordListToolStripMenuItem.Text = "Word List";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nationalblamenetToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // nationalblamenetToolStripMenuItem
            // 
            this.nationalblamenetToolStripMenuItem.Name = "nationalblamenetToolStripMenuItem";
            this.nationalblamenetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.nationalblamenetToolStripMenuItem.Text = "National Blame Website";
            this.nationalblamenetToolStripMenuItem.Click += new System.EventHandler(this.nationalblamenetToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridCountBox);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.sheetCountBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.fontSizeBar);
            this.splitContainer1.Panel1.Controls.Add(this.printButton);
            this.splitContainer1.Panel1.Controls.Add(this.saveToDiskButton);
            this.splitContainer1.Panel1.Controls.Add(this.titleSizeBar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.gridHeightBox);
            this.splitContainer1.Panel1.Controls.Add(this.gridWidthBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.titleBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(624, 414);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridCountBox
            // 
            this.gridCountBox.Location = new System.Drawing.Point(436, 5);
            this.gridCountBox.Mask = "##";
            this.gridCountBox.Name = "gridCountBox";
            this.gridCountBox.PromptChar = ' ';
            this.gridCountBox.RejectInputOnFirstFailure = true;
            this.gridCountBox.Size = new System.Drawing.Size(37, 20);
            this.gridCountBox.TabIndex = 15;
            this.gridCountBox.Text = "1";
            this.gridCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gridCountBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.gridCountBox_MaskInputRejected);
            this.gridCountBox.TextChanged += new System.EventHandler(this.gridCountBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grids Per Page:";
            // 
            // sheetCountBox
            // 
            this.sheetCountBox.Location = new System.Drawing.Point(306, 6);
            this.sheetCountBox.Mask = "###";
            this.sheetCountBox.Name = "sheetCountBox";
            this.sheetCountBox.PromptChar = ' ';
            this.sheetCountBox.RejectInputOnFirstFailure = true;
            this.sheetCountBox.Size = new System.Drawing.Size(37, 20);
            this.sheetCountBox.TabIndex = 13;
            this.sheetCountBox.Text = "1";
            this.sheetCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sheet Count:";
            // 
            // fontSizeBar
            // 
            this.fontSizeBar.Location = new System.Drawing.Point(205, 32);
            this.fontSizeBar.Maximum = 20;
            this.fontSizeBar.Name = "fontSizeBar";
            this.fontSizeBar.Size = new System.Drawing.Size(120, 45);
            this.fontSizeBar.TabIndex = 7;
            this.fontSizeBar.Scroll += new System.EventHandler(this.fontSizeBar_Scroll);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(529, 44);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(83, 25);
            this.printButton.TabIndex = 11;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // saveToDiskButton
            // 
            this.saveToDiskButton.Location = new System.Drawing.Point(529, 6);
            this.saveToDiskButton.Name = "saveToDiskButton";
            this.saveToDiskButton.Size = new System.Drawing.Size(83, 25);
            this.saveToDiskButton.TabIndex = 10;
            this.saveToDiskButton.Text = "Save to Disk";
            this.saveToDiskButton.UseVisualStyleBackColor = true;
            this.saveToDiskButton.Click += new System.EventHandler(this.saveToDiskButton_Click);
            // 
            // titleSizeBar
            // 
            this.titleSizeBar.Location = new System.Drawing.Point(380, 32);
            this.titleSizeBar.Maximum = 20;
            this.titleSizeBar.Name = "titleSizeBar";
            this.titleSizeBar.Size = new System.Drawing.Size(117, 45);
            this.titleSizeBar.TabIndex = 9;
            this.titleSizeBar.Scroll += new System.EventHandler(this.titleSizeBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Title Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font Size:";
            // 
            // gridHeightBox
            // 
            this.gridHeightBox.Location = new System.Drawing.Point(87, 47);
            this.gridHeightBox.Mask = "##";
            this.gridHeightBox.Name = "gridHeightBox";
            this.gridHeightBox.PromptChar = ' ';
            this.gridHeightBox.RejectInputOnFirstFailure = true;
            this.gridHeightBox.Size = new System.Drawing.Size(56, 20);
            this.gridHeightBox.TabIndex = 5;
            this.gridHeightBox.Text = "3";
            this.gridHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gridHeightBox.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
            // 
            // gridWidthBox
            // 
            this.gridWidthBox.Location = new System.Drawing.Point(87, 27);
            this.gridWidthBox.Mask = "##";
            this.gridWidthBox.Name = "gridWidthBox";
            this.gridWidthBox.PromptChar = ' ';
            this.gridWidthBox.Size = new System.Drawing.Size(56, 20);
            this.gridWidthBox.TabIndex = 4;
            this.gridWidthBox.Text = "3";
            this.gridWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gridWidthBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.gridWidthBox_TypeValidationCompleted);
            this.gridWidthBox.TextChanged += new System.EventHandler(this.gridWidthBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grid Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grid Width:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(87, 5);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(136, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.Text = "Bingo Game Title";
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(624, 329);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveWordListButton);
            this.groupBox1.Controls.Add(this.loadWordListButton);
            this.groupBox1.Controls.Add(this.wordListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Word List";
            // 
            // saveWordListButton
            // 
            this.saveWordListButton.Location = new System.Drawing.Point(70, 19);
            this.saveWordListButton.Name = "saveWordListButton";
            this.saveWordListButton.Size = new System.Drawing.Size(56, 23);
            this.saveWordListButton.TabIndex = 1;
            this.saveWordListButton.Text = "Save";
            this.saveWordListButton.UseVisualStyleBackColor = true;
            this.saveWordListButton.Click += new System.EventHandler(this.saveWordListButton_Click);
            // 
            // loadWordListButton
            // 
            this.loadWordListButton.Location = new System.Drawing.Point(8, 19);
            this.loadWordListButton.Name = "loadWordListButton";
            this.loadWordListButton.Size = new System.Drawing.Size(56, 23);
            this.loadWordListButton.TabIndex = 0;
            this.loadWordListButton.Text = "Load";
            this.loadWordListButton.UseVisualStyleBackColor = true;
            this.loadWordListButton.Click += new System.EventHandler(this.loadWordListButton_Click);
            // 
            // wordListBox
            // 
            this.wordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wordListBox.Location = new System.Drawing.Point(9, 48);
            this.wordListBox.Multiline = true;
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(149, 276);
            this.wordListBox.TabIndex = 0;
            this.wordListBox.Text = "Orange\r\nBanana\r\nApple\r\nPineapple\r\nWatermelon\r\nRockmelon\r\nLemon\r\nLime\r\nApricot\r\nPe" +
                "ach\r\nPlum\r\nMandarine\r\nTangerine\r\nMango\r\nPapaya\r\nKiwifruit\r\n";
            this.wordListBox.TextChanged += new System.EventHandler(this.wordListBox_TextChanged);
            this.wordListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordListBox_KeyDown);
            this.wordListBox.Leave += new System.EventHandler(this.wordListBox_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.previewPanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 329);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(3, 16);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(453, 310);
            this.previewPanel.TabIndex = 0;
            this.previewPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewPanel_MouseDown);
            // 
            // saveWordListDialog
            // 
            this.saveWordListDialog.FileName = "Bingo Word List.txt";
            this.saveWordListDialog.Filter = "Text Files|*.txt";
            this.saveWordListDialog.Title = "Save Word List";
            // 
            // openWordListDialog
            // 
            this.openWordListDialog.FileName = "Bingo Word List.txt";
            this.openWordListDialog.Filter = "Text Files|*.txt";
            this.openWordListDialog.Title = "Load Word List";
            // 
            // saveCardsDialog
            // 
            this.saveCardsDialog.DefaultExt = "png";
            this.saveCardsDialog.FileName = "Bingo Cards.png";
            this.saveCardsDialog.Filter = "PNG Images|*.png";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 438);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "MainForm";
            this.Text = "LingoBingo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleSizeBar)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveWordListButton;
        private System.Windows.Forms.Button loadWordListButton;
        private System.Windows.Forms.TextBox wordListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox gridHeightBox;
        private System.Windows.Forms.MaskedTextBox gridWidthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar fontSizeBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar titleSizeBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveToDiskButton;
        private System.Windows.Forms.MaskedTextBox sheetCountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.MaskedTextBox gridCountBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveWordListDialog;
        private System.Windows.Forms.OpenFileDialog openWordListDialog;
        private System.Windows.Forms.SaveFileDialog saveCardsDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationalblamenetToolStripMenuItem;
    }
}

