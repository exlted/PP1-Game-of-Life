using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region fields + Constructor

        private static Random r = new Random();

        private delegate int chosenLogic(Point pos);

        private chosenLogic checkSurrounding;

        /// <summary>
        /// The universe is stored as [rows, columns]
        /// </summary>
        private bool[,] universe;

        private bool isHighlighted = Properties.Settings.Default.isHighlighted, isFinite = Properties.Settings.Default.isFinite;
        private int rows = Properties.Settings.Default.Rows, columns = Properties.Settings.Default.Columns, msPerTick = Properties.Settings.Default.msPerTick;
        private Color deadColor = Properties.Settings.Default.DeadColor;
        private Color livingColor = Properties.Settings.Default.LivingColor;
        private Color gridColor = Properties.Settings.Default.GridColor;
        private Color highlightedGridColor = Properties.Settings.Default.HGridColor;

        //Variables for mouseMove event
        private Point lastChanged = new Point();

        private Point thisChanged = new Point();
        private int generation, seed = r.Next(), alive;

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

        private void Form1_Resize(object sender, EventArgs e)
        {
            DBP.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            universe = new bool[rows, columns];
            gameTick.Enabled = false;
            DBP.Invalidate();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTick.Enabled = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTick.Enabled = false;
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            doGenerationLogic();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doGenerationLogic();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm oForm = new OptionsForm(new golEventArgs(deadColor, livingColor, gridColor, highlightedGridColor, isHighlighted, isFinite, rows, columns, msPerTick));
            oForm.returningInformation = informationReturn;
            oForm.ShowDialog();
        }

        #endregion Single Line Functions

        #region DBP functions

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
            LivingCount.Text = "Alive: " + alive;
        }

        private void customControl11_Paint(object sender, PaintEventArgs e)
        {
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
            rows = e.rowCount;
            columns = e.columnCount;
            msPerTick = gameTick.Interval = e.msPerTick;
            DBP.BackColor = deadColor;
            if (isFinite)
                checkSurrounding = getFWLiving;
            else checkSurrounding = getTWliving;
            universe = new bool[rows, columns];
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
            GenerationLabel.Text = "Generation: " + ++generation;
            LivingCount.Text = "Alive: " + alive;
            intervalLabel.Text = "Interval: " + msPerTick;
            SeedLabel.Text = "Seed " + seed;
            universe = tempUniverse;
            DBP.Invalidate();
        }

        #endregion GoL Logical Functions
    }
}