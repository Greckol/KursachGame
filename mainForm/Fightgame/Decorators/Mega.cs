using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    class Mega : EnemyDecorator
    {
        public Mega(Enemy enemy) : base(enemy, "Mega " + enemy.Name)
        {
            healthMax = getHealthMax() * 2;
            health = getHealth() * 2;
        }

        public override int getArmor()
        {
            return enemy.getArmor() + enemy.getArmor() / 3;
        }

        public override int getAtackCount()
        {
            return enemy.getAtackCount() * 2;
        }

        public override int getCellAtackCount()
        {
            return enemy.getCellAtackCount() * 2;
        }

        public override int getCritChance()
        {
            return enemy.getCritChance() * 2;
        }

        public override int getDamage()
        {
            return enemy.getDamage() * 2;
        }

        public override int getDanegerProcent()
        {
            return enemy.getDanegerProcent() * 2;
        }

        public override int getExpReward()
        {
            return enemy.getExpReward() * 5;
        }

        public override int getGoldReward()
        {
            return enemy.getGoldReward() * 3;
        }

        public override int getHealthRegeneration()
        {
            return enemy.getHealthRegeneration() * 2; 
        }

        public override int getMatrixDefColumns()
        {
            return enemy.getMatrixDefColumns() + enemy.getMatrixDefColumns() / 2;
        }

        public override int getMatrixDefRows()
        {
            return enemy.getMatrixDefRows() + enemy.getMatrixDefColumns() / 2;
        }

        public override int getRangeAtack()
        {
            return enemy.getRangeAtack() + 3;
        }

        public override int getSpeed()
        {
            return enemy.getSpeed() * 2;
        }
    }
}
