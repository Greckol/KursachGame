﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    internal class ProgressB
    {
        static public void refreshProgress(ProgressBar progressB, Unit u)
        {
            progressB.Minimum = 0;
            progressB.Maximum = u.HealthMax;
            progressB.Value = u.Health;
        }

        static public void refreshExpBar(ProgressBar expBar, Player player)
        {
            expBar.Minimum = 0;
            expBar.Maximum = player.ExpMax;
            expBar.Value = player.Exp;
        }
    }
}
