using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    class Mystery : EnemyDecorator
    {
        public Mystery(Enemy enemy) : base(enemy, "Mystery " + enemy.Name)
        {
            healthMax += getHealthMax() / 2;
            health += getHealth() / 2;
        }

        public override int getArmor()
        {
            return enemy.getArmor() + 1;
        }

        public override int getAtackCount()
        {
            return enemy.getAtackCount() + 2;
        }

        public override int getCellAtackCount()
        {
            return enemy.getCellAtackCount() - 2;
        }

        public override int getCritChance()
        {
            return enemy.getCritChance() + 10;
        }

        public override int getDamage()
        {
            return enemy.getDamage() + 1;
        }

        public override int getDanegerProcent()
        {
            return enemy.getDanegerProcent() + 10;
        }

        public override int getExpReward()
        {
            return enemy.getExpReward() * 2;
        }

        public override int getGoldReward()
        {
            return enemy.getGoldReward() * 2;
        }

        public override int getHealthRegeneration()
        {
            return enemy.getHealthRegeneration() + 1;
        }

        public override int getMatrixDefColumns()
        {
            return enemy.getMatrixDefColumns() + 1;
        }

        public override int getMatrixDefRows()
        {
            return enemy.getMatrixDefRows() + 1;
        }

        public override int getRangeAtack()
        {
            return enemy.getRangeAtack() + 1;
        }

        public override int getSpeed()
        {
            return enemy.getSpeed() + 7;
        }
    }
}
