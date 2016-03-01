﻿using System;
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
        /// <summary>
        /// The universe is stored as [rows, columns]
        /// </summary>
        bool[,] universe;
        /// <summary>
        /// The temporary universe is stored as [rows, columns]
        /// </summary>
        bool[,] tempUniverse;
        int rows, columns;
        //Variables for mouseMove event
        Point lastChanged = new Point();
        Point thisChanged = new Point();
        public Form1()
        {
            InitializeComponent();
            rows = columns = 50;
            universe = new bool[rows, columns];
            tempUniverse = new bool[rows, columns];
            universe[1, 1] = true;
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
            //TODO: Add restart functionality
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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
            catch(Exception)
            {

            }
        }

        private void customControl11_Paint(object sender, PaintEventArgs e)
        {
            Pen newPen = new Pen(Color.Black);
            Pen bigPen = new Pen(Color.Black, 2);
            float collumnWidth, rowHeight;
            collumnWidth = (float)DBP.Width / columns;
            rowHeight = (float)DBP.Height / rows;
            float seperatorPos = 0;
            for (int i = 0; i < columns; i++)
            {
                if(i % 5 == 0)
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
                if (i % 5 == 0)
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
                        e.Graphics.FillRectangle(Brushes.Black, temp);
                    }
                }
            }
        }
    }
}
