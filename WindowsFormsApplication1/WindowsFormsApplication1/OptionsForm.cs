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
    public partial class OptionsForm : Form
    {

        public EventHandler<golEventArgs> returningInformation;
        public golEventArgs previousData;

        public OptionsForm(Form1 form)
        {
            InitializeComponent();
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            returningInformation(this, new golEventArgs(panelBackgroundColor.BackColor, livingCellColor.BackColor, normalGridColor.BackColor, highlightedGridColor.BackColor, isGridHighlighted.Checked, finite.Checked, (int)rowCount.Value, (int)colCount.Value));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class golEventArgs : EventArgs
    {
        public Color deadColor { get; private set; }
        public Color livingColor { get; private set;  }
        public Color gridColor { get; private set; }
        public Color highlightedGridColor { get; private set; }
        public bool isHighlightingGrid { get; private set; }
        public bool isFiniteWorld { get; private set; }
        public int rowCount { get; private set; }
        public int columnCount { get; private set; }

        public golEventArgs(Color dead, Color living, Color grid, Color highlighted, bool isHilighted, bool isFinite, int rows, int Columns)
        {
            deadColor = dead;
            livingColor = living;
            gridColor = grid;
            highlightedGridColor = highlighted;
            isHighlightingGrid = isHilighted;
            isFiniteWorld = isFinite;
            rowCount = rows;
            columnCount = Columns;
        }
    }

}
