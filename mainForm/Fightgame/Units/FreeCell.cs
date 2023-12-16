using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class FreeCell : Unit
    {
        
        public FreeCell(): base(name: "#", health: 0) 
        {
        }

        public override void Die()
        {
            
        }

        public override int getArmor()
        {
            return armor;
        }

        public override int getDamage()
        {
            return damage;
        }

        public override int getHealthRegeneration()
        {
            return hpRegeneration;
        }

        public override int getRangeAtack()
        {
            return rangeAtack;
        }
    }
}
