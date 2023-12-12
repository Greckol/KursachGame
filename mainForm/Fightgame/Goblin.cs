using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class Goblin : Unit
    {
        public Goblin():base(name: "Goblin") { }

        public override void AtackPattern(MatrixDef matrix)
        {
            throw new NotImplementedException();
        }

        public override void Die()
        {
            throw new NotImplementedException();
        }
    }
}
