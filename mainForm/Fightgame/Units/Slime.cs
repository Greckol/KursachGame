using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Slime : Enemy
    {
        public Slime(): base(name: "Slime", damage: 1, health: 5, healthMax: 5, armor: 1, rangeAtack: 1,
            atackCount: 10, cellAtackCount: 15, dangerProcent: 10)
        {}

        public override int getArmor()
        {
            return armor;
        }

        public override int getAtackCount()
        {
            return atackCount;
        }

        public override Enemy GetBaseComponent()
        {
            return this;
        }

        public override int getCellAtackCount()
        {
            return cellAtackCount;
        }

        public override int getDamage()
        {
            return damage;
        }

        public override int getDanegerProcent()
        {
            return dangerProcent;
        }

        public override int getMatrixDefColumns()
        {
            return matrixDefColumns;
        }

        public override int getMatrixDefRows()
        {
            return matrixDefRows;
        }

        public override int getRangeAtack()
        {
            return rangeAtack;
        }
    }
}
