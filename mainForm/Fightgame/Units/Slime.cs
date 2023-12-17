using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    class Slime : Enemy
    {
        public Slime(): base(name: "Slime", damage: 4, health: 8, healthMax: 8, healthRegeneration: 1, armor: 1, rangeAtack: 1,
            atackCount: 10, cellAtackCount: 15, dangerProcent: 10, expReward: 5, goldReward: 7, speedAtack: 5)
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
