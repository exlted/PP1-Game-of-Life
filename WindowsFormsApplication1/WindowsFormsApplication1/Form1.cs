using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region fields + Constructor

        private static Random r = new Random();

        private delegate int chosenLogic(Point pos);
        /// <summary>
        /// Holds the command to check the surrounding cells for GoL logic
        /// </summary>
        private chosenLogic checkSurrounding;

        /// <summary>
        /// The universe is stored as [rows, columns]
        /// </summary>
        private bool[,] universe;
        /// <summary>
        /// Exists to allow minor threading
        /// </summary>
        private bool midUpdate = false;

        private bool isHighlighted = Properties.Settings.Default.isHighlighted, isFinite = Properties.Settings.Default.isFinite;
        private int rows = Properties.Settings.Default.Rows, columns = Properties.Settings.Default.Columns, msPerTick = Properties.Settings.Default.msPerTick;
        private Color deadColor = Properties.Settings.Default.DeadColor;
        private Color livingColor = Properties.Settings.Default.LivingColor;
        private Color gridColor = Properties.Settings.Default.GridColor;
        private Color highlightedGridColor = Properties.Settings.Default.HGridColor;
        private int generation, seed = r.Next(), alive;

        /// <summary>
        /// The previously changed point so Mouse_Move doesn't cause flicker
        /// </summary>
        private Point lastChanged = new Point();
        /// <summary>
        /// The currently changed point to check against lastChanged
        /// </summary>
        private Point thisChanged = new Point();

        public Form1()
        {
            InitializeComponent();
            universe = new bool[rows, columns];
            DBP.BackColor = deadColor;
            gameTick.Interval = msPerTick;
            if (isFinite)
                checkSurrounding = getFWLiving;
            else checkSurrounding = getTWliving;
        }

        #endregion fields + Constructor

        #region Single Line Functions
        /// <summary>
        /// Handles the Resize event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            DBP.Invalidate();
        }
        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Handles the Click event of the newToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universe = new bool[rows, columns];
            gameTick.Enabled = false;
            DBP.Invalidate();
        }
        /// <summary>
        /// Handles the Click event of the runToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTick.Enabled = true;
        }
        /// <summary>
        /// Handles the Click event of the pauseToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTick.Enabled = false;
        }
        /// <summary>
        /// Handles the Tick event of the gameTick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gameTick_Tick(object sender, EventArgs e)
        {
            doGenerationLogic();
        }
        /// <summary>
        /// Handles the Click event of the nextToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doGenerationLogic();
        }
        /// <summary>
        /// Handles the Click event of the optionsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm oForm = new OptionsForm(new golEventArgs(deadColor, livingColor, gridColor, highlightedGridColor, isHighlighted, isFinite, rows, columns, msPerTick));
            oForm.returningInformation = informationReturn;
            oForm.ShowDialog();
        }
        /// <summary>
        /// Handles the Click event of the randomizeToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seed = r.Next();
            r = new Random(seed);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (r.Next(3) == 0)
                        universe[i, j] = true;
                    else universe[i, j] = false;
                }
            }
            alive = getLiving();
            DBP.Invalidate();
        }
        /// <summary>
        /// Handles the Click event of the openToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        /// <summary>
        /// Handles the Click event of the saveToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        #endregion Single Line Functions

        #region DBP functions
        /// <summary>
        /// Handles the MouseMove event of the DBP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void DBP_MouseMove(object sender, MouseEventArgs e)
        {
            float collumnWidth, rowHeight;
            collumnWidth = (float)DBP.Width / columns;
            rowHeight = (float)DBP.Height / rows;
            thisChanged.Y = (int)(e.Y / rowHeight);
            thisChanged.X = (int)(e.X / collumnWidth);
            try
            {
                if (e.Button == MouseButtons.Left && !thisChanged.Equals(lastChanged))
                {
                    universe[thisChanged.Y, thisChanged.X] = !universe[thisChanged.Y, thisChanged.X];
                    if (universe[thisChanged.Y, thisChanged.X])
                        alive++;
                    else alive--;
                    lastChanged = thisChanged;
                    DBP.Invalidate();
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Handles the MouseDown event of the DBP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void DBP_MouseDown(object sender, MouseEventArgs e)
        {
            float collumnWidth, rowHeight;
            collumnWidth = (float)DBP.Width / columns;
            rowHeight = (float)DBP.Height / rows;
            thisChanged.Y = (int)(e.Y / rowHeight);
            thisChanged.X = (int)(e.X / collumnWidth);
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    universe[thisChanged.Y, thisChanged.X] = !universe[thisChanged.Y, thisChanged.X];
                    if (universe[thisChanged.Y, thisChanged.X])
                        alive++;
                    else alive--;
                    lastChanged = thisChanged;
                    DBP.Invalidate();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Handles the Paint event of the customControl11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void customControl11_Paint(object sender, PaintEventArgs e)
        {
            GenerationLabel.Text = "Generation: " + ++generation;
            LivingCount.Text = "Alive: " + alive;
            intervalLabel.Text = "Interval: " + msPerTick;
            SeedLabel.Text = "Seed " + seed;
            Pen newPen = new Pen(gridColor);
            Pen bigPen = new Pen(highlightedGridColor, 2);
            float collumnWidth, rowHeight;
            collumnWidth = (float)DBP.Width / columns;
            rowHeight = (float)DBP.Height / rows;
            float seperatorPos = 0;
            for (int i = 0; i < columns; i++)
            {
                if (i % 5 == 0 && isHighlighted)
                {
                    e.Graphics.DrawLine(bigPen, seperatorPos, 0f, seperatorPos, DBP.Height);
                }
                else
                    e.Graphics.DrawLine(newPen, seperatorPos, 0f, seperatorPos, DBP.Height);
                seperatorPos += collumnWidth;
            }
            e.Graphics.DrawLine(newPen, seperatorPos, 0f, seperatorPos, DBP.Height);
            seperatorPos = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i % 5 == 0 && isHighlighted)
                {
                    e.Graphics.DrawLine(bigPen, 0f, seperatorPos, DBP.Width, seperatorPos);
                }
                else
                    e.Graphics.DrawLine(newPen, 0f, seperatorPos, DBP.Width, seperatorPos);
                seperatorPos += rowHeight;
            }
            e.Graphics.DrawLine(newPen, 0f, seperatorPos, DBP.Width, seperatorPos);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (universe[i, j])
                    {
                        Rectangle temp = new Rectangle((int)((j * collumnWidth + 1)), (int)((i * rowHeight) + 1), (int)(collumnWidth + 1), (int)(rowHeight + 1));
                        e.Graphics.FillRectangle(new SolidBrush(livingColor), temp);
                    }
                }
            }
        }

        #endregion DBP functions

        #region GoL Logical Functions

        /// <summary>
        /// Gets the finite world count of living cells around a position.
        /// </summary>
        /// <param name="pos">The position of the currently selected cell.</param>
        /// <returns></returns>
        private int getFWLiving(Point pos)
        {
            int livingCount = 0;
            for (int i = pos.X - 1; i <= pos.X + 1; i++)
            {
                if (i < 0 || i >= rows)
                    continue;
                for (int j = pos.Y - 1; j <= pos.Y + 1; j++)
                {
                    if (j < 0 || j >= columns || (j == pos.Y && i == pos.X))
                        continue;
                    else if (universe[i, j])
                        livingCount++;
                }
            }
            return livingCount;
        }

        /// <summary>
        /// Gets the toroidal world count of living cells around a position.
        /// </summary>
        /// <param name="pos">The position that is checked around.</param>
        /// <returns></returns>
        private int getTWliving(Point pos)
        {
            int livingCount = 0;
            int iTemp, jTemp;
            for (int i = pos.X - 1; i <= pos.X + 1; i++)
            {
                iTemp = i;
                if (i < 0)
                    iTemp = rows - 1;
                else if (i >= rows)
                    iTemp = 0;
                for (int j = pos.Y - 1; j <= pos.Y + 1; j++)
                {
                    jTemp = j;
                    if (j < 0)
                    {
                        jTemp = columns - 1;
                    }
                    else if (j >= columns)
                    {
                        jTemp = 0;
                    }
                    if (universe[iTemp, jTemp] && !(j == pos.Y && i == pos.X))
                        livingCount++;
                }
            }
            return livingCount;
        }

        /// <summary>
        /// Gets the amount of living cells.
        /// </summary>
        /// <returns></returns>
        private int getLiving()
        {
            int livingCount = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (universe[i, j])
                        livingCount++;
                }
            }
            return livingCount;
        }

        /// <summary>
        /// Handles the return of information.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="golEventArgs"/> instance containing the event data.</param>
        public void informationReturn(object sender, golEventArgs e)
        {
            deadColor = e.deadColor;
            livingColor = e.livingColor;
            gridColor = e.gridColor;
            highlightedGridColor = e.highlightedGridColor;
            isHighlighted = e.isHighlightingGrid;
            isFinite = e.isFiniteWorld;
            msPerTick = gameTick.Interval = e.msPerTick;
            DBP.BackColor = deadColor;
            if (isFinite)
                checkSurrounding = getFWLiving;
            else checkSurrounding = getTWliving;
            if(rows!=e.rowCount && columns !=e.columnCount)
            {
                resizeUniverse(e.columnCount, e.rowCount);
            }
            Properties.Settings.Default.DeadColor = deadColor;
            Properties.Settings.Default.LivingColor = livingColor;
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.HGridColor = highlightedGridColor;
            Properties.Settings.Default.Rows = rows;
            Properties.Settings.Default.Columns = columns;
            Properties.Settings.Default.isHighlighted = isHighlighted;
            Properties.Settings.Default.isFinite = isFinite;
            Properties.Settings.Default.msPerTick = msPerTick;
            Properties.Settings.Default.Save();
            DBP.Invalidate();
        }

        /// <summary>
        /// Holds logic for updating the game through each generation.
        /// </summary>
        private void doGenerationLogic()
        {
            midUpdate = true;
            /// <summary>
            /// The temporary universe is stored as [rows, columns]
            /// </summary>
            bool[,] tempUniverse;
            tempUniverse = new bool[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    switch (checkSurrounding(new Point(i, j)))
                    {
                        case 2:
                            if (universe[i, j])
                                tempUniverse[i, j] = true;
                            else tempUniverse[i, j] = false;
                            break;

                        case 3:
                            tempUniverse[i, j] = true;
                            break;

                        default:
                            tempUniverse[i, j] = false;
                            break;
                    }
                }
            }
            alive = getLiving();
            universe = tempUniverse;
            DBP.Invalidate();
            midUpdate = false;
        }

        /// <summary>
        /// Resizes the universe can be done without pausing the simulation.
        /// </summary>
        /// <param name="width">The width of the new universe.</param>
        /// <param name="height">The height of the new universe.</param>
        private bool resizeUniverse(int width, int height)
        {
            bool wasEnabled = false;
            if (gameTick.Enabled)
            {
                gameTick.Enabled = false;
                wasEnabled = true;
            }
            while (midUpdate) //Waits until current update thread finishes
            {
                System.Threading.Thread.Sleep(5);
            }
            Point[] minSize = getUniverseMinSize();
            int minWidth = minSize[1].X - minSize[0].X, minHeight = minSize[1].Y - minSize[0].Y;
            if(minWidth > width || minHeight > height)
            {
                if (MessageBox.Show("New size too small, universe will reset", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    rows = height;
                    columns = width;
                    universe = new bool[rows, columns];
                    return true;
                }
                else return false;
            }
            bool[,] temp = new bool[minHeight, minWidth];
            int rowPos = 0, colPos = 0;
            for (int i = minSize[0].Y; i < minSize[1].Y; i++)
            {
                for (int j = minSize[0].X; j < minSize[1].X; j++)
                {
                    temp[rowPos, colPos] = universe[i, j];
                    colPos++;
                }
                colPos = 0;
                rowPos++;
            }
            rows = height;
            columns = width;
            universe = importToUniverse(width, height, minHeight, minWidth, temp);
            if(wasEnabled)
                gameTick.Enabled = true;
            return true;
        }

        /// <summary>
        /// Resizes the universe, taking in an imported universe from Load().
        /// </summary>
        /// <param name="minWidth">The minimum width.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="importedUniverse">The imported universe.</param>
        /// <returns></returns>
        private bool resizeUniverse(int minWidth, int minHeight, bool[,] importedUniverse)
        {
            gameTick.Enabled = false;

            if (minWidth > columns || minHeight > rows)
            {
                if (MessageBox.Show("Universe too small, universe will resize", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    rows = minHeight;
                    columns = minWidth;
                    universe = importedUniverse;
                    return true;
                }
                else return false;
            }
            universe = importToUniverse(columns, rows, minHeight, minWidth, importedUniverse);
            return true;
        }

        /// <summary>
        /// Imports to universe.
        /// </summary>
        /// <param name="newWidth">The new width.</param>
        /// <param name="newHeight">The new height.</param>
        /// <param name="minHeight">The minimum height.</param>
        /// <param name="minWidth">The minimum width.</param>
        /// <param name="import">The imported universe.</param>
        /// <returns></returns>
        private bool[,] importToUniverse(float newWidth, float newHeight, float minHeight, float minWidth, bool[,] import)
        {
            int rowPos = 0, colPos = 0;
            bool[,] tempUniverse = new bool[(int)newHeight, (int)newWidth];
            if (minHeight != 1 && minWidth != 1)
            {
                for (float i = (newHeight / 2) - (minHeight / 2); i < (newHeight / 2) + (minHeight / 2); i++)
                {
                    for (float j = (newWidth / 2) - (minWidth / 2); j < (newWidth / 2) + (minWidth / 2); j++)
                    {
                        tempUniverse[(int)i, (int)j] = import[rowPos, colPos];
                        colPos++;
                        DBP.Invalidate();
                    }
                    colPos = 0;
                    rowPos++;
                }
            }
            else if(minHeight != 1 && minWidth == 1)
            {
                float j = (newWidth / 2) - (minWidth / 2);
                for (float i = (newHeight / 2) - (minHeight / 2); i < (newHeight / 2) + (minHeight / 2); i++)
                {
                    tempUniverse[(int)i, (int)j] = import[rowPos, colPos];
                    rowPos++;
                }
            }
            else if(minHeight == 1 && minWidth != 1)
            {
                float i = (newHeight / 2) - (minHeight / 2);
                for (float j = (newWidth / 2) - (minWidth / 2); j < (newWidth / 2) + (minWidth / 2); j++)
                {
                    tempUniverse[(int)i, (int)j] = import[rowPos, colPos];
                    colPos++;
                }
            }
            else
            {
                float j = (newWidth / 2) - (minWidth / 2);
                float i = (newHeight / 2) - (minHeight / 2);
                tempUniverse[(int)i, (int)j] = import[rowPos, colPos];
            }
            return tempUniverse;
        }

        /// <summary>
        /// Gets the minimum size of the universe.
        /// </summary>
        /// <returns></returns>
        private Point[] getUniverseMinSize()
        {
            Point[] temp = new Point[2];
            temp[0].X = 0; temp[0].Y = 0; temp[1].X = 0; temp[1].Y = 0;
            bool found = false;

            for (int i = 0; i < columns && !found; i++)
            {
                for (int j = 0; j < rows && !found; j++)
                {
                    if(universe[j, i])
                    {
                        found = true;
                        temp[0].X = i;
                    }
                }
            }

            found = false;
            for (int i = 0; i < rows && !found; i++)
            {
                for (int j = 0; j < columns && !found; j++)
                {
                    if (universe[i, j])
                    {
                        found = true;
                        temp[0].Y = i;
                    }
                }
            }

            found = false;
            for (int i = columns - 1; i >= 0 && !found; i--)
            {
                for (int j = rows - 1; j >= 0 && !found; j--)
                {
                    if (universe[j, i])
                    {
                        found = true;
                        temp[1].X = i + 1;
                    }
                }
            }

            found = false;
            for (int i = rows - 1; i >= 0 && !found; i--)
            {
                for (int j = columns - 1; j >= 0 && !found; j--)
                {
                    if (universe[i, j])
                    {
                        found = true;
                        temp[1].Y = i + 1;
                    }
                }
            }


            return temp;
        }

        #endregion GoL Logical Functions

        #region Memory Functions
        /// <summary>
        /// Saves the file.
        /// </summary>
        void SaveFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                writer.WriteLine("!This is my comment.");

                Point[] minSize = getUniverseMinSize();
                for (int y = minSize[0].Y; y < minSize[1].Y; y++)
                    {
                    StringBuilder newLine = new StringBuilder();
                    for (int x = minSize[0].X; x < minSize[1].X; x++)
                    {
                        if (universe[y, x])
                            newLine.Append('O');
                        else newLine.Append('.');
                    }
                    writer.WriteLine(newLine.ToString());
                }

                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }

        /// <summary>
        /// Loads the file.
        /// </summary>
        void LoadFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                int maxWidth = 0;
                int maxHeight = 0;

                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row[0] == '!')
                        continue;

                    maxHeight++;
                    if (!(maxWidth >= row.Length))
                        maxWidth = row.Length;
                }

                bool[,] tempUniverse = new bool[maxHeight, maxWidth];

                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                int rowPos = 0;
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row[0] == '!')
                        continue;

                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        if (row[xPos] == 'O')
                            tempUniverse[rowPos, xPos] = true;
                        else if (row[xPos] == '.')
                            tempUniverse[rowPos, xPos] = false;
                    }
                    rowPos++;
                }
                resizeUniverse(maxWidth, maxHeight, tempUniverse);
                DBP.Invalidate();
                reader.Close();
            }
        }
        #endregion
    }
}