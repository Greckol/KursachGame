using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class MatrixDef: Matrix
    {
        public MatrixDef(int rows, int colums, int cellSize): base(rows, colums, cellSize)
        {

        }
        protected override void ColorDrow(Graphics g, Player player, int row, int colum)
        {
            if (matrix[row][colum].Simvol == 'P')
            {
                g.FillRectangle(Brushes.Green, colum * CellSize, row * CellSize, CellSize, CellSize);
            }
            if (matrix[row][colum].Simvol == 'S')
            {
                g.FillRectangle(Brushes.Red, colum * CellSize, row * CellSize, CellSize, CellSize);
            }
        }

        public override void DrawAll(Graphics g, Form f, Player player, int row, int colum)
        {
            RectangleDrow(g, row, colum);
        }
    }
}
