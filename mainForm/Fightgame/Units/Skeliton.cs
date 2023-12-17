using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame.Units
{
    class Skeliton: Enemy
    {
        public Skeliton() : base(name: "Skeliton", damage: 8, health: 20, healthMax: 20, healthRegeneration: 2, armor: 2, rangeAtack: 1,
            atackCount: 8, cellAtackCount: 18, dangerProcent: 15, expReward: 15, speedAtack: 8)
        { }

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

