using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    abstract class EnemyDecorator: Enemy
    {
        protected Enemy enemy;
        public EnemyDecorator(Enemy enemy, string name): base(name: name)
        {
            this.enemy = enemy;
        }
        public override Enemy GetBaseComponent()
        {
           return enemy.GetBaseComponent();
        }
    }
}
