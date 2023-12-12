using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class FreeCell : Unit
    {
        public FreeCell(char simvol = '#'): base() 
        {
            Simvol = simvol;
            Invulnerable = true;
        }

        public override void AtackPattern(MatrixDef matrix)
        {
            throw new NotImplementedException();
        }

        
    }
}
