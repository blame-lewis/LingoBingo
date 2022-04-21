using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LingoBingo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updatePreview();
        }
        Bitmap generatePage(bool sameSeed)
        {
            int gridCount = 1;
            try
            {
                gridCount = int.Parse(gridCountBox.Text);
            }
            catch
            {
            }

            int boxesPerEdge = 1;
            int boxCount = 1;

            if (gridCount >= 2)
            {
                boxCount = 4;
                boxesPerEdge = 2;
            }
            if (gridCount >= 5)
            {
                boxCount = 9;
                boxesPerEdge = 3;
            }
            if (gridCount >= 10)
            {
                boxCount = 16;
            }
            while (boxCount < gridCount)
            {
                boxCount *= boxCount;
                boxesPerEdge++;
            }
            boxesPerEdge = (int)Math.Sqrt(boxCount);

            List<Bitmap> theGrids = new List<Bitmap>();

            const int overallSize = 768;
            for (int z = 0; z < gridCount; z++)
            {
                Bitmap boxBuffer = new Bitmap(overallSize, (int)(overallSize * Math.Sqrt(2)));
                Graphics g = Graphics.FromImage(boxBuffer);
                g.Clear(Color.White);
                int gridWidth = 3;
                int gridHeight = 3;

                try
                {
                    gridWidth = int.Parse(gridWidthBox.Text);
                    gridHeight = int.Parse(gridHeightBox.Text);
                }
                catch
                {
                }

                const int marginSize = 15;

                SizeF titleSize = g.MeasureString(titleBox.Text, new System.Drawing.Font(FontFamily.GenericSansSerif, 20 + (3 * titleSizeBar.Value)));
                g.DrawString(titleBox.Text, new System.Drawing.Font(FontFamily.GenericSansSerif, 20 + (3 * titleSizeBar.Value)), Brushes.Black, (boxBuffer.Width / 2) - (titleSize.Width / 2), 0);


                int headerSize = (int)titleSize.Height;

                for (int x = 0; x < gridWidth + 1; x++)
                {
                    int ax = (x * ((boxBuffer.Width - (marginSize * 2)) / gridWidth)) + marginSize;
                    g.DrawLine(Pens.Black, ax, marginSize + headerSize, ax, boxBuffer.Height - marginSize);
                }
                for (int y = 0; y < gridHeight + 1; y++)
                {
                    int ay = (y * ((boxBuffer.Height - (headerSize + (marginSize * 2))) / gridHeight)) + (marginSize + headerSize);
                    g.DrawLine(Pens.Black, marginSize, ay, boxBuffer.Width - marginSize, ay);
                }

                if (wordListBox.Text.Split('\n').Length > 0)
                {
                    int boxWidth = ((boxBuffer.Width - (marginSize * 2)) / gridWidth);
                    int boxHeight = ((boxBuffer.Height - (headerSize + (marginSize * 2))) / gridHeight);

                    List<string> wordCandidates = new List<string>(wordListBox.Text.Split('\n'));

                    Random r;
                    if (sameSeed)
                        r = new Random(0);
                    else
                        r = this.r;

                    Font f = new System.Drawing.Font(FontFamily.GenericSansSerif, 20 + (3 * fontSizeBar.Value));

                    for (int y = 0; y < gridHeight && wordCandidates.Count > 0; y++)
                        for (int x = 1; x < gridWidth + 1 && wordCandidates.Count > 0; x++)
                        {
                        goAgain:
                            if (wordCandidates.Count > 0)
                            {
                                int i = r.Next(wordCandidates.Count);

                                string s = wordCandidates[i];
                                wordCandidates.RemoveAt(i);
                                if (s.Trim() == "")
                                    goto goAgain;

                                SizeF size = g.MeasureString(s, f, new SizeF(boxWidth, boxHeight));

                                g.DrawString(s, f, Brushes.Black, new RectangleF((((x * boxWidth) + marginSize) - (boxWidth / 2)) - (size.Width / 2), (y * boxHeight) + (marginSize + headerSize), boxWidth, boxHeight));
                            }
                        }


                }
                theGrids.Add(boxBuffer);
            }

            int currentBox = 0;
            int finaly = 0;
            for (int y = 0; y < boxesPerEdge && currentBox < theGrids.Count; y++)
            {
                for (int x = 0; x < boxesPerEdge && currentBox < theGrids.Count; x++)
                {
                    currentBox++;
                }
                finaly += (int)(overallSize * Math.Sqrt(2));
            }
            currentBox = 0;
            Bitmap b = new Bitmap(boxesPerEdge * overallSize, finaly);
            Graphics gz = Graphics.FromImage(b);
            for (int y = 0; y < boxesPerEdge && currentBox < theGrids.Count; y++)
            {
                for (int x = 0; x < boxesPerEdge && currentBox < theGrids.Count; x++)
                {
                    gz.DrawImage(theGrids[currentBox], x * overallSize, y * (int)(overallSize * Math.Sqrt(2)));

                    currentBox++;
                }
                finaly += (int)(overallSize * Math.Sqrt(2));
            }
            return b;
        }
        void updatePreview()
        {
            previewPanel.BackgroundImage = generatePage(true);
        
        }

        private void wordListBox_Leave(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void gridWidthBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

        }

        private void gridWidthBox_TextChanged(object sender, EventArgs e)
        {

            updatePreview();
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

            updatePreview();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {

            updatePreview();
        }

        private void fontSizeBar_Scroll(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void wordListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                updatePreview();
            }
        }

        private void titleSizeBar_Scroll(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void previewPanel_MouseDown(object sender, MouseEventArgs e)
        {
            updatePreview();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridCountBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gridCountBox_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void saveWordListButton_Click(object sender, EventArgs e)
        {
            saveWordList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveWordList();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadWordList();
        }
        private void loadWordListButton_Click(object sender, EventArgs e)
        {
            loadWordList();
        }

        private void saveToDiskButton_Click(object sender, EventArgs e)
        {
            saveCollection();
        }
        private void saveToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveCollection();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printCollection();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printCollection();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }
        void saveWordList()
        {
            saveWordListDialog.ShowDialog();
            if(saveWordListDialog.FileName != null)
                if (saveWordListDialog.FileName.Trim() != "")
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveWordListDialog.FileName, wordListBox.Text);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Couldn't save the word list! Error: " + e.Message);
                    }
                }
            updatePreview();

        }

        void loadWordList()
        {
            openWordListDialog.ShowDialog();
            if(openWordListDialog.FileName != null)
                if(openWordListDialog.FileName.Trim() != "")
                    if (System.IO.File.Exists(openWordListDialog.FileName))
                    {
                        try
                        {
                            wordListBox.Text = System.IO.File.ReadAllText(openWordListDialog.FileName);

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Couldn't load the word list! Error: " + e.Message);
                        }
                    }
            updatePreview();
        }

        void saveCollection()
        {
            saveCardsDialog.ShowDialog();

            pageCount = 1;
            try
            {
                pageCount = int.Parse(sheetCountBox.Text);
            }
            catch
            {
            }
            string filename = saveCardsDialog.FileName;
            if (filename.Contains("."))
                filename = filename.Substring(0, filename.LastIndexOf("."));


            for (int i = 0; i < pageCount; i++)
            {
                Bitmap b = generatePage(false);
                try
                {
                    b.Save(filename + " (Page " + (i + 1).ToString() + ").png");

                }
                catch
                {

                }
            }
        }

        int currentPage = 0;
        int pageCount = 1;
        void printCollection()
        {
            pageCount = 1;
            try
            {
                pageCount = int.Parse(sheetCountBox.Text);
            }
            catch
            {
            }
            currentPage = 0;
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
            
        }

        Random r = new Random();
        private void PrintPage(object o, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image z = generatePage(false);
            e.Graphics.DrawImage(z, new RectangleF(e.MarginBounds.Left,e.MarginBounds.Top,e.MarginBounds.Width, e.MarginBounds.Height));
            if (currentPage == pageCount - 1)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
            currentPage++;
            z.Dispose();
        }
        void reset()
        {

        }

        private void nationalblamenetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nationalblame.net");
        }
    }
}
