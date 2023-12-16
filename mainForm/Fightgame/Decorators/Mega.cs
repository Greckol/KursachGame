using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    class Mega : EnemyDecorator
    {
        public Mega(Enemy enemy) : base(enemy, enemy.Name + " Mega")
        {
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
            return enemy.getCellAtackCount() - 5;
        }

        public override int getCritChance()
        {
            return enemy.getCritChance();
        }

        public override int getDamage()
        {
            return enemy.getDamage() * 10;
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
            return enemy.getMatrixDefColumns();
        }

        public override int getMatrixDefRows()
        {
            return enemy.getMatrixDefRows();
        }

        public override int getRangeAtack()
        {
            return enemy.getRangeAtack() + 5;
        }

        public override int getSpeed()
        {
            return enemy.getSpeed();
        }
    }
}
