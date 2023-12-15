using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public abstract class Enemy : Unit
    {
        public Enemy(int cordColums = 0, int cordRows = 0, int damage = 1, int health = 5, int healthMax = 5,
            int armor = 0, string name = "undef", int rangeAtack = 1,
            int dangerProcent = 10, int atackCount = 5, int cellAtackCount = 5, int matrixDefRows = 6, int matrixDefColumns = 6): 
            base(cordColums, cordRows, damage, health, healthMax, armor, name, rangeAtack)
        {
            this.dangerProcent = dangerProcent;
            this.atackCount = atackCount;
            this.cellAtackCount = cellAtackCount;
            this.matrixDefRows = matrixDefRows;
            this.matrixDefColumns = matrixDefColumns;
            
        }
        protected int dangerProcent;
        protected int atackCount;
        protected int cellAtackCount;
        protected int matrixDefRows;
        protected int matrixDefColumns;
        
        public abstract int getDanegerProcent();
        public abstract int getAtackCount();
        public abstract int getCellAtackCount();
        public abstract int getMatrixDefRows();
        public abstract int getMatrixDefColumns();
        public override void Die()
        {
            Player.GetInstance().Exp += 5;
        }
        public abstract Enemy GetBaseComponent();

        public bool tryToAtackPlayer()
        {
            Random random = new Random();
            int value = random.Next(1, 101);
            if (getDanegerProcent() > value)
            {
                return true;
            }
            return false;
        }

        public void AtackPattern(MatrixDef matrix)
        {
            Random rnd = new Random();
            int cordRowRand = new int();
            int cordColumnRand = new int();
            for (int i = 0; i < getAtackCount(); i++)
            {
                do
                {
                    cordRowRand = rnd.Next(0, matrix.Rows);
                    cordColumnRand = rnd.Next(0, matrix.Colums);
                } while (matrix.matrix[cordRowRand][cordColumnRand] == 'E');
                matrix.addEnemy(cordRowRand, cordColumnRand);
            }
        }
        public bool checkRangeToPlayer()
        {
            int value = Math.Abs(Player.GetInstance().CordRows - CordRows) + Math.Abs(Player.GetInstance().CordColums - CordColums);
            if (value <= getRangeAtack()) return true;
            return false;
        }
    }
}
