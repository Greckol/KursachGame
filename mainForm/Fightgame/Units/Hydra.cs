using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame.Units
{
    internal class Hydra: Enemy
    {
        public Hydra() : base(name: "Hydra", damage: 15, health: 50, healthMax: 50, healthRegeneration: 10, armor: 2, rangeAtack: 3,
            atackCount: 15, cellAtackCount: 15, dangerProcent: 25, expReward: 35, speedAtack: 12)
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
