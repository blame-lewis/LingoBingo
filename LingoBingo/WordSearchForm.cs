using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LingoBingo
{
    public partial class WordSearchForm : Form
    {
        public WordSearchForm()
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

                SizeF instructionsSize = g.MeasureString(instructionsBox.Text, new System.Drawing.Font(FontFamily.GenericSansSerif, 12 + (3 * fontSizeBar.Value)), boxBuffer.Width);
                g.DrawString(instructionsBox.Text, new System.Drawing.Font(FontFamily.GenericSansSerif, 13), Brushes.Black, new RectangleF((boxBuffer.Width / 2) - (instructionsSize.Width / 2), titleSize.Height, boxBuffer.Width, instructionsSize.Height));


                int headerSize = (int)(titleSize.Height + instructionsSize.Height);

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
                    Random r;
                    if (sameSeed)
                        r = new Random(0);
                    else
                        r = this.r;

                    Dictionary<string, string> theGrid = new Dictionary<string, string>();
                    List<string> theWords = new List<string>(wordListBox.Text.Split('\n'));
                    while (theWords.Count > 0)
                    {
                        int attempt = 0;

                    tryAgain:
                        if (theWords.Count == 0)
                            break;

                        string s = theWords[r.Next(theWords.Count)];
                        if (attempt > 10000 || s.Length > gridWidth || s.Length > gridHeight)
                        {
                            return boxBuffer;
                        }

                        

                        if (s.Trim() == "")
                        {
                            theWords.Remove(s);
                            goto tryAgain;
                        }
                        bool vertical = r.Next(2) > 0 ? true : false;
                        int x;
                        int xmax;
                        if (vertical)
                            xmax = ((gridWidth - 1));
                        else
                            xmax = ((gridWidth - s.Length) - 1);
                        int y;
                        int ymax;
                        if(vertical)
                            ymax =(gridHeight - s.Length);
                        else
                            ymax =gridHeight;
                        if (xmax <= 0)
                            xmax = 1;
                        if (ymax <= 0)
                            ymax = 1;
                        x = r.Next(xmax);
                        y = r.Next(ymax);

                        int nx = x;
                        int ny = y;
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (vertical)
                                ny++;
                            else
                                nx++;
                            if (theGrid.ContainsKey(nx.ToString() + ", " + ny.ToString()))
                            {
                                if (theGrid[nx.ToString() + ", " + ny.ToString()] != s[i].ToString())
                                {
                                    attempt++;
                                    goto tryAgain;
                                }
                            }
                        }
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s[i].ToString().Trim() != "")
                            {
                                theGrid[x.ToString() + ", " + y.ToString()] = s[i].ToString();
                                if (vertical)
                                    y++;
                                else
                                    x++;
                            }
                        }
                        theWords.Remove(s);

                    }
                    for (int y = 0; y < gridHeight; y++)
                        for (int x = 1; x < gridWidth + 1; x++)
                        {
                            if (!theGrid.ContainsKey(x.ToString() + ", " + y.ToString()))
                            {
                                if(fillerBox.Text.Trim() == "")
                                    theGrid[x.ToString() + ", " + y.ToString()] = " ";
                                else
                                    theGrid[x.ToString() + ", " + y.ToString()] = fillerBox.Text[r.Next(fillerBox.Text.Length)].ToString();
                            }

                        }


                    int boxWidth = ((boxBuffer.Width - (marginSize * 2)) / gridWidth);
                    int boxHeight = ((boxBuffer.Height - (headerSize + (marginSize * 2))) / gridHeight);

                    Font f = new System.Drawing.Font(FontFamily.GenericSansSerif, 12 + (3 * fontSizeBar.Value));

                    for (int y = 0; y < gridHeight; y++)
                        for (int x = 1; x < gridWidth + 1; x++)
                        {

                                SizeF size = g.MeasureString(theGrid[x.ToString() + ", " + y.ToString()], f, new SizeF(boxWidth, boxHeight));

                                g.DrawString(theGrid[x.ToString() + ", " + y.ToString()], f, Brushes.Black, new RectangleF((((x * boxWidth) + marginSize) - (boxWidth / 2)) - (size.Width / 2), (y * boxHeight) + (marginSize + headerSize), boxWidth, boxHeight));
                            
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
            if (gridCount == 2)
                b = RotateImg(b, 90.0f, Color.Black);
            return b;
        }public static Bitmap RotateImg(Bitmap bmp, float angle, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            System.Drawing.Imaging.PixelFormat pf = default(System.Drawing.Imaging.PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));
            System.Drawing.Drawing2D.Matrix mtrx = new System.Drawing.Drawing2D.Matrix();
            //Using System.Drawing.Drawing2D.Matrix class 
            mtrx.Rotate(angle);
            RectangleF rct = path.GetBounds(mtrx);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
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

        private void fillerBox_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void instructionsBox_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }
    }
}
