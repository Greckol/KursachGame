using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public abstract class Enemy : Unit
    {

        int dangerProcent;
        public int DangerProcent
        {
            get { return dangerProcent; }
            set { dangerProcent = value; }
        }


        protected int atackCount = 5;
        protected int cellAtackCount = 6;
        protected int matrixDefRows = 6;
        protected int matrixDefColumns = 6;
        public int AtackCount
        {
            get { return atackCount; }
        }
        public int CellAtackCount
        {
            get { return cellAtackCount; }
        }

        public int MatrixDefRows
        {
            get { return matrixDefRows; }
        }

        public int MatrixDefColumns
        {
            get { return matrixDefColumns; }
        }

        public bool tryToAtackPlayer()
        {
            Random random = new Random();
            int value = random.Next(1, 101);
            if (DangerProcent > value)
            {
                return true;
            }
            return false;
        }

        public abstract void AtackPattern(MatrixDef matrix);
        public bool checkRangeToPlayer()
        {
            int value = Math.Abs(Player.GetInstance().CordRows - CordRows) + Math.Abs(Player.GetInstance().CordColums - CordColums);
            if (value <= RangeAtack) return true;
            return false;
        }

    }
    
}
