using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public abstract class Enemy : Unit
    {
        public abstract void AtackPattern(MatrixDef matrix);
    }
}
