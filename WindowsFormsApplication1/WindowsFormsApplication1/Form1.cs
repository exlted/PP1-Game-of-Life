using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        delegate int chosenLogic(Point pos);
        chosenLogic checkSurrounding;
        /// <summary>
        /// The universe is stored as [rows, columns]
        /// </summary>
        bool[,] universe;
        bool isHighlighted = true, isFinite = false;
        public int rows, columns;
        public Color deadColor = Color.White;
        public Color livingColor = Color.Black;
        public Color gridColor = Color.Black;
        public Color highlightedGridColor = Color.Black;
        //Variables for mouseMove event
        Point lastChanged = new Point();
        Point thisChanged = new Point();
        public Form1()
        {
            InitializeComponent();
            rows = columns = 10;
            universe = new bool[rows, columns];
            if (isFinite)
                checkSurrounding = getFWLiving;
            else checkSurrounding = getTWliving;
        }

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
                    lastChanged = thisChanged;
                    DBP.Invalidate();
                }
            }
            catch (Exception)
            {

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                if(i % 5 == 0 && isHighlighted)
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

        /// <summary>
        /// Gets the finite world count of living cells around a position.
        /// </summary>
        /// <param name="pos">The position of the currently selected cell.</param>
        /// <returns></returns>
        int getFWLiving(Point pos)
        {
            int livingCount = 0;
            for (int i = pos.X - 1; i <= pos.X + 1; i++)
            {
                if (i < 0 || i >= rows)
                    continue;
                for (int j = pos.Y - 1; j <= pos.Y + 1; j++)
                {
                    if (j < 0 || j >= columns ||(j == pos.Y && i == pos.X))
                        continue;
                    else if (universe[i, j])
                        livingCount++;
                }
            }
            return livingCount;
        }

        int getTWliving(Point pos)
        {
            int livingCount = 0;
            int iTemp, jTemp;
            for (int i = pos.X - 1; i <= pos.X + 1; i++)
            {
                iTemp = i;
                if (i < 0)
                    iTemp = rows - 1;
                else if(i >= rows)
                    iTemp = 0;
                for (int j = pos.Y - 1; j <= pos.Y + 1; j++)
                {
                    jTemp = j;
                    if (j < 0 )
                    {
                        jTemp = columns - 1;
                    }
                    else if(j >= columns)
                    {
                        jTemp = 0;
                    }
                    if (universe[iTemp, jTemp] && !(j == pos.Y && i == pos.X))
                        livingCount++;
                }
            }
            return livingCount;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm oForm = new OptionsForm(new golEventArgs(deadColor, livingColor, gridColor, highlightedGridColor, isHighlighted, isFinite, rows, columns));
            oForm.returningInformation = informationReturn;
            oForm.ShowDialog();
        }

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
            DBP.BackColor = deadColor;
            if (isFinite)
                checkSurrounding = getFWLiving;
            else checkSurrounding = getTWliving;
            universe = new bool[rows, columns];
            DBP.Invalidate();
        }

        /// <summary>
        /// Holds logic for updating the game through each generation.
        /// </summary>
        void doGenerationLogic()
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
            universe = tempUniverse;
            DBP.Invalidate();
        }
    }
}
