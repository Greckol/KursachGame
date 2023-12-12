using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public class MatrixBase
    {
        public MatrixBase(int matrixRows, int matrixColumns, int cellsize )
        {
            Rows = matrixRows;
            Colums = matrixColumns;
            CellSize = cellsize;
        }

        protected void RectangleDrow(Graphics g, int row, int colum)
        {
            g.DrawRectangle(Pens.Black, colum * CellSize, row * CellSize, CellSize, CellSize);
        }

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
            set { matrixRows = value; }
        }
        public int Colums
        {
            get { return matrixColumns; }
            set { matrixColumns = value; }
        }
    }
}
