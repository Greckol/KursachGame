using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Slime : Enemy
    {
        public Slime(): base()
        {
            Name = "Slime";
            atackCount = 10;
            cellAtackCount = 15;
        }

        public override void AtackPattern(MatrixDef matrix)
        {
            Random rnd = new Random();
            int cordRowRand = new int();
            int cordColumnRand = new int();
            for (int i = 0; i < cellAtackCount; i++)
            {
                do
                {
                    cordRowRand = rnd.Next(0, matrix.Rows);
                    cordColumnRand = rnd.Next(0, matrix.Colums);
                } while (matrix.matrix[cordRowRand][cordColumnRand] == 'E');
                matrix.addEnemy(cordRowRand, cordColumnRand);
            }
        }

        
    }
}
