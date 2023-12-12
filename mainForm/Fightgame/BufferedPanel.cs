using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
