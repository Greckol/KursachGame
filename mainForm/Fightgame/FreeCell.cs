using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class FreeCell : Unit
    {
        public FreeCell(): base() 
        {
            Simvol = '#';
            Invulnerable = true;
        }
        

        public override bool checkAtackRange(List<List<char>> matrix)
        {
            throw new NotImplementedException();
        }

        public override bool checkVision()
        {
            throw new NotImplementedException();
        }


    }
}
