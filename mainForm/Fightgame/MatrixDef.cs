using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class MatrixDef: MatrixBase
    {
        public MatrixDef(int rows, int colums, int cellSize): base(rows, colums, cellSize)
        {
            matrix = new List<List<char>>();
            freeMatrix = new List<List<char>>();
            enemys = new List<Enemy>();
            for (int i = 0; i < Rows; i++)
            {
                List<char> row = new List<char>();
                for (int j = 0; j < Colums; j++)
                {
                    row.Add(' ');
                }
                matrix.Add(row);
                freeMatrix.Add(new List<char>(row));
            }
            CordRowPlayer = rows / 2;
            CordColumnPlayer = colums / 2;
        }

        public void moveMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {

                    matrix[i][j] = freeMatrix[i][j];
                }
            }
            matrix[CordRowPlayer][cordColumnPlayer] = 'P';
            foreach (var i in enemys)
            {
                matrix[i.cordRow][i.CordColumn] = 'E';
            }
        }

        public void addEnemy(int row, int colum)
        {
            enemys.Add(new Enemy(row, colum));
        }

        protected void ColorDrow(Graphics g, int row, int colum)
        {
            if (matrix[row][colum] == 'P')
            {
                g.FillRectangle(Brushes.Green, colum * CellSize, row * CellSize, CellSize, CellSize);
            }
            if (matrix[row][colum] == 'E')
            {
                g.FillRectangle(Brushes.Red, colum * CellSize, row * CellSize, CellSize, CellSize);
            }
        }

        public void DrawAll(Graphics g, Form f, int row, int colum)
        {
            RectangleDrow(g, row, colum);
            ColorDrow(g, row, colum);
        }


        int cordRowPlayer;
        int cordColumnPlayer;

        public List<List<char>> matrix;
        List<List<char>> freeMatrix;
        List<Enemy> enemys;
        struct Enemy
        {
            public int cordRow;
            public int CordColumn;

            public Enemy(int row, int colum)
            {
                cordRow = row;
                CordColumn = colum;
            }
        }

        public int CordRowPlayer
        {
            get { return cordRowPlayer; }
            set { cordRowPlayer = value; }
        }
        public int CordColumnPlayer
        {
            get { return cordColumnPlayer; }
            set { cordColumnPlayer = value; }
        }
    }

}
