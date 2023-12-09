using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Matrix
    {
        public Matrix(int rows, int columns)
        {
            CellSize = 70;
            Rows = rows;
            Colums = columns;

            matrix = new List<List<Unit>>();
            freeMatrix = new List<List<Unit>>();
            for (int i = 0; i < Rows; i++)
            {
                List<Unit> row = new List<Unit>();
                for (int j = 0; j < Colums; j++)
                {
                    row.Add(new FreeCell());
                }
                matrix.Add(row);
                freeMatrix.Add(new List<Unit>(row));
            }
        }

        public void moveMatrix(Player player, List<Unit> units)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {

                    matrix[i][j] = freeMatrix[i][j];
                }
            }
            matrix[player.cordRows][player.cordColums] = player;
            foreach (var i in units)
            {
                matrix[i.CordRows][i.CordColums] = i;
            }
        }

        private void ColorDrow(Graphics g, Player player, int row, int colum)
        {
            bool isNeighbor = Math.Abs(player.cordRows - row) + Math.Abs(player.cordColums - colum) <= (player.RangeAtack);   // область возле игрока
            if (isNeighbor) g.FillRectangle(Brushes.DarkRed, colum * cellSize, row * cellSize, cellSize, cellSize);

            if (matrix[row][colum] == player)
            {
                g.FillRectangle(Brushes.Green, colum * cellSize, row * cellSize, cellSize, cellSize);
            }

            if (matrix[row][colum].Simvol == 'S')
            {
                g.FillRectangle(Brushes.Yellow, colum * cellSize, row * cellSize, cellSize, cellSize);
            }
        }

        private void TextDrow(Form f, Graphics g, int row, int colum)
        {
            string value = matrix[row][colum].Simvol.ToString();
            PointF textPosition = new PointF(colum * cellSize + (cellSize / 4), row * cellSize + (cellSize / 4));
            g.DrawString(value, f.Font, Brushes.Black, textPosition);
        }

        private void RectangleDrow(Graphics g, int row, int colum)
        {
            g.DrawRectangle(Pens.Black, colum * cellSize, row * cellSize, cellSize, cellSize);
        }

        public void DrawAll(Graphics g, Form f, Player player, int row, int colum)
        {
            ColorDrow(g, player, row, colum);
            RectangleDrow(g, row, colum);
            TextDrow(f, g, row, colum);
        }

        public Unit this[int row, int colum]
        {
            get
            {
                if (row < 0 || row >= Rows || colum < 0 || colum >= Colums)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
                return matrix[row][colum];
            }
            set
            {
                if (row < 0 || row >= Rows || colum < 0 || colum >= Colums)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
                matrix[row][colum] = value;
            }
        }

        public List<List<Unit>> matrix;
        List<List<Unit>> freeMatrix;
        int cellSize;
        int matrixRows;
        int matrixColumns;

        public int CellSize
        {
            get { return cellSize; }
            set { cellSize = value; }
        }
        public int Rows
        {
            get { return matrixRows; }
            set {  matrixRows = value; }
        }
        public int Colums
        {
            get { return matrixColumns; }
            set { matrixColumns = value; }
        }
    }
}
