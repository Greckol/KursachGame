using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public abstract class Enemy : Unit
    {
        public Enemy(int cordColums = 0, int cordRows = 0, int damage = 1, int critChance = 5, int health = 5, int healthMax = 5, int healthRegeneration = 1,
            int armor = 0, int expReward = 5, int goldReward = 5, string name = "undef", int rangeAtack = 1,
            int dangerProcent = 10, int atackCount = 5, int cellAtackCount = 5, int speedAtack = 1000, int matrixDefRows = 6, int matrixDefColumns = 6) :

            base(cordColums, cordRows, damage, critChance ,health, healthMax, armor, name, rangeAtack, healthRegeneration)
        {
            this.expReward = expReward;
            this.goldReward = goldReward;
            this.dangerProcent = dangerProcent;
            this.atackCount = atackCount;
            this.cellAtackCount = cellAtackCount;
            this.speedAtack = speedAtack;
            this.matrixDefRows = matrixDefRows;
            this.matrixDefColumns = matrixDefColumns;
            
        }
        protected int dangerProcent;
        protected int atackCount;
        protected int cellAtackCount;
        protected int speedAtack;
        protected int matrixDefRows;
        protected int matrixDefColumns;
        protected int expReward;
        protected int goldReward;

        public abstract int getExpReward();
        public abstract int getGoldReward();
        public abstract int getDanegerProcent();
        public abstract int getAtackCount();
        public abstract int getCellAtackCount();
        public abstract int getSpeed();
        public abstract int getMatrixDefRows();
        public abstract int getMatrixDefColumns();
        public abstract Enemy GetBaseComponent();

        public override void Die()
        {
            Player.GetInstance().ExpUp(getExpReward());
            Player.GetInstance().GoldUp(getGoldReward());
        }

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
