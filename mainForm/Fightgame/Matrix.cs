using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Matrix: MatrixBase
    {
        public Matrix(int rows, int columns, Panel panel): base(rows, columns, panel)
        {
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

        public virtual void moveMatrix(Player player, List<Unit> units)
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

        protected virtual void ColorDrow(Graphics g, Player player, int row, int colum)
        {
            bool isNeighbor = Math.Abs(player.cordRows - row) + Math.Abs(player.cordColums - colum) <= (player.RangeAtack);   // область возле игрока
            if (isNeighbor) g.FillRectangle(Brushes.DarkRed, colum * CellSizeRow, row * CellSizeColum, CellSizeRow, CellSizeColum);

            if (matrix[row][colum] == player)
            {
                g.FillRectangle(Brushes.Green, colum * CellSizeRow, row * CellSizeColum, CellSizeRow, CellSizeColum);
            }

            if (matrix[row][colum].Name == "Slime")
            {
                g.FillRectangle(Brushes.Yellow, colum * CellSizeRow, row * CellSizeColum, CellSizeRow, CellSizeColum);
            }
        }

        private void TextDrow(Form f, Graphics g, int row, int colum)
        {
            string value = matrix[row][colum].Name[0].ToString();
            PointF textPosition = new PointF(colum * CellSizeRow + (CellSizeRow / 4), row * CellSizeColum + (CellSizeColum / 4));
            g.DrawString(value, f.Font, Brushes.Black, textPosition);
        }

        

        public virtual void DrawAll(Graphics g, Form f, Player player, int row, int colum)
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

        public  List<List<Unit>> matrix;
        protected List<List<Unit>> freeMatrix;
        
    }
}
