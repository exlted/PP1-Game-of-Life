using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OptionsForm : Form
    {
        public EventHandler<golEventArgs> returningInformation;
        public golEventArgs previousData;

        public OptionsForm(golEventArgs input)
        {
            InitializeComponent();
            previousData = input;
            panelBackgroundColor.BackColor = previousData.deadColor;
            livingCellColor.BackColor = previousData.livingColor;
            normalGridColor.BackColor = previousData.gridColor;
            highlightedGridColor.BackColor = previousData.highlightedGridColor;
            isGridHighlighted.Checked = previousData.isHighlightingGrid;
            finite.Checked = previousData.isFiniteWorld;
            rowCount.Value = previousData.rowCount;
            colCount.Value = previousData.columnCount;
            timerTicks.Value = previousData.msPerTick;
            if (previousData.isFiniteWorld)
                finite.Checked = true;
            else toriodal.Checked = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            returningInformation(this, new golEventArgs(panelBackgroundColor.BackColor, livingCellColor.BackColor, normalGridColor.BackColor, highlightedGridColor.BackColor, isGridHighlighted.Checked, finite.Checked, (int)rowCount.Value, (int)colCount.Value, (int)timerTicks.Value));
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            panelBackgroundColor.BackColor = previousData.deadColor;
            livingCellColor.BackColor = previousData.livingColor;
            normalGridColor.BackColor = previousData.gridColor;
            highlightedGridColor.BackColor = previousData.highlightedGridColor;
            isGridHighlighted.Checked = previousData.isHighlightingGrid;
            finite.Checked = previousData.isFiniteWorld;
            rowCount.Value = previousData.rowCount;
            colCount.Value = previousData.columnCount;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = (sender as Button).BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = colorDialog1.Color;
            }
        }
    }

    public class golEventArgs : EventArgs
    {
        public Color deadColor { get; private set; }
        public Color livingColor { get; private set; }
        public Color gridColor { get; private set; }
        public Color highlightedGridColor { get; private set; }
        public bool isHighlightingGrid { get; private set; }
        public bool isFiniteWorld { get; private set; }
        public int rowCount { get; private set; }
        public int columnCount { get; private set; }
        public int msPerTick { get; private set; }

        public golEventArgs(Color dead, Color living, Color grid, Color highlighted, bool isHilighted, bool isFinite, int rows, int Columns, int ms)
        {
            deadColor = dead;
            livingColor = living;
            gridColor = grid;
            highlightedGridColor = highlighted;
            isHighlightingGrid = isHilighted;
            isFiniteWorld = isFinite;
            rowCount = rows;
            columnCount = Columns;
            msPerTick = ms;
        }
    }
}