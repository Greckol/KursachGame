using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    class Vampire : EnemyDecorator
    {
        public Vampire(Enemy enemy) : base(enemy, enemy.Name + " Vampire")
        {
            healthMax *= 2;
            health *= 2;
        }

        public override int getArmor()
        {
            return enemy.getArmor();
        }

        public override int getAtackCount()
        {
            return enemy.getAtackCount() + 2;
        }

        public override int getCellAtackCount()
        {
            return enemy.getCellAtackCount() - 2;
        }

        public override int getDamage()
        {
            return enemy.getDamage() + 1;
        }

        public override int getDanegerProcent()
        {
            return enemy.getDanegerProcent();
        }

        public override int getExpReward()
        {
            return enemy.getExpReward();
        }

        public override int getGoldReward()
        {
            return enemy.getGoldReward();
        }

        public override int getHealthRegeneration()
        {
            return enemy.getHealthRegeneration();
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
            return enemy.getRangeAtack() + 2;
        }
    }
}
