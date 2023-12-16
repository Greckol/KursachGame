using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame.Units
{
    class Dragon: Enemy
    {
        public Dragon(): base(name: "Dragon", damage: 30, health: 100, healthMax: 100, healthRegeneration: 5, armor: 3, rangeAtack: 2,
            atackCount: 20, cellAtackCount: 20, dangerProcent: 20, expReward: 50, speedAtack: 15) { }

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

        public override int getCritChance()
        {
            return critChance;
        }

        public override int getDamage()
        {

            return damage;
        }

        public override int getDanegerProcent()
        {
            return dangerProcent;
        }

        public override int getExpReward()
        {
            return expReward;
        }

        public override int getGoldReward()
        {
            return goldReward;
        }

        public override int getHealthRegeneration()
        {
            return healthRegeneration;
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

        public override int getSpeed()
        {
            return speedAtack;
        }
    }
}
